using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TeximpNet;
using TeximpNet.DDS;
using TeximpNet.Compression;
using DDSReader;
using StoneMask.Properties;
using static StoneMask.Program;
using static StoneMask.Variables;

namespace StoneMask
{
    public partial class StoneMask : Form, IDisposable
    {
        public StoneMask()
        {
            InitializeComponent();
        }

        private void NoesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoesisSettings settings = new NoesisSettings();
            settings.Show(this);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutPopup = new About();
            aboutPopup.Show(this);
        }

        private void EnableButtons()
        {
            if (xfbinOpen && textureCount > 0)
            {
                exportXfbinDDS.Enabled = true;
                //exportNUT.Enabled = true; (Disabled for now as previously modded textures don't load in smash forge)
                modelPreview.Enabled = true;
                if (moddedTexOpen == true)
                {
                    replaceButton.Enabled = true;
                    exportModdedDDSButton.Enabled = true;
                    exportXFBINButton.Enabled = true;
                }
            }
            else if (moddedTexOpen) exportModdedDDSButton.Enabled = true;
        }

        private void XfbinClose()
        {
            selectTexBox.Items.Clear();
            xfbinPathBox.Text = "";
            mipMapCountLabel1.Text = "None";
            resolutionCheck1.Text = "None";
            originalTexCompression.Text = "None";
            previewLabel1.Text = "";
            previewLabel2.Text = "";
            texturePreview1.Image = null;
            nameCount = 0;
            textureCount = 0;
            fileBytes.Clear();
            texList.Clear();
            xfbinOpen = false;
        }

        private void XfbinBackup(FileInfo info)
        {
            if (!File.Exists(xfbinPath + ".bak") && !xfbinPath.EndsWith(".bak"))
            {
                info.CopyTo(xfbinPath + ".bak");
            }
        }

        private void XfbinOpen()
        {
            XfbinClose();
            xfbinPathBox.Text = xfbinPath;
            xfbinOpen = true;
            // Zealot's code for reading hex of xfbin
            byte[] xfbinFile = File.ReadAllBytes(xfbinPath);
            for (int a = 0; a < xfbinFile.Length; a++)
            {
                fileBytes.Add(xfbinFile[a]);
            }

            //Generate list of NTP3 files
            searchResults = SearchForByte("NTP3", fileBytes, 0, fileBytes.Count, 0);
            for (int i = 0; i < searchResults.Count; i++)
            {
                int x = searchResults[i];
                int headerLength = fileBytes[x + 0x1D]; // headerLength is the length of the header,
                int texStart = x + headerLength + 0x10; // while headerSize is textureSize + headerLength
                int fileSize = fileBytes[x - 0x17] * 0x10000 + fileBytes[x - 0x16] * 0x100 + fileBytes[x - 0x15];
                int ntp3Size = fileBytes[x - 3] * 0x10000 + fileBytes[x - 2] * 0x100 + fileBytes[x - 1];
                int headerSize = fileBytes[x + 0x11] * 0x10000 + fileBytes[x + 0x12] * 0x100 + fileBytes[x + 0x13];
                int textureSize = fileBytes[x + 0x19] * 0x10000 + fileBytes[x + 0x1A] * 0x100 + fileBytes[x + 0x1B];
                int mipCount = fileBytes[x + 0x21];
                string format = NTP3Format(fileBytes[x + 0x23]);
                int resX = fileBytes[x + 0x24] * 0x100 + fileBytes[x + 0x25];
                int resY = fileBytes[x + 0x26] * 0x100 + fileBytes[x + 0x27];
                byte DXT = new byte();

                if (format == "DXT1")
                    DXT = 0x31;
                else if (format == "DXT5")
                    DXT = 0x35;

                byte[] bytesY = BitConverter.GetBytes(resY);
                byte[] bytesX = BitConverter.GetBytes(resX);
                byte y1, y2, x1, x2;
                y1 = y2 = x1 = x2 = 0x00;

                y1 = bytesY[0];
                y2 = bytesY[1];
                x1 = bytesX[0];
                x2 = bytesX[1];

                // Create header
                List<byte> ddsHeader = new List<byte>() { 0x44, 0x44, 0x53, 0x20, 0x7C, 0x00, 0x00, 0x00, 0x07, 0x10, 0x00, 0x00, y1, y2, 0x00, 0x00,
                                                          x1, x2, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00,
                                                          0x04, 0x00, 0x00, 0x00, 0x44, 0x58, 0x54, DXT, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                                          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00,
                                                          0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
                List<byte> textureFile = new List<byte>();
                for (int b = 0; b < ddsHeader.Count; b++)
                {
                    textureFile.Add(ddsHeader[b]);
                }
                for (int a = 0; a < textureSize; a++)
                {
                    textureFile.Add(fileBytes[texStart + a]);
                }

                Bitmap preview;
                if (format == "Unknown format") preview = null;
                else preview = DDSImage.ConvertDDSToPng(textureFile.ToArray());

                texList.Add(new NUT
                {
                    NutIndex = x,
                    TexIndex = texStart,
                    FileSize = fileSize,
                    NTP3Size = ntp3Size,
                    HeaderSize = headerSize,
                    TexSize = textureSize,
                    MipMaps = mipCount,
                    Format = format,
                    ResX = resX,
                    ResY = resY,
                    TexFile = textureFile,
                    Preview = preview
                });
                textureCount++;
            }

            // Check if file contains textures
            if (textureCount == 0)
            {
                XfbinClose();
                MessageBox.Show("This file does not contain any textures. Please open another one.");
                return;
            }

            // Generate texture names list
            int nuccID = SearchForByte("nucc", fileBytes, 5, fileBytes.Count, 1)[0];
            int StartID = SearchForByte("null2", fileBytes, nuccID, fileBytes.Count, 1)[0] + 2;
            int EndID = SearchForByte("null4", fileBytes, nuccID, fileBytes.Count, 1)[0];
            int NutEnd = StartID;

            List<string> Lines = new List<string>();
            List<byte> nameBytes = new List<byte>();
            // Clears textbox if browse is clicked again
            selectTexBox.Items.Clear();

            searchResults = SearchForByte(".nut", fileBytes, NutEnd, EndID, 0);
            for (int i = 0; i < searchResults.Count; i++)
            {
                int x = searchResults[i];
                int start = SearchForByte("/", fileBytes, x, NutEnd, 1)[0];
                for (int b = start + 1; b < x; b++) nameBytes.Add(fileBytes[b]);
                nameBytes.Add(0x0A);
                nameCount++;
                if (nameCount == textureCount) i = searchResults.Count;
            }

            // Alternate fix for extra line, needed here before we add it to the list
            int lastByte = nameBytes.Count - 1;
            nameBytes.RemoveAt(lastByte);

            string tx = Encoding.ASCII.GetString(nameBytes.ToArray());
            Lines = tx.Split('\n').ToList();
            nameBytes.Clear();

            // Add names to their corresponding textures
            for (int x = 0; x < nameCount; x++)
            {
                texList[x].TexName = Lines[x];
            }

            foreach (var nameInList in texList)
            {
                selectTexBox.Items.Add(nameInList.TexName);
                // Remove empty line at the end
                if (nameInList.TexName == "")
                    selectTexBox.Items.Remove(nameInList.TexName);
            }

            // Change focus to selectTexBox and enable buttons
            selectTexBox.SelectedIndex = 0;
            selectTexBox.Focus();
            EnableButtons();
        }

        // Open XFBIN (1st browse button)
        private void XfbinBrowse_Click(object sender, EventArgs e)
        {
            openXfbinDialog.Multiselect = false;
            if (openXfbinDialog.ShowDialog() == DialogResult.OK)
            {
                xfbinPath = openXfbinDialog.FileName;
                XfbinOpen();
            }
        }

        // Open XFBIN (Drag and Drop)
        private void XfbinPathBox_DragOver(object sender, DragEventArgs e)
        {
            dragFilePath = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                string format = Path.GetExtension(files[0]);
                if (files.Length == 1)
                {
                    if (format == ".xfbin" || format == ".bak" && files[0].Contains(".xfbin"))
                    {
                        e.Effect = DragDropEffects.Copy;
                        dragFilePath = files[0];
                    }
                }
            }
        }

        private void XfbinPathBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            xfbinPathBox.Text = dragFilePath;
            xfbinPath = xfbinPathBox.Text;
            XfbinOpen();
            return;
        }

        // Open XFBIN (enter key pressed)
        private void XfbinPathBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && File.Exists(xfbinPathBox.Text))
            {
                xfbinPath = xfbinPathBox.Text;
                XfbinOpen();
            }
        }

        // Made it into a new method to call it after replacing a texture
        private void RefreshProperties()
        {
            int x = selectTexBox.SelectedIndex;
            originalTexCompression.Text = texList[x].Format;
            mipMapCountLabel1.Text = texList[x].MipMaps.ToString();
            resolutionCheck1.Text = texList[x].ResX.ToString() + "x" + texList[x].ResY.ToString();
            mipMapSetting.Value = texList[x].MipMaps;
            mipSliderValue.Text = mipMapSetting.Value.ToString();

            // Convert dds to png for preview
            previewLabel1.Text = "Preview:";
            texturePreview1.Image = texList[x].Preview;
            texturePreview1.SizeMode = PictureBoxSizeMode.Zoom;

            //Export settings
            if (texList[x].Format == "DXT1")
                exportSettingBox.SelectedIndex = 0;
            else if (texList[x].Format == "DXT5")
                exportSettingBox.SelectedIndex = 1;
        }

        // Update texture related content whenever the selected item changes
        private void SelectTexBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProperties();
        }

        private void ModdedTexOpen()
        {
            moddedTexPathBox.Text = moddedTexPath;
            moddedTexOpen = true;
            if (!isWebImage) texturePreview2.Image = null;
            moddedFormat = "None";
            // Check if file is dds or png
            if (DDSFile.IsDDSFile(moddedTexPath) == true)
            {
                // Get dds data
                DDSContainer moddedTexture = DDSFile.Read(moddedTexPath);
                moddedFormat = moddedTexture.Format.ToString();
                int moddedMipCount = moddedTexture.MipChains[0].Count;
                if (moddedFormat == "BC3_UNorm")
                    moddedFormat = "DXT5";
                else if (moddedFormat == "BC1_UNorm")
                    moddedFormat = "DXT1";

                // Convert to png for preview
                DDSImage modDDS = new DDSImage(moddedTexPath);
                MemoryStream pngStream = new MemoryStream();
                modDDS.SaveAsPng(pngStream);
                var newPNG = Image.FromStream(pngStream);

                // Change labels
                moddedTexCompression.Text = moddedFormat;
                mipMapCountLabel2.Text = moddedMipCount.ToString();
                texturePreview2.Image = newPNG;
                previewLabel2.Text = "Preview:";
                resolutionCheck2.Text = texturePreview2.Image.Width.ToString() + "x" + texturePreview2.Image.Height.ToString();
                texturePreview2.SizeMode = PictureBoxSizeMode.Zoom;

                // Dispose
                pngStream.Dispose();
                moddedTexture.Dispose();
            }
            else
            {
                // Bitmap/Png format
                if (moddedTexPath.Contains(".bmp")) moddedTexCompression.Text = "None (Bitmap)";
                else if (moddedTexPath.Contains(".png")) moddedTexCompression.Text = "None (PNG)";
                else moddedTexCompression.Text = "None";
                mipMapCountLabel2.Text = "None";
                previewLabel2.Text = "Preview:";
                if (!isWebImage)
                {
                    texturePreview2.Image = new Bitmap(moddedTexPath);
                    texturePreview2.SizeMode = PictureBoxSizeMode.Zoom;
                }
                resolutionCheck2.Text = texturePreview2.Image.Width.ToString() + "x" + texturePreview2.Image.Height.ToString();

            }
            EnableButtons();
        }

        private void MipMapSetting_Scroll(object sender, EventArgs e)
        {
            mipSliderValue.Text = mipMapSetting.Value.ToString();
        }

        // Open modded texture (2nd browse button)
        private void ModdedTexBrowse_Click(object sender, EventArgs e)
        {
            openModdedTexDialog.Multiselect = false;
            if (openModdedTexDialog.ShowDialog() == DialogResult.OK)
            {
                moddedTexPath = openModdedTexDialog.FileName;
                isWebImage = false;
                ModdedTexOpen();
            }
        }

        // Open modded texture (Drag and Drop)
        private void ModdedTexPathBox_DragOver(object sender, DragEventArgs e)
        {
            dragFilePath = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                string format = Path.GetExtension(files[0]);
                if (files.Length == 1)
                {
                    if (format == ".dds" || format == ".png" || format == ".bmp")
                    {
                        e.Effect = DragDropEffects.Copy;
                        dragFilePath = files[0];
                    }
                }
            }
            else if (e.Data.GetDataPresent("UniformResourceLocator")) e.Effect = DragDropEffects.Link;
        }

        private void ModdedTexPathBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                moddedTexPathBox.Text = dragFilePath;
                moddedTexPath = moddedTexPathBox.Text;
                isWebImage = false;
                ModdedTexOpen();
            }

            // Get correct link to image if it's a url
            else if (e.Data.GetDataPresent("UniformResourceLocator"))
            {
                MemoryStream ms = e.Data.GetData("UniformResourceLocator") as MemoryStream;
                byte[] bytes = ms.ToArray();
                Encoding encode = Encoding.ASCII;
                string url = encode.GetString(bytes);
                string fileName = "";
                for (int x = url.Length; x > 1; x--)
                {
                    // .png, .jpg, .jpeg
                    if (url.ElementAt(x - 1) == 'g' && url.ElementAt(x - 2) == 'n' && url.ElementAt(x - 3) == 'p' && url.ElementAt(x - 4) == '.' ||
                        url.ElementAt(x - 1) == 'g' && url.ElementAt(x - 2) == 'p' && url.ElementAt(x - 3) == 'j' && url.ElementAt(x - 4) == '.' ||
                        url.ElementAt(x - 1) == 'g' && url.ElementAt(x - 2) == 'e' && url.ElementAt(x - 3) == 'p' && url.ElementAt(x - 4) == 'j' && url.ElementAt(x - 5) == '.')
                    {
                        imageUrl = url.Remove(x);
                        x = 1;
                    }
                }
                for (int x = imageUrl.Length; x > 1; x--)
                {
                    if (imageUrl.ElementAt(x - 1) == '/')
                    {
                        fileName = imageUrl.Substring(x);
                        x = 1;
                    }
                }
                SaveWebImage(fileName, System.Drawing.Imaging.ImageFormat.Png);
                isWebImage = true;
                ModdedTexOpen();
            }
        }

        // Open modded texture (enter key pressed)
        private void ModdedTexPathBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && File.Exists(moddedTexPathBox.Text))
            {
                moddedTexPath = moddedTexPathBox.Text;
                isWebImage = false;
                ModdedTexOpen();
            }
        }

        // Download image
        public void SaveWebImage(string filename, System.Drawing.Imaging.ImageFormat format)
        {
            if (filename == "") return;
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap; bitmap = new Bitmap(stream);
            string fileDir = Path.Combine(appData, filename);
            moddedTexPathBox.Text = fileDir;
            moddedTexPath = fileDir;
            if (bitmap != null)
            {
                if (File.Exists(fileDir)) File.Delete(fileDir);
                bitmap.Save(fileDir, format);
                dlPics.Add(fileDir);
                texturePreview2.Image = bitmap;
                texturePreview2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else MessageBox.Show($"Link does not direct to an image.");

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

        //Convert the png/export as dds
        public void CompressDDS()
        {
            Surface newDDS = Surface.LoadFromFile(moddedTexPath, true);
            MipmapFilter MipmapFilter = MipmapFilter.Box;
            CompressionFormat texFormat = new CompressionFormat();
            if (exportSettingBox.SelectedIndex == 0)
                texFormat = CompressionFormat.DXT1a;
            else if (exportSettingBox.SelectedIndex == 1)
                texFormat = CompressionFormat.DXT5;
            Compressor compress = new Compressor();
            compress.Input.SetData(newDDS);
            compress.Compression.Format = texFormat;
            compress.Input.SetMipmapGeneration(true, mipMapSetting.Value);
            compress.Input.MipmapFilter = MipmapFilter;
            // Removes the DDS header for the save xfbin button
            if (ddsNoHeader == true)
            {
                compress.Output.OutputHeader = false;
                compress.Process(ddsStream);
                byte[] ddsArray = ddsStream.ToArray();
                int ddsLength = ddsArray.Length;
                int texIndex = selectTexBox.SelectedIndex;
                bool success = ReplaceTexture(texIndex, ddsArray);
                UpdateNut(texIndex, ddsLength, mipMapSetting.Value, texFormat, newDDS.Width, newDDS.Height);
                if (success) MessageBox.Show($"Texture Replaced.", $"Success");
                ddsStream.Dispose();
            }
            else
            {
                compress.Process("new.dds");
            }
            compress.Dispose();
            newDDS.Dispose();
        }

        private void UpdateNut(int index, int size, int mipmaps, CompressionFormat format, int resX, int resY)
        {
            int a = texList[index].NutIndex;
            int headSize = texList[index].HeaderSize;
            int texSize = texList[index].TexSize;
            int diff;
            if (size != texSize) diff = size - texSize;
            else diff = 0; // Will just update mipmaps/format/res

            if (diff != 0)
            {
                byte[] bytesSize1 = BitConverter.GetBytes(size + 0x9C);
                byte[] bytesSize2 = BitConverter.GetBytes(size + 0x90);
                byte[] bytesSize3 = BitConverter.GetBytes(headSize + diff);
                byte[] bytesSize4 = BitConverter.GetBytes(size);
                fileBytes[a - 0x17] = bytesSize1[2]; // fileSize
                fileBytes[a - 0x16] = bytesSize1[1];
                fileBytes[a - 0x15] = bytesSize1[0];
                fileBytes[a - 0x03] = bytesSize2[2]; // ntp3Size
                fileBytes[a - 0x02] = bytesSize2[1];
                fileBytes[a - 0x01] = bytesSize2[0];
                fileBytes[a + 0x11] = bytesSize3[2]; // headerSize
                fileBytes[a + 0x12] = bytesSize3[1];
                fileBytes[a + 0x13] = bytesSize3[0];
                fileBytes[a + 0x19] = bytesSize4[2]; // textureSize
                fileBytes[a + 0x1A] = bytesSize4[1];
                fileBytes[a + 0x1B] = bytesSize4[0];
                texList[index].FileSize = size + 0x9C; // Update sizes in texList
                texList[index].NTP3Size = size + 0x90;
                texList[index].TexSize = size;
            }

            byte mips = Convert.ToByte(mipmaps);
            byte compFormat = 0x00;
            if (format == CompressionFormat.DXT1a) compFormat = 0x00;
            else if (format == CompressionFormat.DXT5) compFormat = 0x02;
            byte[] bytesX = BitConverter.GetBytes(resX);
            byte[] bytesY = BitConverter.GetBytes(resY);
            fileBytes[a + 0x21] = mips; // mipCount
            fileBytes[a + 0x23] = compFormat; // format
            fileBytes[a + 0x24] = bytesX[1]; // resX
            fileBytes[a + 0x25] = bytesX[0];
            fileBytes[a + 0x26] = bytesY[1]; // resY
            fileBytes[a + 0x27] = bytesY[0];
            texList[index].MipMaps = mipmaps; // Update properties in texList
            texList[index].Format = NTP3Format(compFormat);
            texList[index].ResX = resX;
            texList[index].ResY = resY;

            foreach (var i in texList) // Update index for other NUTs
            {
                if (i.NutIndex > texList[index].NutIndex)
                {
                    i.NutIndex += diff;
                    i.TexIndex += diff;
                }
            }
            RefreshProperties();
        }

        // bool just so it can refresh the properties before showing success
        private bool ReplaceTexture(int index, byte[] newArray)
        {
            texList[index].TexFile.Clear();
            texList[index].TexFile = newArray.ToList(); // Update texture in texList
            int a = texList[index].NutIndex;
            int b = texList[index].TexIndex;
            int z = texList[index].TexSize;

            // Move the rest of the file into a new array temporarily
            byte[] temp = new byte[fileBytes.Count - (b + z)];
            fileBytes.CopyTo(b + z, temp, 0, fileBytes.Count - (b + z));
            fileBytes.RemoveRange(b, fileBytes.Count - b);

            // Add the new texture and the rest of the file
            for (int i = 0; i < newArray.Length; i++) fileBytes.Add(newArray[i]);
            for (int i = 0; i < temp.Length; i++) fileBytes.Add(temp[i]);

            texList[index].Preview = texturePreview2.Image as Bitmap; // Update preview in texList
            return true;
        }

        // Save Modded DDS Button
        private void DDSSave_Click(object sender, EventArgs e)
        {
            ddsNoHeader = false;
            CompressDDS();
            MessageBox.Show("Texture saved as \"new.dds\" in the program folder.", $"Success");
        }

        // Save XFBIN button
        private void XfbinSave_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(xfbinPath);
            XfbinBackup(file);
            File.WriteAllBytes(xfbinPath, fileBytes.ToArray());
            MessageBox.Show("File saved as " + file.Name + " in the original directory.", $"Success");
        }

        private void ExportXfbinDDS_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes($"{texList[selectTexBox.SelectedIndex].TexName}.dds", texList[selectTexBox.SelectedIndex].TexFile.ToArray());
            MessageBox.Show($"Texture saved as \"{texList[selectTexBox.SelectedIndex].TexName}.dds\" in the program folder.", $"Success");
        }

        private void ExportNUT_Click(object sender, EventArgs e)
        {
            int index = selectTexBox.SelectedIndex;
            List<byte> nut = new List<byte>();
            for (int x = texList[index].NutIndex; x < texList[index].NutIndex + texList[index].FileSize; x++)
            {
                nut.Add(fileBytes[x]);
            }
            File.WriteAllBytes($"{texList[index].TexName}.nut", nut.ToArray());
            MessageBox.Show($"Texture saved as \"{texList[index].TexName}.nut\" in the program folder.", $"Success");
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ddsNoHeader = true;
            CompressDDS();
        }

        private bool CreateModelPreview()
        {
            if (SearchForByte("NDP3", modelBytes, 0, modelBytes.Count, 0).Any())
            {
                int index = SearchForByte("NTP3", modelBytes, 0, modelBytes.Count, 1)[0];
                int texIndex = SearchForByte("GIDX", modelBytes, index, modelBytes.Count, 1)[0] + 0x10;
                int texSize = modelBytes[index + 0x19] * 0x10000 + modelBytes[index + 0x1A] * 0x100 + modelBytes[index + 0x1B];
                int nutSize = texList[selectTexBox.SelectedIndex].NTP3Size;
                byte[] newTexture = new byte[nutSize];
                fileBytes.CopyTo(texList[selectTexBox.SelectedIndex].NutIndex, newTexture, 0, nutSize);
                ReplaceModelTexture(index, texIndex, texSize, newTexture);
                File.WriteAllBytes(Path.Combine(previewPath, "preview.xfbin"), modelBytes.ToArray());
                return true;
            }
            else
            {
                MessageBox.Show($"Xfbin doesn't contain any meshes. Please select a valid xfbin.", $"Error");
                return false;
            }
        }

        private void ModelPreview_Click(object sender, EventArgs e)
        {
            openModelDialog.Multiselect = false;
            if (openModelDialog.ShowDialog() == DialogResult.OK)
            {
                modelBytes.Clear();
                modelBytes = File.ReadAllBytes(openModelDialog.FileName).ToList();
                string directory = Settings.Default.NoesisDirectory;
                if (Settings.Default.PreviewCheck)
                    previewPath = Path.GetDirectoryName(Application.ExecutablePath);
                else previewPath = appData;
                if (CreateModelPreview())
                {
                    if (File.Exists(Path.Combine(directory, "Noesis.exe")))
                    {
                        Noesis = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                        {
                            WorkingDirectory = directory,
                            FileName = "Noesis.exe",
                            Arguments = Path.Combine(previewPath, "preview.xfbin")
                        };
                        Noesis.StartInfo = startInfo;
                        noesisStarted = Noesis.Start();
                    }
                    else MessageBox.Show($"Noesis path not set. Please change it from \"Settings\".", $"Error");
                }
            }
        }

        private void StoneMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Settings.Default.NoesisCloseCheck && noesisStarted && !Noesis.HasExited)
                Noesis.CloseMainWindow();
            Application.Exit();
        }

        private void StoneMask_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(appData)) Directory.CreateDirectory(appData);
        }

        // Clears the folder in AppData until we add an option to keep the files
        /* Commented out for now cause it can't delete files downloaded from discord app
        private void StoneMask_FormClosing(object sender, FormClosingEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(appData);

            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }
        */
    }
}
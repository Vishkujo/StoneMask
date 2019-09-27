using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using TeximpNet;
using TeximpNet.DDS;
using TeximpNet.Compression;
using DDSReader;

namespace StoneMask
{
    public partial class StoneMask : Form, IDisposable
    {
        public StoneMask()
        {
            InitializeComponent();
        }

        // variables
        public string xfbinPath;
        public string moddedTexPath;
        public string dragFilePath;
        public bool xfbinOpen;
        public bool moddedTexOpen;
        public string moddedFormat;
        public bool ddsNoHeader = false;
        public List<byte> fileBytes = new List<byte>();
        public List<NUT> texList = new List<NUT>();
        public int textureCount = 0;
        public int nameCount = 0;

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by SutandoTsukai181 and Vish (@VEpicAGE)");
        }

        // Gets compression format from NTP3 header
        public string NTP3Format(int formatByte)
        {
            if (formatByte == 0x0)
            {
                return "DXT1";
            }
            else if (formatByte == 0x2)
            {
                return "DXT5";
            }
            else return "Unknown format";
        }

        private void EnableButtons()
        {
            if (xfbinOpen && textureCount > 0)
            {
                exportXfbinDDS.Enabled = true;
                exportNUT.Enabled = true;
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
            Array.Clear(xfbinFile, 0, xfbinFile.Length);

            //Generate list of NTP3 files
            {
                for (int x = 0; x < fileBytes.Count - 3; x++)
                {
                    //NTP3
                    if (fileBytes[x] == 78 && fileBytes[x + 1] == 84 && fileBytes[x + 2] == 80 && fileBytes[x + 3] == 51)
                    {
                        int headerSize = fileBytes[x + 0x1D];
                        int texStart = x + headerSize + 0x10;
                        int fileSize = fileBytes[x - 0x17] * 0x10000 + fileBytes[x - 0x16] * 0x100 + fileBytes[x - 0x15];
                        int ntp3Size = fileBytes[x - 3] * 0x10000 + fileBytes[x - 2] * 0x100 + fileBytes[x - 1];
                        //int textureSize3 = fileBytes[x + 0x11] * 0x10000 + fileBytes[x + 0x12] * 0x100 + fileBytes[x + 0x13];
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
                            FileSize = fileSize,
                            NTP3Size = ntp3Size,
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
                }
            }

            // Check if file contains textures
            if (textureCount == 0)
            {
                XfbinClose();
                MessageBox.Show("This file does not contain any textures. Please open another one.");
                return;
            }

            // Generate texture names list
            // Had to move it down so we can limit the number of names
            {
                int nuccID = 0x00;
                int StartID = 0x00;
                int EndID = 0x00;
                int NutEnd = 0x00;

                for (int x = 0; x < fileBytes.Count - 3; x++)
                {
                    //nucc
                    if (fileBytes[x] == 110 && fileBytes[x + 1] == 117 && fileBytes[x + 2] == 99 && fileBytes[x + 3] == 99)
                    {
                        nuccID = x;
                        for (int o = nuccID; o < fileBytes.Count; o++)
                        {
                            if (fileBytes[o] == 0 && fileBytes[o + 1] == 0)
                            {
                                StartID = o + 2;
                                o = fileBytes.Count;
                            }
                        }
                        x = fileBytes.Count;
                    }
                }
                for (int x = StartID + 1; x < fileBytes.Count; x++)
                {
                    if (fileBytes[x] == 0 && fileBytes[x + 1] == 0 && fileBytes[x + 2] == 0 && fileBytes[x + 3] == 0)
                    {
                        EndID = x;
                        x = fileBytes.Count;
                    }
                }

                NutEnd = StartID;

                List<string> Lines = new List<string>();
                List<byte> nameBytes = new List<byte>();
                // Clears textbox if browse is clicked again
                selectTexBox.Items.Clear();

                for (int x = NutEnd; x < EndID; x++)
                {
                    //.nut
                    if (fileBytes[x] == 0x2E && fileBytes[x + 1] == 0x6E && fileBytes[x + 2] == 0x75 && fileBytes[x + 3] == 0x74)
                    {
                        for (int i = x; i > NutEnd; i--)
                        {
                            // /
                            if (fileBytes[i] == 0x2F)
                            {
                                for (int b = i + 1; b < x; b++)
                                {
                                    nameBytes.Add(fileBytes[b]);
                                }
                                nameBytes.Add(0x0A);
                                i = NutEnd - 1;
                            }
                        }
                        nameCount++;
                    }
                    if (nameCount == textureCount) x = EndID;
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
            }
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

        // Update texture related content whenever the selected item changes
        private void SelectTexBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ModdedTexOpen ()
        {
            moddedTexPathBox.Text = moddedTexPath;
            moddedTexOpen = true;
            texturePreview2.Image = null;
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

                //Dispose
                pngStream.Dispose();
                moddedTexture.Dispose();
            }
            else
            {
                //Bitmap/Png format
                if (moddedTexPath.Contains(".bmp")) moddedTexCompression.Text = "None (Bitmap)";
                else if (moddedTexPath.Contains(".png")) moddedTexCompression.Text = "None (PNG)";
                else moddedTexCompression.Text = "None";
                mipMapCountLabel2.Text = "None";
                previewLabel2.Text = "Preview:";
                texturePreview2.Image = new Bitmap(moddedTexPath);
                resolutionCheck2.Text = texturePreview2.Image.Width.ToString() + "x" + texturePreview2.Image.Height.ToString();
                texturePreview2.SizeMode = PictureBoxSizeMode.Zoom;
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
                    if (format == ".dds" || format == ".png" || format == ".bmp")
                    {
                        e.Effect = DragDropEffects.Copy;
                        dragFilePath = files[0];
                    }
            }
        }

        private void ModdedTexPathBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            moddedTexPathBox.Text = dragFilePath;
            moddedTexPath = moddedTexPathBox.Text;
            ModdedTexOpen();
            return;
        }

        // Open modded texture (enter key pressed)
        private void ModdedTexPathBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && File.Exists(moddedTexPathBox.Text))
            {
                moddedTexPath = moddedTexPathBox.Text;
                ModdedTexOpen();
            }
        }

        //Convert the png/export as dds
        public void CompressDDS()
        {
            Surface newDDS = Surface.LoadFromFile(openModdedTexDialog.FileName, true);
            MipmapFilter MipmapFilter = MipmapFilter.Triangle;
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
                compress.Output.OutputHeader = false;
            compress.Process("new.dds");
            compress.Dispose();
            newDDS.Dispose();
        }

        // Save DDS Button
        private void DDSSave_Click(object sender, EventArgs e)
        {
            CompressDDS();
            MessageBox.Show("Success. Texture saved as \"new.dds\" in the program folder.");
        }

        // Save XFBIN button
        private void XfbinSave_Click(object sender, EventArgs e)
        {
            ddsNoHeader = true;
        }

        private void ExportXfbinDDS_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes($"{texList[selectTexBox.SelectedIndex].TexName}.dds", texList[selectTexBox.SelectedIndex].TexFile.ToArray());
            MessageBox.Show($"Success.\nTexture saved as \"{texList[selectTexBox.SelectedIndex].TexName}.dds\" in the program folder.");
        }

        private void ExportNUT_Click(object sender, EventArgs e)
        {
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ddsNoHeader = true;
        }
    }
}

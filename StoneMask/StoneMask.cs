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

namespace StoneMask
{
    public partial class StoneMask : Form, IDisposable
    {
        public StoneMask()
        {
            InitializeComponent();
        }

        // variables
        public bool originalTexOpen;
        public bool moddedTexOpen;
        public bool xfbinOpen;
        public string moddedFormat;
        public bool saveXfbin = false;
        public List<byte> fileBytes = new List<byte>();
        public List<NUT> texList = new List<NUT>();
        public int textureCount = 0;
        public int nameCount = 0;

        // Open XFBIN (1st browse button)
        private void XfbinBrowse_Click(object sender, EventArgs e)
        {
            openXfbinDialog.Multiselect = false;
            if (openXfbinDialog.ShowDialog() == DialogResult.OK)
            {
                string xfbinPath = openXfbinDialog.FileName;
                xfbinPathBox.Text = xfbinPath;
                xfbinOpen = true;
                nameCount = 0;
                textureCount = 0;
                fileBytes.Clear();
                texList.Clear();
                // Zealot's code for reading hex of xfbin
                if (xfbinPath != "" && File.Exists(xfbinPath))
                {
                    byte[] xfbinFile = File.ReadAllBytes(xfbinPath);
                    for (int a = 0; a < xfbinFile.Length; a++)
                    {
                        fileBytes.Add(xfbinFile[a]);
                    }

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
                                int resX = fileBytes[x + 0x24] * 0x100 + fileBytes[x + 0x25];
                                int resY = fileBytes[x + 0x26] * 0x100 + fileBytes[x + 0x27];

                                List<byte> textureFile = new List<byte>();
                                for (int a = texStart; a < textureSize + 1; a++)
                                {
                                    textureFile.Add(xfbinFile[a]);
                                }
                                texList.Add(new NUT
                                {
                                    FileSize = fileSize,
                                    NTP3Size = ntp3Size,
                                    TexSize = textureSize,
                                    MipMaps = mipCount,
                                    ResX = resX,
                                    ResY = resY,
                                    TexFile = textureFile,
                                });
                                textureCount++;
                            }
                        }
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
                }
            }
        }
                       
        // Open modded texture (2nd browse button)
        private void ModdedTexBrowse_Click(object sender, EventArgs e)
        {
            openModdedTexDialog.Multiselect = false;
            if (openModdedTexDialog.ShowDialog() == DialogResult.OK)
            {
                moddedTexPathBox.Text = openModdedTexDialog.FileName;
                moddedTexOpen = true;
                string moddedFormat = "None";
                // Check if file is dds or png
                if (DDSFile.IsDDSFile(openModdedTexDialog.FileName) == true)
                {
                    // Get dds data
                    DDSContainer moddedTexture = DDSFile.Read(openModdedTexDialog.FileName);
                    moddedFormat = moddedTexture.Format.ToString();
                    if (moddedFormat == "BC3_UNorm")
                        moddedFormat = "DXT5";
                    else if (moddedFormat == "BC1_UNorm")
                        moddedFormat = "DXT1";
                    moddedTexCompression.Text = moddedFormat;
                    moddedTexture.Dispose();
                }
                else
                {
                    //PNG format
                    moddedTexCompression.Text = moddedFormat;                    
                }
            }
        }

        // Open original texture (3rd browse button)
        public void OriginalTexBrowse_Click(object sender, EventArgs e)
        {
            openOriginalTexDialog.Multiselect = false;
            if (openOriginalTexDialog.ShowDialog() == DialogResult.OK)
            {
                originaltexPathBox.Text = openOriginalTexDialog.FileName;
                // Get original DDS data
                DDSContainer originalDDS = DDSFile.Read(openOriginalTexDialog.FileName);
                string originalFormat = originalDDS.Format.ToString();
                int originalMMCount = originalDDS.MipChains[0].Count;
                if (originalFormat == "BC3_UNorm")
                {
                    originalFormat = "DXT5";
                    exportSettingBox.SelectedIndex = 2;
                }
                else if (originalFormat == "BC1_UNorm")
                {
                    originalFormat = "DXT1";
                    exportSettingBox.SelectedIndex = 0;
                }
                originalTexOpen = true;
                originalTexCompression.Text = originalFormat;
                mipMapCountLabel1.Text = originalMMCount.ToString();
            }
        }
        
        //Convert the png/export as dds
        public void Convert()
        {
            Surface newDDS = Surface.LoadFromFile(openModdedTexDialog.FileName, true);
            MipmapFilter MipmapFilter = MipmapFilter.Triangle;
            CompressionFormat texFormat = new CompressionFormat();
            if (exportSettingBox.SelectedIndex == 0)
                texFormat = CompressionFormat.DXT1;
            else if (exportSettingBox.SelectedIndex == 1)
                texFormat = CompressionFormat.DXT1a;
            else if (exportSettingBox.SelectedIndex == 2)
                texFormat = CompressionFormat.DXT5;
            Compressor compress;
            compress = new Compressor();
            compress.Input.SetData(newDDS);
            compress.Compression.Format = texFormat;
            compress.Input.SetMipmapGeneration(true, 12);
            compress.Input.MipmapFilter = MipmapFilter;
            // Removes the DDS header for the save xfbin button
            if (saveXfbin == true)
                compress.Output.OutputHeader = false;
            compress.Process("new.dds");
            compress.Dispose();
            newDDS.Dispose();
        }

        // Save DDS Button
        private void DDSSave_Click(object sender, EventArgs e)
        {
            // Check if both the original texture and modded texture are open
            if (originalTexOpen == true && moddedTexOpen == true)
            {
                //Convert the png/export as dds
                Convert();
                MessageBox.Show("Success. Texture saved as \"new.dds\" in the program folder.");
            }
            else
            {
                MessageBox.Show("Please open the original and/or modded texture first.");
            }
        }

        // Save XFBIN button
        private void XfbinSave_Click(object sender, EventArgs e)
        {
            // Check if all files open
            if (xfbinOpen == true && moddedTexOpen == true)
            {
                saveXfbin = true;
            }
        }
    }
}

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
using TeximpNet.DDS;
using TeximpNet;
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
        public DDSContainer originalDDS;
        public Surface newDDS;
        public bool setData;
        public string textureFormat;
        public string moddedFormat;
        public CompressionFormat texFormat;
        public bool saveXfbin = false;
        public List<byte> fileBytes = new List<byte>();
        //public List<string> NameList = new List<string>();
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
                // Zealot's code for reading hex of xfbin
                if (xfbinPath != "" && File.Exists(xfbinPath))
                {
                    byte[] xfbinFile = File.ReadAllBytes(xfbinPath);
                    for (int a = 0; a < xfbinFile.Length; a++)
                    {
                        fileBytes.Add(xfbinFile[a]);
                    }
					
					// Generate texture names list
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
                        List<byte> bytesInFile2 = new List<byte>();

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
                                            bytesInFile2.Add(fileBytes[b]);
                                        }
                                        bytesInFile2.Add(0x00);
                                        i = NutEnd - 1;
                                    }
                                }
                            }
                        }
                        for (int x = 0; x < bytesInFile2.Count; x++)
                        {
                            if (bytesInFile2[x] == 0x00)
                            {
                                bytesInFile2[x] = 0x0A;
                            }
                        }
                        string tx = Encoding.ASCII.GetString(bytesInFile2.ToArray());
                        Lines = tx.Split('\n').ToList();
                        bytesInFile2.Clear();

                        foreach (var nameInList in Lines)
                        {
                            selectTexBox.Items.Add(nameInList.ToString());
                        }
                        nameCount = Lines.Count;
                    }

                    //Generate list of NTP3 files
                    {
                        int textureCount = 0;
                        for (int x = 0; x < fileBytes.Count - 3; x++)
                        {
                            //NTP3
                            if (fileBytes[x] == 78 && fileBytes[x + 1] == 84 && fileBytes[x + 2] == 80 && fileBytes[x + 3] == 51)
                            {
                                int textureSize1 = fileBytes[x - 0x17] * 0x10000 + fileBytes[x - 0x16] * 0x100 + fileBytes[x - 0x15];
                                int textureSize2 = fileBytes[x - 3] * 0x10000 + fileBytes[x - 2] * 0x100 + fileBytes[x - 1];
                                //int textureSize3 = fileBytes[x + 0x11] * 0x10000 + fileBytes[x + 0x12] * 0x100 + fileBytes[x + 0x13];
                                int textureSize4 = fileBytes[x + 0x19] * 0x10000 + fileBytes[x + 0x1A] * 0x100 + fileBytes[x + 0x1B];
                                //int mipCount = fileBytes[x + 0x21];
                                int texStart = 0;
                                List<byte> textureFile = new List<byte>();

                                for (int a = x; a < textureSize1; a++)
                                {
                                    //GIDX
                                    if (fileBytes[a] == 71 && fileBytes[a + 1] == 73 && fileBytes[a + 2] == 68 && fileBytes[a + 3] == 88)
                                    {
                                        texStart = a + 16;
                                        a = textureSize1;
                                    }
                                }
                                for (int a = texStart; a < textureSize4 + 1; a++)
                                {
                                    textureFile.Add(xfbinFile[a]);
                                }
                                textureCount++;
                            }
                            if (textureCount == nameCount) x = fileBytes.Count;
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
                // Check if file is dds or png
                if (DDSFile.IsDDSFile(openModdedTexDialog.FileName) == true)
                {
                    // Get dds data
                    DDSContainer moddedTexture = DDSFile.Read(openModdedTexDialog.FileName);
                    moddedFormat = moddedTexture.Format.ToString();
                    newDDS = Surface.LoadFromFile(openModdedTexDialog.FileName, true);
                    if (moddedFormat == "BC3_UNorm")
                    {
                        moddedFormat = "DXT5";
                    }
                    else if (moddedFormat == "BC1_UNorm")
                    {
                        moddedFormat = "DXT1";
                    }
                    moddedTexCompression.Text = moddedFormat;
                    moddedTexture.Dispose();
                }
                else
                {
                    //PNG format
                    moddedFormat = "None";
                    moddedTexCompression.Text = moddedFormat;
                    newDDS = Surface.LoadFromFile(openModdedTexDialog.FileName, true);
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
                textureFormat = originalDDS.Format.ToString();
                if (textureFormat == "BC3_UNorm")
                {
                    textureFormat = "DXT5";
                    exportSettingBox.SelectedIndex = 2;
                }
                else if (textureFormat == "BC1_UNorm")
                {
                    textureFormat = "DXT1";
                    exportSettingBox.SelectedIndex = 0;
                }
                originalTexOpen = true;
                originalTexCompression.Text = textureFormat;
            }
        }

        //Set MipMapFilter to Triangle
        public MipmapFilter MipmapFilter { get { return MipmapFilter.Triangle; } }

        // Count mipmaps
        public int MipmapCount { get { return originalDDS.MipChains[0].Count; } }
        
        //Set Compression Format based on what's selected in export settings
        public CompressionFormat Format
        {
            get
            {
                if (exportSettingBox.SelectedIndex == 0)
                    texFormat = CompressionFormat.DXT1;
                else if (exportSettingBox.SelectedIndex == 1)
                    texFormat = CompressionFormat.DXT1a;
                else if (exportSettingBox.SelectedIndex == 2)
                    texFormat = CompressionFormat.DXT5;
                return texFormat;
            }
        }

        //Convert the png/export as dds
        public void Convert()
        {
            Compressor compress;
            compress = new Compressor();
            setData = compress.Input.SetData(newDDS);
            compress.Compression.Format = Format;
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

        public new void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}

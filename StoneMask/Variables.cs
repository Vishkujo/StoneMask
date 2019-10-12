using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace StoneMask
{
    public class Variables
    {
        public static string xfbinPath;
        public static string moddedTexPath;
        public static string moddedFormat;
        public static string dragFilePath;
        public static string imageUrl;
        public static string previewPath;
        public static bool xfbinOpen;
        public static bool moddedTexOpen;
        public static bool isWebImage = false;
        public static bool ddsNoHeader = false;
        public static bool ddsSimilar;
        public static bool noesisStarted = false;
        public static List<byte> fileBytes = new List<byte>();
        public static List<byte> modelBytes = new List<byte>();
        public static List<int> searchResults = new List<int>();
        public static List<NUT> texList = new List<NUT>();
        public static List<string> dlFiles = new List<string>();
        public static int textureCount = 0;
        public static int nameCount = 0;
        public static MemoryStream ddsStream = new MemoryStream();
        public static Process Noesis;
        public static DDSprops moddedDDS = new DDSprops();

        public static string ProgramVersion
        {
            get { return "1.0.2"; }
        }

        public static string NTP3Format(int formatByte)
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

        public static string appData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "StoneMask"
            );
    }

    public class NUT
    {
        public string TexName { get; set; }
        public int NutIndex { get; set; }
        public int TexIndex { get; set; }
        public int FileSize { get; set; }
        public int NTP3Size { get; set; }
        public int HeaderSize { get; set; }
        public int TexSize { get; set; }
        public string Format { get; set; }
        public int MipMaps { get; set; }
        public int ResX { get; set; }
        public int ResY { get; set; }
        public List<byte> TexFile { get; set; }
        public Bitmap Preview { get; set; }
    }

    public class DDSprops
    {
        public string Format { get; set; }
        public int MipMaps { get; set; }
        public int ResX { get; set; }
        public int ResY { get; set; }
    }
}
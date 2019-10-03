using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoneMask
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StoneMask());
        }
        // Main search method for a string in a list of bytes
        public static List<int> SearchForByte(string search, List<byte> file, int start, int end, int count)
        {
            bool reverse = false;
            if (start > end)
            {
                reverse = true; // Search in the opposite direction
            }
            List<byte> searchList = new List<byte>();
            if (search.Contains("null")) // Search for 0x00 bytes
            {
                int zeroes = (int)Char.GetNumericValue(search[4]);
                for (int z = 0; z < zeroes; z++)
                {
                    searchList.Add(0x00);
                }
            }
            else searchList = Encoding.ASCII.GetBytes(search).ToList();
            List<int> indices = new List<int>();
            int[] searchIndex = new int[searchList.Count()];
            int x = start;
            int n = 0;
            while (reverse && x < start + 1 || x < end)
            {
                if (file[x] == searchList[n])
                {
                    if (n == 0 || searchIndex[n - 1] == x - 1)
                    {
                        searchIndex[n] = x;
                        n++;
                        if (n == searchList.Count())
                        {
                            indices.Add(searchIndex[0]);
                            if (indices.Count == count && !reverse) x = end;
                            else if (reverse) x = start + 2;
                            n = 0;
                        }
                    }
                    else
                    {
                        n = 0;
                        Array.Clear(searchIndex, 0, searchIndex.Length);
                    }
                }
                else n = 0;
                if (reverse) x--;
                else x++;
            }
            return indices;
        }
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
}

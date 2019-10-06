using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static StoneMask.Variables;

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

        public static string GetPath(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            return fileInfo.DirectoryName;
        }

        public static void ReplaceModelTexture(int index, int texIndex, int texSize, byte[] newTexture)
        {
            int a = index;
            int b = texIndex;
            int z = texSize;

            // Move the rest of the file into a new array temporarily
            byte[] temp = new byte[modelBytes.Count - (a)];
            modelBytes.CopyTo(a, temp, 0, modelBytes.Count - (a));
            modelBytes.RemoveRange(a, modelBytes.Count - a);

            // Add the new texture and the rest of the file
            for (int i = 0; i < newTexture.Length; i++) modelBytes.Add(newTexture[i]);
            for (int i = 0; i < temp.Length; i++) modelBytes.Add(temp[i]);
        }
    }
}

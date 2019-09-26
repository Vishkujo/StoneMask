using System;
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
    }
    public class NUT
    {
        public string TexName { get; set; }
        public int FileSize { get; set; }
        public int NTP3Size { get; set; }
        public int TexSize { get; set; }
        public string Format { get; set; }
        public int MipMaps { get; set; }
        public int ResX { get; set; }
        public int ResY { get; set; }
        public List<byte> TexFile { get; set; }
        public Bitmap Preview { get; set; }
    }
}

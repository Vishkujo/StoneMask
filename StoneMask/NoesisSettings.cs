using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoneMask.Properties;
using static StoneMask.Program;
using static StoneMask.Variables;

namespace StoneMask
{
    public partial class NoesisSettings : Form
    {
        public NoesisSettings()
        {
            InitializeComponent();
        }

        private string directory;

        private void NoesisSettings_Load(object sender, EventArgs e)
        {
            // Centers the popup
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
            directoryBox.Text = Settings.Default.NoesisDirectory;
        }

        private void DirectoryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && File.Exists(directoryBox.Text))
            {
                directory = GetPath(directoryBox.Text);
            }
        }

        private void DirectoryBrowse_Click(object sender, EventArgs e)
        {
            openNoesisPathDialog.Multiselect = false;
            if (openNoesisPathDialog.ShowDialog() == DialogResult.OK)
            {
                directory = GetPath(openNoesisPathDialog.FileName);
                directoryBox.Text = openNoesisPathDialog.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.NoesisDirectory = directory;
            Settings.Default.Save();
            Close();
        }
    }
}

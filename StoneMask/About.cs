using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StoneMask
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            versionNoLabel.Text = StoneMask.ProgramVersion;
            // Centers the popup
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        private void DiscordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/bRdNAPB");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SutandoYTIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCcsNN-aZs2CJitWp1pt1wOw");
        }

        private void VishYTIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/VEpicAGE");
        }

        private void VishTwitterIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/VEpicAGE");
        }

        private void SutandoYTIcon_MouseHover(object sender, EventArgs e)
        {
            ToolTip sutandoTT = new ToolTip();
            sutandoTT.SetToolTip(this.sutandoYTIcon, "SutandoTsukai181's YouTube Channel");
        }

        private void VishYTIcon_MouseHover(object sender, EventArgs e)
        {
            ToolTip vishYTTT = new ToolTip();
            vishYTTT.SetToolTip(this.vishYTIcon, "Vish's YouTube Channel");
        }

        private void VishTwitterIcon_MouseHover(object sender, EventArgs e)
        {
            ToolTip vishTTT = new ToolTip();
            vishTTT.SetToolTip(this.vishTwitterIcon, "Vish's Twitter");
        }
    }
}

namespace StoneMask
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionNoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discordLabel = new System.Windows.Forms.LinkLabel();
            this.sutandoYTIcon = new System.Windows.Forms.PictureBox();
            this.vishTwitterIcon = new System.Windows.Forms.PictureBox();
            this.vishYTIcon = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sutandoYTIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishTwitterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishYTIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(317, 190);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(84, 25);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version ";
            // 
            // versionNoLabel
            // 
            this.versionNoLabel.AutoSize = true;
            this.versionNoLabel.Location = new System.Drawing.Point(396, 190);
            this.versionNoLabel.Name = "versionNoLabel";
            this.versionNoLabel.Size = new System.Drawing.Size(23, 25);
            this.versionNoLabel.TabIndex = 2;
            this.versionNoLabel.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "SutandoTsukai181";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vish";
            // 
            // discordLabel
            // 
            this.discordLabel.AutoSize = true;
            this.discordLabel.Font = new System.Drawing.Font("Calibri", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordLabel.LinkColor = System.Drawing.Color.Black;
            this.discordLabel.Location = new System.Drawing.Point(99, 421);
            this.discordLabel.Name = "discordLabel";
            this.discordLabel.Size = new System.Drawing.Size(571, 33);
            this.discordLabel.TabIndex = 9;
            this.discordLabel.TabStop = true;
            this.discordLabel.Text = "Join our JoJo Modding Discord server for more help";
            this.discordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLabel_LinkClicked);
            // 
            // sutandoYTIcon
            // 
            this.sutandoYTIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sutandoYTIcon.Image = global::StoneMask.Properties.Resources.YT_Circle_Icon;
            this.sutandoYTIcon.Location = new System.Drawing.Point(169, 348);
            this.sutandoYTIcon.Name = "sutandoYTIcon";
            this.sutandoYTIcon.Size = new System.Drawing.Size(50, 50);
            this.sutandoYTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sutandoYTIcon.TabIndex = 8;
            this.sutandoYTIcon.TabStop = false;
            this.sutandoYTIcon.Click += new System.EventHandler(this.SutandoYTIcon_Click);
            this.sutandoYTIcon.MouseHover += new System.EventHandler(this.SutandoYTIcon_MouseHover);
            // 
            // vishTwitterIcon
            // 
            this.vishTwitterIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vishTwitterIcon.Image = global::StoneMask.Properties.Resources.Twitter_circle_icon;
            this.vishTwitterIcon.Location = new System.Drawing.Point(539, 348);
            this.vishTwitterIcon.Name = "vishTwitterIcon";
            this.vishTwitterIcon.Size = new System.Drawing.Size(50, 50);
            this.vishTwitterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vishTwitterIcon.TabIndex = 7;
            this.vishTwitterIcon.TabStop = false;
            this.vishTwitterIcon.Click += new System.EventHandler(this.VishTwitterIcon_Click);
            this.vishTwitterIcon.MouseHover += new System.EventHandler(this.VishTwitterIcon_MouseHover);
            // 
            // vishYTIcon
            // 
            this.vishYTIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vishYTIcon.Image = global::StoneMask.Properties.Resources.YT_Circle_Icon;
            this.vishYTIcon.Location = new System.Drawing.Point(468, 348);
            this.vishYTIcon.Name = "vishYTIcon";
            this.vishYTIcon.Size = new System.Drawing.Size(50, 50);
            this.vishYTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vishYTIcon.TabIndex = 6;
            this.vishYTIcon.TabStop = false;
            this.vishYTIcon.Click += new System.EventHandler(this.VishYTIcon_Click);
            this.vishYTIcon.MouseHover += new System.EventHandler(this.VishYTIcon_MouseHover);
            // 
            // logo
            // 
            this.logo.Image = global::StoneMask.Properties.Resources.Stone_Mask_Texture_Editor_Logo;
            this.logo.Location = new System.Drawing.Point(156, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(462, 175);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(590, 471);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(131, 47);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.discordLabel);
            this.Controls.Add(this.sutandoYTIcon);
            this.Controls.Add(this.vishTwitterIcon);
            this.Controls.Add(this.vishYTIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionNoLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sutandoYTIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishTwitterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishYTIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionNoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox vishYTIcon;
        private System.Windows.Forms.PictureBox vishTwitterIcon;
        private System.Windows.Forms.PictureBox sutandoYTIcon;
        private System.Windows.Forms.LinkLabel discordLabel;
        private System.Windows.Forms.Button okButton;
    }
}
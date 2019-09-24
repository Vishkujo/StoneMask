namespace StoneMask
{
    partial class StoneMask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoneMask));
            this.openOriginalTexDialog = new System.Windows.Forms.OpenFileDialog();
            this.moddedTexPathBox = new System.Windows.Forms.TextBox();
            this.moddedtexLabel = new System.Windows.Forms.Label();
            this.xfbinPathBox = new System.Windows.Forms.TextBox();
            this.xfbinLabel = new System.Windows.Forms.Label();
            this.exportModdedDDSButton = new System.Windows.Forms.Button();
            this.compressionLabel1 = new System.Windows.Forms.Label();
            this.openModdedTexDialog = new System.Windows.Forms.OpenFileDialog();
            this.openXfbinDialog = new System.Windows.Forms.OpenFileDialog();
            this.moddedtexBrowse = new System.Windows.Forms.Button();
            this.xfbinBrowse = new System.Windows.Forms.Button();
            this.originalTexCompression = new System.Windows.Forms.Label();
            this.exportXFBINButton = new System.Windows.Forms.Button();
            this.compressionLabel2 = new System.Windows.Forms.Label();
            this.moddedTexCompression = new System.Windows.Forms.Label();
            this.exportsettingLabel = new System.Windows.Forms.Label();
            this.selectTexBox = new System.Windows.Forms.ListBox();
            this.selectTexLabel = new System.Windows.Forms.Label();
            this.previewLabel1 = new System.Windows.Forms.Label();
            this.texturePreview1 = new System.Windows.Forms.PictureBox();
            this.exportOriginalDDS = new System.Windows.Forms.Button();
            this.exportNUT = new System.Windows.Forms.Button();
            this.exportSettingBox = new System.Windows.Forms.ComboBox();
            this.mipMapSetting = new System.Windows.Forms.TrackBar();
            this.compressSettingLabel = new System.Windows.Forms.Label();
            this.mipSettingLabel = new System.Windows.Forms.Label();
            this.mipLabelMax = new System.Windows.Forms.Label();
            this.mipLabelMin = new System.Windows.Forms.Label();
            this.texturePreview2 = new System.Windows.Forms.PictureBox();
            this.previewLabel2 = new System.Windows.Forms.Label();
            this.mipMapCountLabel1 = new System.Windows.Forms.Label();
            this.mipMapLabel1 = new System.Windows.Forms.Label();
            this.resolutionLabel1 = new System.Windows.Forms.Label();
            this.resolutionCheck1 = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            this.mipMapCountLabel2 = new System.Windows.Forms.Label();
            this.mipMapLabel2 = new System.Windows.Forms.Label();
            this.resolutionCheck2 = new System.Windows.Forms.Label();
            this.resolutionLabel2 = new System.Windows.Forms.Label();
            this.originaltexBrowse = new System.Windows.Forms.Button();
            this.originaltexLabel = new System.Windows.Forms.Label();
            this.originaltexPathBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview2)).BeginInit();
            this.SuspendLayout();
            // 
            // openOriginalTexDialog
            // 
            this.openOriginalTexDialog.DefaultExt = "dds";
            this.openOriginalTexDialog.Filter = "DDS files|*.dds";
            this.openOriginalTexDialog.Title = "Open original texture\'s image file (.dds or .png)";
            // 
            // moddedTexPathBox
            // 
            this.moddedTexPathBox.AllowDrop = true;
            this.moddedTexPathBox.Location = new System.Drawing.Point(37, 388);
            this.moddedTexPathBox.Name = "moddedTexPathBox";
            this.moddedTexPathBox.Size = new System.Drawing.Size(772, 29);
            this.moddedTexPathBox.TabIndex = 5;
            // 
            // moddedtexLabel
            // 
            this.moddedtexLabel.AutoSize = true;
            this.moddedtexLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.moddedtexLabel.Location = new System.Drawing.Point(32, 360);
            this.moddedtexLabel.Name = "moddedtexLabel";
            this.moddedtexLabel.Size = new System.Drawing.Size(423, 25);
            this.moddedtexLabel.TabIndex = 4;
            this.moddedtexLabel.Text = "Open modded texture\'s image file (.dds or .png)";
            // 
            // xfbinPathBox
            // 
            this.xfbinPathBox.AllowDrop = true;
            this.xfbinPathBox.Location = new System.Drawing.Point(37, 50);
            this.xfbinPathBox.Name = "xfbinPathBox";
            this.xfbinPathBox.Size = new System.Drawing.Size(772, 29);
            this.xfbinPathBox.TabIndex = 8;
            // 
            // xfbinLabel
            // 
            this.xfbinLabel.AutoSize = true;
            this.xfbinLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.xfbinLabel.Location = new System.Drawing.Point(37, 17);
            this.xfbinLabel.Name = "xfbinLabel";
            this.xfbinLabel.Size = new System.Drawing.Size(251, 25);
            this.xfbinLabel.TabIndex = 7;
            this.xfbinLabel.Text = "Open the texture file (.xfbin)";
            // 
            // exportModdedDDSButton
            // 
            this.exportModdedDDSButton.Location = new System.Drawing.Point(253, 706);
            this.exportModdedDDSButton.Name = "exportModdedDDSButton";
            this.exportModdedDDSButton.Size = new System.Drawing.Size(250, 62);
            this.exportModdedDDSButton.TabIndex = 9;
            this.exportModdedDDSButton.Text = "Export modded .dds";
            this.exportModdedDDSButton.UseVisualStyleBackColor = true;
            this.exportModdedDDSButton.Click += new System.EventHandler(this.DDSSave_Click);
            // 
            // compressionLabel1
            // 
            this.compressionLabel1.AutoSize = true;
            this.compressionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel1.Location = new System.Drawing.Point(847, 109);
            this.compressionLabel1.Name = "compressionLabel1";
            this.compressionLabel1.Size = new System.Drawing.Size(201, 25);
            this.compressionLabel1.TabIndex = 12;
            this.compressionLabel1.Text = "Texture compression:";
            // 
            // openModdedTexDialog
            // 
            this.openModdedTexDialog.Filter = "DDS or PNG|*.dds;*.png;";
            this.openModdedTexDialog.Title = "Open modded texture\'s image file (.dds or .png)";
            // 
            // openXfbinDialog
            // 
            this.openXfbinDialog.DefaultExt = "xfbin";
            this.openXfbinDialog.Filter = "XFBIN files|*.xfbin";
            this.openXfbinDialog.Title = "Open the texture file (.xfbin)";
            // 
            // moddedtexBrowse
            // 
            this.moddedtexBrowse.Location = new System.Drawing.Point(849, 378);
            this.moddedtexBrowse.Name = "moddedtexBrowse";
            this.moddedtexBrowse.Size = new System.Drawing.Size(199, 50);
            this.moddedtexBrowse.TabIndex = 13;
            this.moddedtexBrowse.Text = "Browse";
            this.moddedtexBrowse.UseVisualStyleBackColor = true;
            this.moddedtexBrowse.Click += new System.EventHandler(this.ModdedTexBrowse_Click);
            // 
            // xfbinBrowse
            // 
            this.xfbinBrowse.Location = new System.Drawing.Point(849, 40);
            this.xfbinBrowse.Name = "xfbinBrowse";
            this.xfbinBrowse.Size = new System.Drawing.Size(199, 50);
            this.xfbinBrowse.TabIndex = 14;
            this.xfbinBrowse.Text = "Browse";
            this.xfbinBrowse.UseVisualStyleBackColor = true;
            this.xfbinBrowse.Click += new System.EventHandler(this.XfbinBrowse_Click);
            // 
            // originalTexCompression
            // 
            this.originalTexCompression.AutoSize = true;
            this.originalTexCompression.Location = new System.Drawing.Point(847, 137);
            this.originalTexCompression.Name = "originalTexCompression";
            this.originalTexCompression.Size = new System.Drawing.Size(59, 25);
            this.originalTexCompression.TabIndex = 15;
            this.originalTexCompression.Text = "None";
            // 
            // exportXFBINButton
            // 
            this.exportXFBINButton.Location = new System.Drawing.Point(592, 706);
            this.exportXFBINButton.Name = "exportXFBINButton";
            this.exportXFBINButton.Size = new System.Drawing.Size(225, 62);
            this.exportXFBINButton.TabIndex = 16;
            this.exportXFBINButton.Text = "Export modded .xfbin";
            this.exportXFBINButton.UseVisualStyleBackColor = true;
            this.exportXFBINButton.Click += new System.EventHandler(this.XfbinSave_Click);
            // 
            // compressionLabel2
            // 
            this.compressionLabel2.AutoSize = true;
            this.compressionLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel2.Location = new System.Drawing.Point(844, 442);
            this.compressionLabel2.Name = "compressionLabel2";
            this.compressionLabel2.Size = new System.Drawing.Size(201, 25);
            this.compressionLabel2.TabIndex = 17;
            this.compressionLabel2.Text = "Texture compression:";
            // 
            // moddedTexCompression
            // 
            this.moddedTexCompression.AutoSize = true;
            this.moddedTexCompression.Location = new System.Drawing.Point(847, 473);
            this.moddedTexCompression.Name = "moddedTexCompression";
            this.moddedTexCompression.Size = new System.Drawing.Size(59, 25);
            this.moddedTexCompression.TabIndex = 18;
            this.moddedTexCompression.Text = "None";
            // 
            // exportsettingLabel
            // 
            this.exportsettingLabel.AutoSize = true;
            this.exportsettingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exportsettingLabel.Location = new System.Drawing.Point(38, 442);
            this.exportsettingLabel.Name = "exportsettingLabel";
            this.exportsettingLabel.Size = new System.Drawing.Size(146, 25);
            this.exportsettingLabel.TabIndex = 21;
            this.exportsettingLabel.Text = "Export settings:";
            // 
            // selectTexBox
            // 
            this.selectTexBox.FormattingEnabled = true;
            this.selectTexBox.ItemHeight = 24;
            this.selectTexBox.Location = new System.Drawing.Point(37, 121);
            this.selectTexBox.Name = "selectTexBox";
            this.selectTexBox.Size = new System.Drawing.Size(346, 196);
            this.selectTexBox.TabIndex = 22;
            // 
            // selectTexLabel
            // 
            this.selectTexLabel.AutoSize = true;
            this.selectTexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectTexLabel.Location = new System.Drawing.Point(35, 93);
            this.selectTexLabel.Name = "selectTexLabel";
            this.selectTexLabel.Size = new System.Drawing.Size(131, 25);
            this.selectTexLabel.TabIndex = 23;
            this.selectTexLabel.Text = "Select texture";
            // 
            // previewLabel1
            // 
            this.previewLabel1.AutoSize = true;
            this.previewLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.previewLabel1.Location = new System.Drawing.Point(484, 93);
            this.previewLabel1.Name = "previewLabel1";
            this.previewLabel1.Size = new System.Drawing.Size(87, 25);
            this.previewLabel1.TabIndex = 24;
            this.previewLabel1.Text = "Preview:";
            // 
            // texturePreview1
            // 
            this.texturePreview1.Location = new System.Drawing.Point(475, 473);
            this.texturePreview1.Name = "texturePreview1";
            this.texturePreview1.Size = new System.Drawing.Size(303, 134);
            this.texturePreview1.TabIndex = 25;
            this.texturePreview1.TabStop = false;
            // 
            // exportOriginalDDS
            // 
            this.exportOriginalDDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.514286F);
            this.exportOriginalDDS.Location = new System.Drawing.Point(852, 247);
            this.exportOriginalDDS.Name = "exportOriginalDDS";
            this.exportOriginalDDS.Size = new System.Drawing.Size(190, 49);
            this.exportOriginalDDS.TabIndex = 26;
            this.exportOriginalDDS.Text = "Export original .dds";
            this.exportOriginalDDS.UseVisualStyleBackColor = true;
            // 
            // exportNUT
            // 
            this.exportNUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.542858F);
            this.exportNUT.Location = new System.Drawing.Point(852, 302);
            this.exportNUT.Name = "exportNUT";
            this.exportNUT.Size = new System.Drawing.Size(190, 37);
            this.exportNUT.TabIndex = 27;
            this.exportNUT.Text = "Export .nut";
            this.exportNUT.UseVisualStyleBackColor = true;
            // 
            // exportSettingBox
            // 
            this.exportSettingBox.FormattingEnabled = true;
            this.exportSettingBox.Items.AddRange(new object[] {
            "DXT1",
            "DXT1a (Transparency)",
            "DXT5"});
            this.exportSettingBox.Location = new System.Drawing.Point(177, 473);
            this.exportSettingBox.Name = "exportSettingBox";
            this.exportSettingBox.Size = new System.Drawing.Size(253, 32);
            this.exportSettingBox.TabIndex = 28;
            this.exportSettingBox.Text = "DXT1";
            // 
            // mipMapSetting
            // 
            this.mipMapSetting.Location = new System.Drawing.Point(177, 515);
            this.mipMapSetting.Maximum = 11;
            this.mipMapSetting.Name = "mipMapSetting";
            this.mipMapSetting.Size = new System.Drawing.Size(253, 80);
            this.mipMapSetting.TabIndex = 29;
            // 
            // compressSettingLabel
            // 
            this.compressSettingLabel.AutoSize = true;
            this.compressSettingLabel.Location = new System.Drawing.Point(37, 473);
            this.compressSettingLabel.Name = "compressSettingLabel";
            this.compressSettingLabel.Size = new System.Drawing.Size(134, 25);
            this.compressSettingLabel.TabIndex = 30;
            this.compressSettingLabel.Text = "Compression:";
            // 
            // mipSettingLabel
            // 
            this.mipSettingLabel.AutoSize = true;
            this.mipSettingLabel.Location = new System.Drawing.Point(37, 515);
            this.mipSettingLabel.Name = "mipSettingLabel";
            this.mipSettingLabel.Size = new System.Drawing.Size(104, 25);
            this.mipSettingLabel.TabIndex = 31;
            this.mipSettingLabel.Text = "Mip Maps:";
            // 
            // mipLabelMax
            // 
            this.mipLabelMax.AutoSize = true;
            this.mipLabelMax.Location = new System.Drawing.Point(397, 559);
            this.mipLabelMax.Name = "mipLabelMax";
            this.mipLabelMax.Size = new System.Drawing.Size(34, 25);
            this.mipLabelMax.TabIndex = 32;
            this.mipLabelMax.Text = "12";
            // 
            // mipLabelMin
            // 
            this.mipLabelMin.AutoSize = true;
            this.mipLabelMin.Location = new System.Drawing.Point(183, 559);
            this.mipLabelMin.Name = "mipLabelMin";
            this.mipLabelMin.Size = new System.Drawing.Size(23, 25);
            this.mipLabelMin.TabIndex = 33;
            this.mipLabelMin.Text = "1";
            // 
            // texturePreview2
            // 
            this.texturePreview2.Location = new System.Drawing.Point(453, 121);
            this.texturePreview2.Name = "texturePreview2";
            this.texturePreview2.Size = new System.Drawing.Size(303, 134);
            this.texturePreview2.TabIndex = 35;
            this.texturePreview2.TabStop = false;
            // 
            // previewLabel2
            // 
            this.previewLabel2.AutoSize = true;
            this.previewLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.previewLabel2.Location = new System.Drawing.Point(496, 442);
            this.previewLabel2.Name = "previewLabel2";
            this.previewLabel2.Size = new System.Drawing.Size(87, 25);
            this.previewLabel2.TabIndex = 34;
            this.previewLabel2.Text = "Preview:";
            // 
            // mipMapCountLabel1
            // 
            this.mipMapCountLabel1.AutoSize = true;
            this.mipMapCountLabel1.Location = new System.Drawing.Point(828, 204);
            this.mipMapCountLabel1.Name = "mipMapCountLabel1";
            this.mipMapCountLabel1.Size = new System.Drawing.Size(59, 25);
            this.mipMapCountLabel1.TabIndex = 37;
            this.mipMapCountLabel1.Text = "None";
            // 
            // mipMapLabel1
            // 
            this.mipMapLabel1.AutoSize = true;
            this.mipMapLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mipMapLabel1.Location = new System.Drawing.Point(828, 176);
            this.mipMapLabel1.Name = "mipMapLabel1";
            this.mipMapLabel1.Size = new System.Drawing.Size(104, 25);
            this.mipMapLabel1.TabIndex = 36;
            this.mipMapLabel1.Text = "Mip Maps:";
            // 
            // resolutionLabel1
            // 
            this.resolutionLabel1.AutoSize = true;
            this.resolutionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resolutionLabel1.Location = new System.Drawing.Point(964, 176);
            this.resolutionLabel1.Name = "resolutionLabel1";
            this.resolutionLabel1.Size = new System.Drawing.Size(109, 25);
            this.resolutionLabel1.TabIndex = 38;
            this.resolutionLabel1.Text = "Resolution:";
            // 
            // resolutionCheck1
            // 
            this.resolutionCheck1.AutoSize = true;
            this.resolutionCheck1.Location = new System.Drawing.Point(964, 204);
            this.resolutionCheck1.Name = "resolutionCheck1";
            this.resolutionCheck1.Size = new System.Drawing.Size(59, 25);
            this.resolutionCheck1.TabIndex = 39;
            this.resolutionCheck1.Text = "None";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(453, 271);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(290, 48);
            this.replaceButton.TabIndex = 40;
            this.replaceButton.Text = "Replace selected texture";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // mipMapCountLabel2
            // 
            this.mipMapCountLabel2.AutoSize = true;
            this.mipMapCountLabel2.Location = new System.Drawing.Point(825, 543);
            this.mipMapCountLabel2.Name = "mipMapCountLabel2";
            this.mipMapCountLabel2.Size = new System.Drawing.Size(59, 25);
            this.mipMapCountLabel2.TabIndex = 42;
            this.mipMapCountLabel2.Text = "None";
            // 
            // mipMapLabel2
            // 
            this.mipMapLabel2.AutoSize = true;
            this.mipMapLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mipMapLabel2.Location = new System.Drawing.Point(825, 515);
            this.mipMapLabel2.Name = "mipMapLabel2";
            this.mipMapLabel2.Size = new System.Drawing.Size(104, 25);
            this.mipMapLabel2.TabIndex = 41;
            this.mipMapLabel2.Text = "Mip Maps:";
            // 
            // resolutionCheck2
            // 
            this.resolutionCheck2.AutoSize = true;
            this.resolutionCheck2.Location = new System.Drawing.Point(964, 543);
            this.resolutionCheck2.Name = "resolutionCheck2";
            this.resolutionCheck2.Size = new System.Drawing.Size(59, 25);
            this.resolutionCheck2.TabIndex = 44;
            this.resolutionCheck2.Text = "None";
            // 
            // resolutionLabel2
            // 
            this.resolutionLabel2.AutoSize = true;
            this.resolutionLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resolutionLabel2.Location = new System.Drawing.Point(964, 515);
            this.resolutionLabel2.Name = "resolutionLabel2";
            this.resolutionLabel2.Size = new System.Drawing.Size(109, 25);
            this.resolutionLabel2.TabIndex = 43;
            this.resolutionLabel2.Text = "Resolution:";
            // 
            // originaltexBrowse
            // 
            this.originaltexBrowse.Location = new System.Drawing.Point(850, 636);
            this.originaltexBrowse.Name = "originaltexBrowse";
            this.originaltexBrowse.Size = new System.Drawing.Size(199, 50);
            this.originaltexBrowse.TabIndex = 0;
            this.originaltexBrowse.Text = "Browse";
            this.originaltexBrowse.UseVisualStyleBackColor = true;
            this.originaltexBrowse.Click += new System.EventHandler(this.OriginalTexBrowse_Click);
            // 
            // originaltexLabel
            // 
            this.originaltexLabel.AutoSize = true;
            this.originaltexLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.originaltexLabel.Location = new System.Drawing.Point(38, 612);
            this.originaltexLabel.Name = "originaltexLabel";
            this.originaltexLabel.Size = new System.Drawing.Size(349, 25);
            this.originaltexLabel.TabIndex = 1;
            this.originaltexLabel.Text = "Open original texture\'s image file (.dds)";
            // 
            // originaltexPathBox
            // 
            this.originaltexPathBox.AllowDrop = true;
            this.originaltexPathBox.Location = new System.Drawing.Point(38, 646);
            this.originaltexPathBox.Name = "originaltexPathBox";
            this.originaltexPathBox.Size = new System.Drawing.Size(771, 29);
            this.originaltexPathBox.TabIndex = 2;
            // 
            // StoneMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1109, 791);
            this.Controls.Add(this.resolutionCheck2);
            this.Controls.Add(this.resolutionLabel2);
            this.Controls.Add(this.mipMapCountLabel2);
            this.Controls.Add(this.mipMapLabel2);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.resolutionCheck1);
            this.Controls.Add(this.resolutionLabel1);
            this.Controls.Add(this.mipMapCountLabel1);
            this.Controls.Add(this.mipMapLabel1);
            this.Controls.Add(this.texturePreview2);
            this.Controls.Add(this.previewLabel2);
            this.Controls.Add(this.mipLabelMin);
            this.Controls.Add(this.mipLabelMax);
            this.Controls.Add(this.mipSettingLabel);
            this.Controls.Add(this.compressSettingLabel);
            this.Controls.Add(this.mipMapSetting);
            this.Controls.Add(this.exportSettingBox);
            this.Controls.Add(this.exportNUT);
            this.Controls.Add(this.exportOriginalDDS);
            this.Controls.Add(this.texturePreview1);
            this.Controls.Add(this.previewLabel1);
            this.Controls.Add(this.selectTexLabel);
            this.Controls.Add(this.selectTexBox);
            this.Controls.Add(this.exportsettingLabel);
            this.Controls.Add(this.moddedTexCompression);
            this.Controls.Add(this.compressionLabel2);
            this.Controls.Add(this.exportXFBINButton);
            this.Controls.Add(this.originalTexCompression);
            this.Controls.Add(this.xfbinBrowse);
            this.Controls.Add(this.moddedtexBrowse);
            this.Controls.Add(this.compressionLabel1);
            this.Controls.Add(this.exportModdedDDSButton);
            this.Controls.Add(this.xfbinPathBox);
            this.Controls.Add(this.xfbinLabel);
            this.Controls.Add(this.moddedTexPathBox);
            this.Controls.Add(this.moddedtexLabel);
            this.Controls.Add(this.originaltexPathBox);
            this.Controls.Add(this.originaltexLabel);
            this.Controls.Add(this.originaltexBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StoneMask";
            this.Text = "Stone Mask v1.0 - JoJo ASB/EoH Texture Editor";
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button moddedtexBrowse;
        private System.Windows.Forms.Button xfbinBrowse;
        private System.Windows.Forms.OpenFileDialog openOriginalTexDialog;
        private System.Windows.Forms.OpenFileDialog openModdedTexDialog;
        private System.Windows.Forms.OpenFileDialog openXfbinDialog;
        private System.Windows.Forms.Label moddedtexLabel;
        private System.Windows.Forms.TextBox xfbinPathBox;
        private System.Windows.Forms.Label xfbinLabel;
        private System.Windows.Forms.Button exportModdedDDSButton;
        private System.Windows.Forms.Label compressionLabel1;
        private System.Windows.Forms.Label originalTexCompression;
        private System.Windows.Forms.Button exportXFBINButton;
        private System.Windows.Forms.Label compressionLabel2;
        private System.Windows.Forms.Label moddedTexCompression;
        private System.Windows.Forms.Label exportsettingLabel;
        private System.Windows.Forms.ListBox selectTexBox;
        private System.Windows.Forms.Label selectTexLabel;
        private System.Windows.Forms.Label previewLabel1;
        private System.Windows.Forms.PictureBox texturePreview1;
        private System.Windows.Forms.TextBox moddedTexPathBox;
        private System.Windows.Forms.Button exportOriginalDDS;
        private System.Windows.Forms.Button exportNUT;
        private System.Windows.Forms.ComboBox exportSettingBox;
        private System.Windows.Forms.TrackBar mipMapSetting;
        private System.Windows.Forms.Label compressSettingLabel;
        private System.Windows.Forms.Label mipSettingLabel;
        private System.Windows.Forms.Label mipLabelMax;
        private System.Windows.Forms.Label mipLabelMin;
        private System.Windows.Forms.PictureBox texturePreview2;
        private System.Windows.Forms.Label previewLabel2;
        private System.Windows.Forms.Label mipMapCountLabel1;
        private System.Windows.Forms.Label mipMapLabel1;
        private System.Windows.Forms.Label resolutionLabel1;
        private System.Windows.Forms.Label resolutionCheck1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label mipMapCountLabel2;
        private System.Windows.Forms.Label mipMapLabel2;
        private System.Windows.Forms.Label resolutionCheck2;
        private System.Windows.Forms.Label resolutionLabel2;
        private System.Windows.Forms.Button originaltexBrowse;
        private System.Windows.Forms.Label originaltexLabel;
        private System.Windows.Forms.TextBox originaltexPathBox;
    }
}


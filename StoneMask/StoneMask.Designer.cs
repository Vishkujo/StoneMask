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
            this.texturePreview2 = new System.Windows.Forms.PictureBox();
            this.exportOriginalDDS = new System.Windows.Forms.Button();
            this.exportNUT = new System.Windows.Forms.Button();
            this.exportSettingBox = new System.Windows.Forms.ComboBox();
            this.mipMapSetting = new System.Windows.Forms.TrackBar();
            this.compressSettingLabel = new System.Windows.Forms.Label();
            this.mipSettingLabel = new System.Windows.Forms.Label();
            this.mipLabelMax = new System.Windows.Forms.Label();
            this.mipLabelMin = new System.Windows.Forms.Label();
            this.texturePreview1 = new System.Windows.Forms.PictureBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.moddedTexPathBox.Location = new System.Drawing.Point(23, 281);
            this.moddedTexPathBox.Margin = new System.Windows.Forms.Padding(2);
            this.moddedTexPathBox.Name = "moddedTexPathBox";
            this.moddedTexPathBox.Size = new System.Drawing.Size(563, 22);
            this.moddedTexPathBox.TabIndex = 5;
            // 
            // moddedtexLabel
            // 
            this.moddedtexLabel.AutoSize = true;
            this.moddedtexLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.moddedtexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moddedtexLabel.Location = new System.Drawing.Point(20, 263);
            this.moddedtexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moddedtexLabel.Name = "moddedtexLabel";
            this.moddedtexLabel.Size = new System.Drawing.Size(356, 17);
            this.moddedtexLabel.TabIndex = 4;
            this.moddedtexLabel.Text = "Open modded texture\'s image file (.dds or .png)";
            // 
            // xfbinPathBox
            // 
            this.xfbinPathBox.AllowDrop = true;
            this.xfbinPathBox.Location = new System.Drawing.Point(23, 56);
            this.xfbinPathBox.Margin = new System.Windows.Forms.Padding(2);
            this.xfbinPathBox.Name = "xfbinPathBox";
            this.xfbinPathBox.Size = new System.Drawing.Size(563, 22);
            this.xfbinPathBox.TabIndex = 8;
            // 
            // xfbinLabel
            // 
            this.xfbinLabel.AutoSize = true;
            this.xfbinLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.xfbinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xfbinLabel.Location = new System.Drawing.Point(23, 34);
            this.xfbinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xfbinLabel.Name = "xfbinLabel";
            this.xfbinLabel.Size = new System.Drawing.Size(213, 17);
            this.xfbinLabel.TabIndex = 7;
            this.xfbinLabel.Text = "Open the texture file (.xfbin)";
            // 
            // exportModdedDDSButton
            // 
            this.exportModdedDDSButton.Location = new System.Drawing.Point(180, 493);
            this.exportModdedDDSButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportModdedDDSButton.Name = "exportModdedDDSButton";
            this.exportModdedDDSButton.Size = new System.Drawing.Size(182, 41);
            this.exportModdedDDSButton.TabIndex = 9;
            this.exportModdedDDSButton.Text = "Export modded .dds";
            this.exportModdedDDSButton.UseVisualStyleBackColor = true;
            this.exportModdedDDSButton.Click += new System.EventHandler(this.DDSSave_Click);
            // 
            // compressionLabel1
            // 
            this.compressionLabel1.AutoSize = true;
            this.compressionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel1.Location = new System.Drawing.Point(612, 95);
            this.compressionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compressionLabel1.Name = "compressionLabel1";
            this.compressionLabel1.Size = new System.Drawing.Size(144, 17);
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
            this.moddedtexBrowse.Location = new System.Drawing.Point(614, 275);
            this.moddedtexBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.moddedtexBrowse.Name = "moddedtexBrowse";
            this.moddedtexBrowse.Size = new System.Drawing.Size(145, 33);
            this.moddedtexBrowse.TabIndex = 13;
            this.moddedtexBrowse.Text = "Browse";
            this.moddedtexBrowse.UseVisualStyleBackColor = true;
            this.moddedtexBrowse.Click += new System.EventHandler(this.ModdedTexBrowse_Click);
            // 
            // xfbinBrowse
            // 
            this.xfbinBrowse.Location = new System.Drawing.Point(614, 49);
            this.xfbinBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.xfbinBrowse.Name = "xfbinBrowse";
            this.xfbinBrowse.Size = new System.Drawing.Size(145, 33);
            this.xfbinBrowse.TabIndex = 14;
            this.xfbinBrowse.Text = "Browse";
            this.xfbinBrowse.UseVisualStyleBackColor = true;
            this.xfbinBrowse.Click += new System.EventHandler(this.XfbinBrowse_Click);
            // 
            // originalTexCompression
            // 
            this.originalTexCompression.AutoSize = true;
            this.originalTexCompression.Location = new System.Drawing.Point(612, 114);
            this.originalTexCompression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalTexCompression.Name = "originalTexCompression";
            this.originalTexCompression.Size = new System.Drawing.Size(42, 17);
            this.originalTexCompression.TabIndex = 15;
            this.originalTexCompression.Text = "None";
            // 
            // exportXFBINButton
            // 
            this.exportXFBINButton.Location = new System.Drawing.Point(427, 493);
            this.exportXFBINButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportXFBINButton.Name = "exportXFBINButton";
            this.exportXFBINButton.Size = new System.Drawing.Size(164, 41);
            this.exportXFBINButton.TabIndex = 16;
            this.exportXFBINButton.Text = "Export modded .xfbin";
            this.exportXFBINButton.UseVisualStyleBackColor = true;
            this.exportXFBINButton.Click += new System.EventHandler(this.XfbinSave_Click);
            // 
            // compressionLabel2
            // 
            this.compressionLabel2.AutoSize = true;
            this.compressionLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel2.Location = new System.Drawing.Point(610, 317);
            this.compressionLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compressionLabel2.Name = "compressionLabel2";
            this.compressionLabel2.Size = new System.Drawing.Size(144, 17);
            this.compressionLabel2.TabIndex = 17;
            this.compressionLabel2.Text = "Texture compression:";
            // 
            // moddedTexCompression
            // 
            this.moddedTexCompression.AutoSize = true;
            this.moddedTexCompression.Location = new System.Drawing.Point(612, 338);
            this.moddedTexCompression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moddedTexCompression.Name = "moddedTexCompression";
            this.moddedTexCompression.Size = new System.Drawing.Size(42, 17);
            this.moddedTexCompression.TabIndex = 18;
            this.moddedTexCompression.Text = "None";
            // 
            // exportsettingLabel
            // 
            this.exportsettingLabel.AutoSize = true;
            this.exportsettingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exportsettingLabel.Location = new System.Drawing.Point(24, 317);
            this.exportsettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exportsettingLabel.Name = "exportsettingLabel";
            this.exportsettingLabel.Size = new System.Drawing.Size(105, 17);
            this.exportsettingLabel.TabIndex = 21;
            this.exportsettingLabel.Text = "Export settings:";
            // 
            // selectTexBox
            // 
            this.selectTexBox.FormattingEnabled = true;
            this.selectTexBox.ItemHeight = 16;
            this.selectTexBox.Location = new System.Drawing.Point(23, 103);
            this.selectTexBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectTexBox.Name = "selectTexBox";
            this.selectTexBox.Size = new System.Drawing.Size(253, 132);
            this.selectTexBox.TabIndex = 22;
            this.selectTexBox.SelectedIndexChanged += new System.EventHandler(this.SelectTexBox_SelectedIndexChanged);
            // 
            // selectTexLabel
            // 
            this.selectTexLabel.AutoSize = true;
            this.selectTexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectTexLabel.Location = new System.Drawing.Point(22, 85);
            this.selectTexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTexLabel.Name = "selectTexLabel";
            this.selectTexLabel.Size = new System.Drawing.Size(94, 17);
            this.selectTexLabel.TabIndex = 23;
            this.selectTexLabel.Text = "Select texture";
            // 
            // previewLabel1
            // 
            this.previewLabel1.AutoSize = true;
            this.previewLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.previewLabel1.Location = new System.Drawing.Point(348, 85);
            this.previewLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewLabel1.Name = "previewLabel1";
            this.previewLabel1.Size = new System.Drawing.Size(61, 17);
            this.previewLabel1.TabIndex = 24;
            this.previewLabel1.Text = "Preview:";
            // 
            // texturePreview2
            // 
            this.texturePreview2.Location = new System.Drawing.Point(342, 338);
            this.texturePreview2.Margin = new System.Windows.Forms.Padding(2);
            this.texturePreview2.Name = "texturePreview2";
            this.texturePreview2.Size = new System.Drawing.Size(220, 89);
            this.texturePreview2.TabIndex = 25;
            this.texturePreview2.TabStop = false;
            // 
            // exportOriginalDDS
            // 
            this.exportOriginalDDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.514286F);
            this.exportOriginalDDS.Location = new System.Drawing.Point(616, 187);
            this.exportOriginalDDS.Margin = new System.Windows.Forms.Padding(2);
            this.exportOriginalDDS.Name = "exportOriginalDDS";
            this.exportOriginalDDS.Size = new System.Drawing.Size(138, 33);
            this.exportOriginalDDS.TabIndex = 26;
            this.exportOriginalDDS.Text = "Export original .dds";
            this.exportOriginalDDS.UseVisualStyleBackColor = true;
            // 
            // exportNUT
            // 
            this.exportNUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.542858F);
            this.exportNUT.Location = new System.Drawing.Point(616, 224);
            this.exportNUT.Margin = new System.Windows.Forms.Padding(2);
            this.exportNUT.Name = "exportNUT";
            this.exportNUT.Size = new System.Drawing.Size(138, 25);
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
            this.exportSettingBox.Location = new System.Drawing.Point(125, 338);
            this.exportSettingBox.Margin = new System.Windows.Forms.Padding(2);
            this.exportSettingBox.Name = "exportSettingBox";
            this.exportSettingBox.Size = new System.Drawing.Size(185, 24);
            this.exportSettingBox.TabIndex = 28;
            this.exportSettingBox.Text = "DXT1";
            // 
            // mipMapSetting
            // 
            this.mipMapSetting.Location = new System.Drawing.Point(125, 366);
            this.mipMapSetting.Margin = new System.Windows.Forms.Padding(2);
            this.mipMapSetting.Maximum = 11;
            this.mipMapSetting.Name = "mipMapSetting";
            this.mipMapSetting.Size = new System.Drawing.Size(184, 56);
            this.mipMapSetting.TabIndex = 29;
            // 
            // compressSettingLabel
            // 
            this.compressSettingLabel.AutoSize = true;
            this.compressSettingLabel.Location = new System.Drawing.Point(23, 338);
            this.compressSettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compressSettingLabel.Name = "compressSettingLabel";
            this.compressSettingLabel.Size = new System.Drawing.Size(94, 17);
            this.compressSettingLabel.TabIndex = 30;
            this.compressSettingLabel.Text = "Compression:";
            // 
            // mipSettingLabel
            // 
            this.mipSettingLabel.AutoSize = true;
            this.mipSettingLabel.Location = new System.Drawing.Point(23, 366);
            this.mipSettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipSettingLabel.Name = "mipSettingLabel";
            this.mipSettingLabel.Size = new System.Drawing.Size(72, 17);
            this.mipSettingLabel.TabIndex = 31;
            this.mipSettingLabel.Text = "Mip Maps:";
            // 
            // mipLabelMax
            // 
            this.mipLabelMax.AutoSize = true;
            this.mipLabelMax.Location = new System.Drawing.Point(285, 395);
            this.mipLabelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipLabelMax.Name = "mipLabelMax";
            this.mipLabelMax.Size = new System.Drawing.Size(24, 17);
            this.mipLabelMax.TabIndex = 32;
            this.mipLabelMax.Text = "12";
            // 
            // mipLabelMin
            // 
            this.mipLabelMin.AutoSize = true;
            this.mipLabelMin.Location = new System.Drawing.Point(129, 395);
            this.mipLabelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipLabelMin.Name = "mipLabelMin";
            this.mipLabelMin.Size = new System.Drawing.Size(16, 17);
            this.mipLabelMin.TabIndex = 33;
            this.mipLabelMin.Text = "1";
            // 
            // texturePreview1
            // 
            this.texturePreview1.Location = new System.Drawing.Point(326, 103);
            this.texturePreview1.Margin = new System.Windows.Forms.Padding(2);
            this.texturePreview1.Name = "texturePreview1";
            this.texturePreview1.Size = new System.Drawing.Size(220, 89);
            this.texturePreview1.TabIndex = 35;
            this.texturePreview1.TabStop = false;
            // 
            // previewLabel2
            // 
            this.previewLabel2.AutoSize = true;
            this.previewLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.previewLabel2.Location = new System.Drawing.Point(357, 317);
            this.previewLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewLabel2.Name = "previewLabel2";
            this.previewLabel2.Size = new System.Drawing.Size(61, 17);
            this.previewLabel2.TabIndex = 34;
            this.previewLabel2.Text = "Preview:";
            // 
            // mipMapCountLabel1
            // 
            this.mipMapCountLabel1.AutoSize = true;
            this.mipMapCountLabel1.Location = new System.Drawing.Point(599, 159);
            this.mipMapCountLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipMapCountLabel1.Name = "mipMapCountLabel1";
            this.mipMapCountLabel1.Size = new System.Drawing.Size(42, 17);
            this.mipMapCountLabel1.TabIndex = 37;
            this.mipMapCountLabel1.Text = "None";
            // 
            // mipMapLabel1
            // 
            this.mipMapLabel1.AutoSize = true;
            this.mipMapLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mipMapLabel1.Location = new System.Drawing.Point(599, 140);
            this.mipMapLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipMapLabel1.Name = "mipMapLabel1";
            this.mipMapLabel1.Size = new System.Drawing.Size(72, 17);
            this.mipMapLabel1.TabIndex = 36;
            this.mipMapLabel1.Text = "Mip Maps:";
            // 
            // resolutionLabel1
            // 
            this.resolutionLabel1.AutoSize = true;
            this.resolutionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resolutionLabel1.Location = new System.Drawing.Point(697, 140);
            this.resolutionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionLabel1.Name = "resolutionLabel1";
            this.resolutionLabel1.Size = new System.Drawing.Size(79, 17);
            this.resolutionLabel1.TabIndex = 38;
            this.resolutionLabel1.Text = "Resolution:";
            // 
            // resolutionCheck1
            // 
            this.resolutionCheck1.AutoSize = true;
            this.resolutionCheck1.Location = new System.Drawing.Point(697, 159);
            this.resolutionCheck1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionCheck1.Name = "resolutionCheck1";
            this.resolutionCheck1.Size = new System.Drawing.Size(42, 17);
            this.resolutionCheck1.TabIndex = 39;
            this.resolutionCheck1.Text = "None";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(326, 203);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(2);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(211, 32);
            this.replaceButton.TabIndex = 40;
            this.replaceButton.Text = "Replace selected texture";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // mipMapCountLabel2
            // 
            this.mipMapCountLabel2.AutoSize = true;
            this.mipMapCountLabel2.Location = new System.Drawing.Point(596, 385);
            this.mipMapCountLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipMapCountLabel2.Name = "mipMapCountLabel2";
            this.mipMapCountLabel2.Size = new System.Drawing.Size(42, 17);
            this.mipMapCountLabel2.TabIndex = 42;
            this.mipMapCountLabel2.Text = "None";
            // 
            // mipMapLabel2
            // 
            this.mipMapLabel2.AutoSize = true;
            this.mipMapLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mipMapLabel2.Location = new System.Drawing.Point(596, 366);
            this.mipMapLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipMapLabel2.Name = "mipMapLabel2";
            this.mipMapLabel2.Size = new System.Drawing.Size(72, 17);
            this.mipMapLabel2.TabIndex = 41;
            this.mipMapLabel2.Text = "Mip Maps:";
            // 
            // resolutionCheck2
            // 
            this.resolutionCheck2.AutoSize = true;
            this.resolutionCheck2.Location = new System.Drawing.Point(697, 385);
            this.resolutionCheck2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionCheck2.Name = "resolutionCheck2";
            this.resolutionCheck2.Size = new System.Drawing.Size(42, 17);
            this.resolutionCheck2.TabIndex = 44;
            this.resolutionCheck2.Text = "None";
            // 
            // resolutionLabel2
            // 
            this.resolutionLabel2.AutoSize = true;
            this.resolutionLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resolutionLabel2.Location = new System.Drawing.Point(697, 366);
            this.resolutionLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionLabel2.Name = "resolutionLabel2";
            this.resolutionLabel2.Size = new System.Drawing.Size(79, 17);
            this.resolutionLabel2.TabIndex = 43;
            this.resolutionLabel2.Text = "Resolution:";
            // 
            // originaltexBrowse
            // 
            this.originaltexBrowse.Location = new System.Drawing.Point(615, 447);
            this.originaltexBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.originaltexBrowse.Name = "originaltexBrowse";
            this.originaltexBrowse.Size = new System.Drawing.Size(145, 33);
            this.originaltexBrowse.TabIndex = 0;
            this.originaltexBrowse.Text = "Browse";
            this.originaltexBrowse.UseVisualStyleBackColor = true;
            this.originaltexBrowse.Click += new System.EventHandler(this.OriginalTexBrowse_Click);
            // 
            // originaltexLabel
            // 
            this.originaltexLabel.AutoSize = true;
            this.originaltexLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.originaltexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originaltexLabel.Location = new System.Drawing.Point(24, 431);
            this.originaltexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originaltexLabel.Name = "originaltexLabel";
            this.originaltexLabel.Size = new System.Drawing.Size(296, 17);
            this.originaltexLabel.TabIndex = 1;
            this.originaltexLabel.Text = "Open original texture\'s image file (.dds)";
            // 
            // originaltexPathBox
            // 
            this.originaltexPathBox.AllowDrop = true;
            this.originaltexPathBox.Location = new System.Drawing.Point(24, 453);
            this.originaltexPathBox.Margin = new System.Windows.Forms.Padding(2);
            this.originaltexPathBox.Name = "originaltexPathBox";
            this.originaltexPathBox.Size = new System.Drawing.Size(562, 22);
            this.originaltexPathBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(807, 26);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(213, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // StoneMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 547);
            this.Controls.Add(this.resolutionCheck2);
            this.Controls.Add(this.resolutionLabel2);
            this.Controls.Add(this.mipMapCountLabel2);
            this.Controls.Add(this.mipMapLabel2);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.resolutionCheck1);
            this.Controls.Add(this.resolutionLabel1);
            this.Controls.Add(this.mipMapCountLabel1);
            this.Controls.Add(this.mipMapLabel1);
            this.Controls.Add(this.texturePreview1);
            this.Controls.Add(this.previewLabel2);
            this.Controls.Add(this.mipLabelMin);
            this.Controls.Add(this.mipLabelMax);
            this.Controls.Add(this.mipSettingLabel);
            this.Controls.Add(this.compressSettingLabel);
            this.Controls.Add(this.mipMapSetting);
            this.Controls.Add(this.exportSettingBox);
            this.Controls.Add(this.exportNUT);
            this.Controls.Add(this.exportOriginalDDS);
            this.Controls.Add(this.texturePreview2);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StoneMask";
            this.Text = "Stone Mask v1.0 - JoJo ASB/EoH Texture Editor";
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox texturePreview2;
        private System.Windows.Forms.TextBox moddedTexPathBox;
        private System.Windows.Forms.Button exportOriginalDDS;
        private System.Windows.Forms.Button exportNUT;
        private System.Windows.Forms.ComboBox exportSettingBox;
        private System.Windows.Forms.TrackBar mipMapSetting;
        private System.Windows.Forms.Label compressSettingLabel;
        private System.Windows.Forms.Label mipSettingLabel;
        private System.Windows.Forms.Label mipLabelMax;
        private System.Windows.Forms.Label mipLabelMin;
        private System.Windows.Forms.PictureBox texturePreview1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


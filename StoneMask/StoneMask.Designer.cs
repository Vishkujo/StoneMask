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
            this.exportXfbinDDS = new System.Windows.Forms.Button();
            this.exportNUT = new System.Windows.Forms.Button();
            this.exportSettingBox = new System.Windows.Forms.ComboBox();
            this.compressSettingLabel = new System.Windows.Forms.Label();
            this.mipSettingLabel = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NoesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mipMapSetting = new System.Windows.Forms.TrackBar();
            this.mipSliderValue = new System.Windows.Forms.Label();
            this.modelPreview = new System.Windows.Forms.Button();
            this.texturePreview1 = new System.Windows.Forms.PictureBox();
            this.texturePreview2 = new System.Windows.Forms.PictureBox();
            this.openModelDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).BeginInit();
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
            this.moddedTexPathBox.Location = new System.Drawing.Point(23, 301);
            this.moddedTexPathBox.Margin = new System.Windows.Forms.Padding(2);
            this.moddedTexPathBox.Name = "moddedTexPathBox";
            this.moddedTexPathBox.Size = new System.Drawing.Size(553, 22);
            this.moddedTexPathBox.TabIndex = 5;
            this.moddedTexPathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ModdedTexPathBox_DragDrop);
            this.moddedTexPathBox.DragOver += new System.Windows.Forms.DragEventHandler(this.ModdedTexPathBox_DragOver);
            this.moddedTexPathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModdedTexPathBox_KeyDown);
            // 
            // moddedtexLabel
            // 
            this.moddedtexLabel.AutoSize = true;
            this.moddedtexLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.moddedtexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moddedtexLabel.Location = new System.Drawing.Point(20, 281);
            this.moddedtexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moddedtexLabel.Name = "moddedtexLabel";
            this.moddedtexLabel.Size = new System.Drawing.Size(356, 17);
            this.moddedtexLabel.TabIndex = 4;
            this.moddedtexLabel.Text = "Open modded texture\'s image file (.dds or .png)";
            // 
            // xfbinPathBox
            // 
            this.xfbinPathBox.AllowDrop = true;
            this.xfbinPathBox.Location = new System.Drawing.Point(23, 60);
            this.xfbinPathBox.Margin = new System.Windows.Forms.Padding(2);
            this.xfbinPathBox.Name = "xfbinPathBox";
            this.xfbinPathBox.Size = new System.Drawing.Size(553, 22);
            this.xfbinPathBox.TabIndex = 8;
            this.xfbinPathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.XfbinPathBox_DragDrop);
            this.xfbinPathBox.DragOver += new System.Windows.Forms.DragEventHandler(this.XfbinPathBox_DragOver);
            this.xfbinPathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XfbinPathBox_KeyDown);
            // 
            // xfbinLabel
            // 
            this.xfbinLabel.AutoSize = true;
            this.xfbinLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.xfbinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xfbinLabel.Location = new System.Drawing.Point(23, 36);
            this.xfbinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xfbinLabel.Name = "xfbinLabel";
            this.xfbinLabel.Size = new System.Drawing.Size(213, 17);
            this.xfbinLabel.TabIndex = 7;
            this.xfbinLabel.Text = "Open the texture file (.xfbin)";
            // 
            // exportModdedDDSButton
            // 
            this.exportModdedDDSButton.Enabled = false;
            this.exportModdedDDSButton.Location = new System.Drawing.Point(177, 491);
            this.exportModdedDDSButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportModdedDDSButton.Name = "exportModdedDDSButton";
            this.exportModdedDDSButton.Size = new System.Drawing.Size(179, 44);
            this.exportModdedDDSButton.TabIndex = 9;
            this.exportModdedDDSButton.Text = "Export modded .dds";
            this.exportModdedDDSButton.UseVisualStyleBackColor = true;
            this.exportModdedDDSButton.Click += new System.EventHandler(this.DDSSave_Click);
            // 
            // compressionLabel1
            // 
            this.compressionLabel1.AutoSize = true;
            this.compressionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel1.Location = new System.Drawing.Point(601, 101);
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
            this.moddedtexBrowse.Location = new System.Drawing.Point(603, 294);
            this.moddedtexBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.moddedtexBrowse.Name = "moddedtexBrowse";
            this.moddedtexBrowse.Size = new System.Drawing.Size(142, 36);
            this.moddedtexBrowse.TabIndex = 13;
            this.moddedtexBrowse.Text = "Browse";
            this.moddedtexBrowse.UseVisualStyleBackColor = true;
            this.moddedtexBrowse.Click += new System.EventHandler(this.ModdedTexBrowse_Click);
            // 
            // xfbinBrowse
            // 
            this.xfbinBrowse.Location = new System.Drawing.Point(603, 53);
            this.xfbinBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.xfbinBrowse.Name = "xfbinBrowse";
            this.xfbinBrowse.Size = new System.Drawing.Size(142, 36);
            this.xfbinBrowse.TabIndex = 14;
            this.xfbinBrowse.Text = "Browse";
            this.xfbinBrowse.UseVisualStyleBackColor = true;
            this.xfbinBrowse.Click += new System.EventHandler(this.XfbinBrowse_Click);
            // 
            // originalTexCompression
            // 
            this.originalTexCompression.AutoSize = true;
            this.originalTexCompression.Location = new System.Drawing.Point(601, 122);
            this.originalTexCompression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originalTexCompression.Name = "originalTexCompression";
            this.originalTexCompression.Size = new System.Drawing.Size(42, 17);
            this.originalTexCompression.TabIndex = 15;
            this.originalTexCompression.Text = "None";
            // 
            // exportXFBINButton
            // 
            this.exportXFBINButton.Enabled = false;
            this.exportXFBINButton.Location = new System.Drawing.Point(419, 491);
            this.exportXFBINButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportXFBINButton.Name = "exportXFBINButton";
            this.exportXFBINButton.Size = new System.Drawing.Size(161, 44);
            this.exportXFBINButton.TabIndex = 16;
            this.exportXFBINButton.Text = "Export modded .xfbin";
            this.exportXFBINButton.UseVisualStyleBackColor = true;
            this.exportXFBINButton.Click += new System.EventHandler(this.XfbinSave_Click);
            // 
            // compressionLabel2
            // 
            this.compressionLabel2.AutoSize = true;
            this.compressionLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.compressionLabel2.Location = new System.Drawing.Point(599, 340);
            this.compressionLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compressionLabel2.Name = "compressionLabel2";
            this.compressionLabel2.Size = new System.Drawing.Size(144, 17);
            this.compressionLabel2.TabIndex = 17;
            this.compressionLabel2.Text = "Texture compression:";
            // 
            // moddedTexCompression
            // 
            this.moddedTexCompression.AutoSize = true;
            this.moddedTexCompression.Location = new System.Drawing.Point(601, 362);
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
            this.exportsettingLabel.Location = new System.Drawing.Point(24, 340);
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
            this.selectTexBox.Location = new System.Drawing.Point(23, 110);
            this.selectTexBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectTexBox.Name = "selectTexBox";
            this.selectTexBox.Size = new System.Drawing.Size(248, 132);
            this.selectTexBox.TabIndex = 22;
            this.selectTexBox.SelectedIndexChanged += new System.EventHandler(this.SelectTexBox_SelectedIndexChanged);
            // 
            // selectTexLabel
            // 
            this.selectTexLabel.AutoSize = true;
            this.selectTexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectTexLabel.Location = new System.Drawing.Point(21, 91);
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
            this.previewLabel1.Location = new System.Drawing.Point(389, 91);
            this.previewLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewLabel1.Name = "previewLabel1";
            this.previewLabel1.Size = new System.Drawing.Size(0, 17);
            this.previewLabel1.TabIndex = 24;
            // 
            // exportXfbinDDS
            // 
            this.exportXfbinDDS.Enabled = false;
            this.exportXfbinDDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.514286F);
            this.exportXfbinDDS.Location = new System.Drawing.Point(419, 217);
            this.exportXfbinDDS.Margin = new System.Windows.Forms.Padding(2);
            this.exportXfbinDDS.Name = "exportXfbinDDS";
            this.exportXfbinDDS.Size = new System.Drawing.Size(65, 44);
            this.exportXfbinDDS.TabIndex = 26;
            this.exportXfbinDDS.Text = "Export .dds";
            this.exportXfbinDDS.UseVisualStyleBackColor = true;
            this.exportXfbinDDS.Click += new System.EventHandler(this.ExportXfbinDDS_Click);
            // 
            // exportNUT
            // 
            this.exportNUT.Enabled = false;
            this.exportNUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.542858F);
            this.exportNUT.Location = new System.Drawing.Point(489, 217);
            this.exportNUT.Margin = new System.Windows.Forms.Padding(2);
            this.exportNUT.Name = "exportNUT";
            this.exportNUT.Size = new System.Drawing.Size(65, 44);
            this.exportNUT.TabIndex = 27;
            this.exportNUT.Text = "Export .nut";
            this.exportNUT.UseVisualStyleBackColor = true;
            this.exportNUT.Click += new System.EventHandler(this.ExportNUT_Click);
            // 
            // exportSettingBox
            // 
            this.exportSettingBox.FormattingEnabled = true;
            this.exportSettingBox.Items.AddRange(new object[] {
            "DXT1",
            "DXT5"});
            this.exportSettingBox.Location = new System.Drawing.Point(123, 362);
            this.exportSettingBox.Margin = new System.Windows.Forms.Padding(2);
            this.exportSettingBox.Name = "exportSettingBox";
            this.exportSettingBox.Size = new System.Drawing.Size(182, 24);
            this.exportSettingBox.TabIndex = 28;
            this.exportSettingBox.Text = "DXT1";
            // 
            // compressSettingLabel
            // 
            this.compressSettingLabel.AutoSize = true;
            this.compressSettingLabel.Location = new System.Drawing.Point(23, 362);
            this.compressSettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compressSettingLabel.Name = "compressSettingLabel";
            this.compressSettingLabel.Size = new System.Drawing.Size(94, 17);
            this.compressSettingLabel.TabIndex = 30;
            this.compressSettingLabel.Text = "Compression:";
            // 
            // mipSettingLabel
            // 
            this.mipSettingLabel.AutoSize = true;
            this.mipSettingLabel.Location = new System.Drawing.Point(23, 392);
            this.mipSettingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipSettingLabel.Name = "mipSettingLabel";
            this.mipSettingLabel.Size = new System.Drawing.Size(72, 17);
            this.mipSettingLabel.TabIndex = 31;
            this.mipSettingLabel.Text = "Mip Maps:";
            // 
            // previewLabel2
            // 
            this.previewLabel2.AutoSize = true;
            this.previewLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.previewLabel2.Location = new System.Drawing.Point(389, 340);
            this.previewLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewLabel2.Name = "previewLabel2";
            this.previewLabel2.Size = new System.Drawing.Size(0, 17);
            this.previewLabel2.TabIndex = 34;
            // 
            // mipMapCountLabel1
            // 
            this.mipMapCountLabel1.AutoSize = true;
            this.mipMapCountLabel1.Location = new System.Drawing.Point(589, 170);
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
            this.mipMapLabel1.Location = new System.Drawing.Point(589, 150);
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
            this.resolutionLabel1.Location = new System.Drawing.Point(684, 150);
            this.resolutionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionLabel1.Name = "resolutionLabel1";
            this.resolutionLabel1.Size = new System.Drawing.Size(79, 17);
            this.resolutionLabel1.TabIndex = 38;
            this.resolutionLabel1.Text = "Resolution:";
            // 
            // resolutionCheck1
            // 
            this.resolutionCheck1.AutoSize = true;
            this.resolutionCheck1.Location = new System.Drawing.Point(684, 170);
            this.resolutionCheck1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionCheck1.Name = "resolutionCheck1";
            this.resolutionCheck1.Size = new System.Drawing.Size(42, 17);
            this.resolutionCheck1.TabIndex = 39;
            this.resolutionCheck1.Text = "None";
            // 
            // replaceButton
            // 
            this.replaceButton.Enabled = false;
            this.replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.542858F);
            this.replaceButton.Location = new System.Drawing.Point(291, 217);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(2);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(121, 44);
            this.replaceButton.TabIndex = 40;
            this.replaceButton.Text = "Replace selected texture";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // mipMapCountLabel2
            // 
            this.mipMapCountLabel2.AutoSize = true;
            this.mipMapCountLabel2.Location = new System.Drawing.Point(586, 413);
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
            this.mipMapLabel2.Location = new System.Drawing.Point(586, 392);
            this.mipMapLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipMapLabel2.Name = "mipMapLabel2";
            this.mipMapLabel2.Size = new System.Drawing.Size(72, 17);
            this.mipMapLabel2.TabIndex = 41;
            this.mipMapLabel2.Text = "Mip Maps:";
            // 
            // resolutionCheck2
            // 
            this.resolutionCheck2.AutoSize = true;
            this.resolutionCheck2.Location = new System.Drawing.Point(684, 413);
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
            this.resolutionLabel2.Location = new System.Drawing.Point(684, 392);
            this.resolutionLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resolutionLabel2.Name = "resolutionLabel2";
            this.resolutionLabel2.Size = new System.Drawing.Size(79, 17);
            this.resolutionLabel2.TabIndex = 43;
            this.resolutionLabel2.Text = "Resolution:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(793, 26);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NoesisToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // NoesisToolStripMenuItem
            // 
            this.NoesisToolStripMenuItem.Name = "NoesisToolStripMenuItem";
            this.NoesisToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.NoesisToolStripMenuItem.Text = "Noesis";
            this.NoesisToolStripMenuItem.Click += new System.EventHandler(this.NoesisToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(131, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // mipMapSetting
            // 
            this.mipMapSetting.Location = new System.Drawing.Point(123, 392);
            this.mipMapSetting.Margin = new System.Windows.Forms.Padding(2);
            this.mipMapSetting.Maximum = 12;
            this.mipMapSetting.Minimum = 1;
            this.mipMapSetting.Name = "mipMapSetting";
            this.mipMapSetting.Size = new System.Drawing.Size(181, 56);
            this.mipMapSetting.TabIndex = 29;
            this.mipMapSetting.Value = 1;
            this.mipMapSetting.Scroll += new System.EventHandler(this.MipMapSetting_Scroll);
            // 
            // mipSliderValue
            // 
            this.mipSliderValue.AutoSize = true;
            this.mipSliderValue.Location = new System.Drawing.Point(47, 413);
            this.mipSliderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mipSliderValue.Name = "mipSliderValue";
            this.mipSliderValue.Size = new System.Drawing.Size(16, 17);
            this.mipSliderValue.TabIndex = 33;
            this.mipSliderValue.Text = "1";
            // 
            // modelPreview
            // 
            this.modelPreview.Enabled = false;
            this.modelPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.514286F);
            this.modelPreview.Location = new System.Drawing.Point(620, 217);
            this.modelPreview.Margin = new System.Windows.Forms.Padding(2);
            this.modelPreview.Name = "modelPreview";
            this.modelPreview.Size = new System.Drawing.Size(106, 44);
            this.modelPreview.TabIndex = 46;
            this.modelPreview.Text = "Preview in Noesis";
            this.modelPreview.UseVisualStyleBackColor = true;
            this.modelPreview.Click += new System.EventHandler(this.ModelPreview_Click);
            // 
            // texturePreview1
            // 
            this.texturePreview1.Location = new System.Drawing.Point(336, 110);
            this.texturePreview1.Margin = new System.Windows.Forms.Padding(2);
            this.texturePreview1.Name = "texturePreview1";
            this.texturePreview1.Size = new System.Drawing.Size(183, 103);
            this.texturePreview1.TabIndex = 35;
            this.texturePreview1.TabStop = false;
            // 
            // texturePreview2
            // 
            this.texturePreview2.Location = new System.Drawing.Point(336, 362);
            this.texturePreview2.Margin = new System.Windows.Forms.Padding(2);
            this.texturePreview2.Name = "texturePreview2";
            this.texturePreview2.Size = new System.Drawing.Size(183, 103);
            this.texturePreview2.TabIndex = 25;
            this.texturePreview2.TabStop = false;
            // 
            // openModelDialog
            // 
            this.openModelDialog.Filter = "Model XFBIN|*.xfbin";
            // 
            // StoneMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(793, 546);
            this.Controls.Add(this.modelPreview);
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
            this.Controls.Add(this.mipSliderValue);
            this.Controls.Add(this.mipSettingLabel);
            this.Controls.Add(this.compressSettingLabel);
            this.Controls.Add(this.mipMapSetting);
            this.Controls.Add(this.exportSettingBox);
            this.Controls.Add(this.exportNUT);
            this.Controls.Add(this.exportXfbinDDS);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StoneMask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Mask - JoJo ASB/EoH Texture Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoneMask_FormClosed);
            this.Load += new System.EventHandler(this.StoneMask_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mipMapSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreview1)).EndInit();
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
        private System.Windows.Forms.PictureBox texturePreview2;
        private System.Windows.Forms.TextBox moddedTexPathBox;
        private System.Windows.Forms.Button exportXfbinDDS;
        private System.Windows.Forms.Button exportNUT;
        private System.Windows.Forms.ComboBox exportSettingBox;
        private System.Windows.Forms.Label compressSettingLabel;
        private System.Windows.Forms.Label mipSettingLabel;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar mipMapSetting;
        private System.Windows.Forms.Label mipSliderValue;
        private System.Windows.Forms.Button modelPreview;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openModelDialog;
    }
}


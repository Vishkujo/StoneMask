namespace StoneMask
{
    partial class NoesisSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoesisSettings));
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.directoryBrowse = new System.Windows.Forms.Button();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.openNoesisPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.directoryLabel.Location = new System.Drawing.Point(9, 31);
            this.directoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(100, 17);
            this.directoryLabel.TabIndex = 24;
            this.directoryLabel.Text = "Path to Noesis";
            // 
            // directoryBox
            // 
            this.directoryBox.AllowDrop = true;
            this.directoryBox.Location = new System.Drawing.Point(125, 28);
            this.directoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(294, 22);
            this.directoryBox.TabIndex = 25;
            this.directoryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirectoryBox_KeyDown);
            // 
            // directoryBrowse
            // 
            this.directoryBrowse.Location = new System.Drawing.Point(438, 23);
            this.directoryBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.directoryBrowse.Name = "directoryBrowse";
            this.directoryBrowse.Size = new System.Drawing.Size(98, 33);
            this.directoryBrowse.TabIndex = 26;
            this.directoryBrowse.Text = "Browse";
            this.directoryBrowse.UseVisualStyleBackColor = true;
            this.directoryBrowse.Click += new System.EventHandler(this.DirectoryBrowse_Click);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(12, 87);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(214, 21);
            this.closeCheckBox.TabIndex = 27;
            this.closeCheckBox.Text = "Close Noesis with StoneMask";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            // 
            // openNoesisPathDialog
            // 
            this.openNoesisPathDialog.Filter = "Noesis|*.exe";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(321, 309);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 33);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(438, 309);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 33);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoesisSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(547, 353);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.directoryBrowse);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.directoryLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoesisSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Noesis Settings";
            this.Load += new System.EventHandler(this.NoesisSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button directoryBrowse;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.OpenFileDialog openNoesisPathDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
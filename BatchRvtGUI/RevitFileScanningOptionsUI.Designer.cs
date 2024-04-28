namespace BatchRvtGUI
{
    partial class RevitFileScanningOptionsUI
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.startScanButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.otherOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ignoreBackupFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.asteriskNoteLabel = new System.Windows.Forms.Label();
            this.detectRevitFileVersionCheckBox = new System.Windows.Forms.CheckBox();
            this.expandNetworkPathsCheckBox = new System.Windows.Forms.CheckBox();
            this.includeSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.revitFileTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.revitFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.projectFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.familyFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsGroupBox.SuspendLayout();
            this.otherOptionsGroupBox.SuspendLayout();
            this.revitFileTypesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(398, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // startScanButton
            // 
            this.startScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startScanButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startScanButton.Location = new System.Drawing.Point(254, 182);
            this.startScanButton.Name = "startScanButton";
            this.startScanButton.Size = new System.Drawing.Size(138, 21);
            this.startScanButton.TabIndex = 1;
            this.startScanButton.Text = "Start Scanning";
            this.startScanButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.otherOptionsGroupBox);
            this.optionsGroupBox.Controls.Add(this.revitFileTypesGroupBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 11);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(461, 150);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // otherOptionsGroupBox
            // 
            this.otherOptionsGroupBox.Controls.Add(this.ignoreBackupFilesCheckBox);
            this.otherOptionsGroupBox.Controls.Add(this.asteriskNoteLabel);
            this.otherOptionsGroupBox.Controls.Add(this.detectRevitFileVersionCheckBox);
            this.otherOptionsGroupBox.Controls.Add(this.expandNetworkPathsCheckBox);
            this.otherOptionsGroupBox.Controls.Add(this.includeSubfoldersCheckBox);
            this.otherOptionsGroupBox.Location = new System.Drawing.Point(192, 18);
            this.otherOptionsGroupBox.Name = "otherOptionsGroupBox";
            this.otherOptionsGroupBox.Size = new System.Drawing.Size(255, 124);
            this.otherOptionsGroupBox.TabIndex = 1;
            this.otherOptionsGroupBox.TabStop = false;
            this.otherOptionsGroupBox.Text = "Additional Options";
            // 
            // ignoreBackupFilesCheckBox
            // 
            this.ignoreBackupFilesCheckBox.AutoSize = true;
            this.ignoreBackupFilesCheckBox.Checked = true;
            this.ignoreBackupFilesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreBackupFilesCheckBox.Location = new System.Drawing.Point(6, 81);
            this.ignoreBackupFilesCheckBox.Name = "ignoreBackupFilesCheckBox";
            this.ignoreBackupFilesCheckBox.Size = new System.Drawing.Size(210, 16);
            this.ignoreBackupFilesCheckBox.TabIndex = 4;
            this.ignoreBackupFilesCheckBox.Text = "Ignore backup files (.0001.rvt)";
            this.ignoreBackupFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // asteriskNoteLabel
            // 
            this.asteriskNoteLabel.AutoSize = true;
            this.asteriskNoteLabel.Location = new System.Drawing.Point(22, 100);
            this.asteriskNoteLabel.Name = "asteriskNoteLabel";
            this.asteriskNoteLabel.Size = new System.Drawing.Size(203, 12);
            this.asteriskNoteLabel.TabIndex = 3;
            this.asteriskNoteLabel.Text = "(*) appears as additional columns";
            // 
            // detectRevitFileVersionCheckBox
            // 
            this.detectRevitFileVersionCheckBox.AutoSize = true;
            this.detectRevitFileVersionCheckBox.Location = new System.Drawing.Point(6, 60);
            this.detectRevitFileVersionCheckBox.Name = "detectRevitFileVersionCheckBox";
            this.detectRevitFileVersionCheckBox.Size = new System.Drawing.Size(234, 16);
            this.detectRevitFileVersionCheckBox.TabIndex = 2;
            this.detectRevitFileVersionCheckBox.Text = "Extract Revit File Version Info (*)";
            this.detectRevitFileVersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // expandNetworkPathsCheckBox
            // 
            this.expandNetworkPathsCheckBox.AutoSize = true;
            this.expandNetworkPathsCheckBox.Location = new System.Drawing.Point(6, 39);
            this.expandNetworkPathsCheckBox.Name = "expandNetworkPathsCheckBox";
            this.expandNetworkPathsCheckBox.Size = new System.Drawing.Size(144, 16);
            this.expandNetworkPathsCheckBox.TabIndex = 1;
            this.expandNetworkPathsCheckBox.Text = "Expand Network paths";
            this.expandNetworkPathsCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeSubfoldersCheckBox
            // 
            this.includeSubfoldersCheckBox.AutoSize = true;
            this.includeSubfoldersCheckBox.Location = new System.Drawing.Point(6, 18);
            this.includeSubfoldersCheckBox.Name = "includeSubfoldersCheckBox";
            this.includeSubfoldersCheckBox.Size = new System.Drawing.Size(132, 16);
            this.includeSubfoldersCheckBox.TabIndex = 0;
            this.includeSubfoldersCheckBox.Text = "Include Subfolders";
            this.includeSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // revitFileTypesGroupBox
            // 
            this.revitFileTypesGroupBox.Controls.Add(this.revitFilesRadioButton);
            this.revitFileTypesGroupBox.Controls.Add(this.projectFilesRadioButton);
            this.revitFileTypesGroupBox.Controls.Add(this.familyFilesRadioButton);
            this.revitFileTypesGroupBox.Location = new System.Drawing.Point(6, 18);
            this.revitFileTypesGroupBox.Name = "revitFileTypesGroupBox";
            this.revitFileTypesGroupBox.Size = new System.Drawing.Size(180, 124);
            this.revitFileTypesGroupBox.TabIndex = 0;
            this.revitFileTypesGroupBox.TabStop = false;
            this.revitFileTypesGroupBox.Text = "Revit File Types";
            // 
            // revitFilesRadioButton
            // 
            this.revitFilesRadioButton.AutoSize = true;
            this.revitFilesRadioButton.Location = new System.Drawing.Point(6, 60);
            this.revitFilesRadioButton.Name = "revitFilesRadioButton";
            this.revitFilesRadioButton.Size = new System.Drawing.Size(167, 16);
            this.revitFilesRadioButton.TabIndex = 2;
            this.revitFilesRadioButton.Text = "Project and Family Files";
            this.revitFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // projectFilesRadioButton
            // 
            this.projectFilesRadioButton.AutoSize = true;
            this.projectFilesRadioButton.Checked = true;
            this.projectFilesRadioButton.Location = new System.Drawing.Point(6, 18);
            this.projectFilesRadioButton.Name = "projectFilesRadioButton";
            this.projectFilesRadioButton.Size = new System.Drawing.Size(101, 16);
            this.projectFilesRadioButton.TabIndex = 0;
            this.projectFilesRadioButton.TabStop = true;
            this.projectFilesRadioButton.Text = "Project Files";
            this.projectFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // familyFilesRadioButton
            // 
            this.familyFilesRadioButton.AutoSize = true;
            this.familyFilesRadioButton.Location = new System.Drawing.Point(6, 39);
            this.familyFilesRadioButton.Name = "familyFilesRadioButton";
            this.familyFilesRadioButton.Size = new System.Drawing.Size(95, 16);
            this.familyFilesRadioButton.TabIndex = 1;
            this.familyFilesRadioButton.Text = "Family Files";
            this.familyFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // RevitFileScanningOptionsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 214);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.startScanButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RevitFileScanningOptionsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Revit File Scanning Options";
            this.optionsGroupBox.ResumeLayout(false);
            this.otherOptionsGroupBox.ResumeLayout(false);
            this.otherOptionsGroupBox.PerformLayout();
            this.revitFileTypesGroupBox.ResumeLayout(false);
            this.revitFileTypesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startScanButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.GroupBox revitFileTypesGroupBox;
        private System.Windows.Forms.RadioButton revitFilesRadioButton;
        private System.Windows.Forms.RadioButton projectFilesRadioButton;
        private System.Windows.Forms.RadioButton familyFilesRadioButton;
        private System.Windows.Forms.CheckBox expandNetworkPathsCheckBox;
        private System.Windows.Forms.CheckBox includeSubfoldersCheckBox;
        private System.Windows.Forms.GroupBox otherOptionsGroupBox;
        private System.Windows.Forms.CheckBox detectRevitFileVersionCheckBox;
        private System.Windows.Forms.CheckBox ignoreBackupFilesCheckBox;
        private System.Windows.Forms.Label asteriskNoteLabel;
    }
}
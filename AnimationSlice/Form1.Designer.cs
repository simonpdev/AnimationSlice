namespace AnimationSlice
{
    partial class frmBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFrameWidth = new System.Windows.Forms.Label();
            this.numFrameWidth = new System.Windows.Forms.NumericUpDown();
            this.numFrameHeight = new System.Windows.Forms.NumericUpDown();
            this.btnSlice = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.rtxAnimationNames = new System.Windows.Forms.RichTextBox();
            this.tabExportData = new System.Windows.Forms.TabControl();
            this.AnimationTab = new System.Windows.Forms.TabPage();
            this.NameTab = new System.Windows.Forms.TabPage();
            this.rtxFileNames = new System.Windows.Forms.RichTextBox();
            this.lblFrameHeight = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnExportPathSelect = new System.Windows.Forms.Button();
            this.rtxLoadedFiles = new System.Windows.Forms.RichTextBox();
            this.chkGMSNaming = new System.Windows.Forms.CheckBox();
            this.chkFileNameInherit = new System.Windows.Forms.CheckBox();
            this.SubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.prgExport = new System.Windows.Forms.ProgressBar();
            this.lblExportProgress = new System.Windows.Forms.Label();
            this.chkExportPathInherit = new System.Windows.Forms.CheckBox();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.lblImages = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpFrameSize = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameHeight)).BeginInit();
            this.tabExportData.SuspendLayout();
            this.AnimationTab.SuspendLayout();
            this.NameTab.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpFrameSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrameWidth
            // 
            this.lblFrameWidth.AutoSize = true;
            this.lblFrameWidth.Location = new System.Drawing.Point(17, 25);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Size = new System.Drawing.Size(39, 15);
            this.lblFrameWidth.TabIndex = 1;
            this.lblFrameWidth.Text = "Width";
            // 
            // numFrameWidth
            // 
            this.numFrameWidth.Location = new System.Drawing.Point(17, 42);
            this.numFrameWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFrameWidth.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numFrameWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrameWidth.Name = "numFrameWidth";
            this.numFrameWidth.Size = new System.Drawing.Size(116, 23);
            this.numFrameWidth.TabIndex = 0;
            this.numFrameWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numFrameHeight
            // 
            this.numFrameHeight.Location = new System.Drawing.Point(17, 90);
            this.numFrameHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFrameHeight.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numFrameHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrameHeight.Name = "numFrameHeight";
            this.numFrameHeight.Size = new System.Drawing.Size(116, 23);
            this.numFrameHeight.TabIndex = 1;
            this.numFrameHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // btnSlice
            // 
            this.btnSlice.Location = new System.Drawing.Point(434, 341);
            this.btnSlice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSlice.Name = "btnSlice";
            this.btnSlice.Size = new System.Drawing.Size(338, 40);
            this.btnSlice.TabIndex = 5;
            this.btnSlice.Text = "SLICE";
            this.btnSlice.UseVisualStyleBackColor = true;
            this.btnSlice.Click += new System.EventHandler(this.btnSlice_Click);
            // 
            // rtxAnimationNames
            // 
            this.rtxAnimationNames.DetectUrls = false;
            this.rtxAnimationNames.Location = new System.Drawing.Point(0, 0);
            this.rtxAnimationNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxAnimationNames.Name = "rtxAnimationNames";
            this.rtxAnimationNames.Size = new System.Drawing.Size(317, 99);
            this.rtxAnimationNames.TabIndex = 2;
            this.rtxAnimationNames.Text = "";
            // 
            // tabExportData
            // 
            this.tabExportData.Controls.Add(this.AnimationTab);
            this.tabExportData.Controls.Add(this.NameTab);
            this.tabExportData.Location = new System.Drawing.Point(28, 258);
            this.tabExportData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabExportData.Name = "tabExportData";
            this.tabExportData.SelectedIndex = 0;
            this.tabExportData.Size = new System.Drawing.Size(324, 123);
            this.tabExportData.TabIndex = 4;
            this.tabExportData.TabStop = false;
            // 
            // AnimationTab
            // 
            this.AnimationTab.Controls.Add(this.rtxAnimationNames);
            this.AnimationTab.Location = new System.Drawing.Point(4, 24);
            this.AnimationTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnimationTab.Name = "AnimationTab";
            this.AnimationTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnimationTab.Size = new System.Drawing.Size(316, 95);
            this.AnimationTab.TabIndex = 0;
            this.AnimationTab.Text = "Rows Animations";
            this.AnimationTab.UseVisualStyleBackColor = true;
            // 
            // NameTab
            // 
            this.NameTab.Controls.Add(this.rtxFileNames);
            this.NameTab.Location = new System.Drawing.Point(4, 24);
            this.NameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTab.Name = "NameTab";
            this.NameTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTab.Size = new System.Drawing.Size(316, 95);
            this.NameTab.TabIndex = 1;
            this.NameTab.Text = "File Names";
            this.NameTab.UseVisualStyleBackColor = true;
            // 
            // rtxFileNames
            // 
            this.rtxFileNames.DetectUrls = false;
            this.rtxFileNames.Location = new System.Drawing.Point(0, 0);
            this.rtxFileNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxFileNames.Name = "rtxFileNames";
            this.rtxFileNames.Size = new System.Drawing.Size(317, 115);
            this.rtxFileNames.TabIndex = 3;
            this.rtxFileNames.Text = "";
            // 
            // lblFrameHeight
            // 
            this.lblFrameHeight.AutoSize = true;
            this.lblFrameHeight.Location = new System.Drawing.Point(17, 73);
            this.lblFrameHeight.Name = "lblFrameHeight";
            this.lblFrameHeight.Size = new System.Drawing.Size(43, 15);
            this.lblFrameHeight.TabIndex = 8;
            this.lblFrameHeight.Text = "Height";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(434, 290);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(158, 40);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "LOAD IMAGES";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnExportPathSelect
            // 
            this.btnExportPathSelect.Location = new System.Drawing.Point(614, 290);
            this.btnExportPathSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportPathSelect.Name = "btnExportPathSelect";
            this.btnExportPathSelect.Size = new System.Drawing.Size(158, 40);
            this.btnExportPathSelect.TabIndex = 1;
            this.btnExportPathSelect.Text = "SELECT EXPORT PATH";
            this.btnExportPathSelect.UseVisualStyleBackColor = true;
            this.btnExportPathSelect.Click += new System.EventHandler(this.btnExportPathSelect_Click);
            // 
            // rtxLoadedFiles
            // 
            this.rtxLoadedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.rtxLoadedFiles.Location = new System.Drawing.Point(28, 47);
            this.rtxLoadedFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxLoadedFiles.Name = "rtxLoadedFiles";
            this.rtxLoadedFiles.ReadOnly = true;
            this.rtxLoadedFiles.Size = new System.Drawing.Size(324, 111);
            this.rtxLoadedFiles.TabIndex = 11;
            this.rtxLoadedFiles.TabStop = false;
            this.rtxLoadedFiles.Text = "";
            // 
            // chkGMSNaming
            // 
            this.chkGMSNaming.AutoSize = true;
            this.chkGMSNaming.Location = new System.Drawing.Point(16, 93);
            this.chkGMSNaming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGMSNaming.Name = "chkGMSNaming";
            this.chkGMSNaming.Size = new System.Drawing.Size(95, 19);
            this.chkGMSNaming.TabIndex = 3;
            this.chkGMSNaming.Text = "GMS2 _stripX";
            this.chkGMSNaming.UseVisualStyleBackColor = true;
            // 
            // chkFileNameInherit
            // 
            this.chkFileNameInherit.AutoSize = true;
            this.chkFileNameInherit.Checked = true;
            this.chkFileNameInherit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileNameInherit.Location = new System.Drawing.Point(16, 47);
            this.chkFileNameInherit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFileNameInherit.Name = "chkFileNameInherit";
            this.chkFileNameInherit.Size = new System.Drawing.Size(144, 19);
            this.chkFileNameInherit.TabIndex = 1;
            this.chkFileNameInherit.Text = "File Name from Image";
            this.chkFileNameInherit.UseVisualStyleBackColor = true;
            // 
            // SubfoldersCheckBox
            // 
            this.SubfoldersCheckBox.AutoSize = true;
            this.SubfoldersCheckBox.Location = new System.Drawing.Point(16, 24);
            this.SubfoldersCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubfoldersCheckBox.Name = "SubfoldersCheckBox";
            this.SubfoldersCheckBox.Size = new System.Drawing.Size(154, 19);
            this.SubfoldersCheckBox.TabIndex = 0;
            this.SubfoldersCheckBox.Text = "Images From Subfolders";
            this.SubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // prgExport
            // 
            this.prgExport.Location = new System.Drawing.Point(430, 209);
            this.prgExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prgExport.Name = "prgExport";
            this.prgExport.Size = new System.Drawing.Size(342, 23);
            this.prgExport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgExport.TabIndex = 15;
            // 
            // lblExportProgress
            // 
            this.lblExportProgress.AutoSize = true;
            this.lblExportProgress.Location = new System.Drawing.Point(430, 191);
            this.lblExportProgress.Name = "lblExportProgress";
            this.lblExportProgress.Size = new System.Drawing.Size(89, 15);
            this.lblExportProgress.TabIndex = 16;
            this.lblExportProgress.Text = "Export Progress";
            this.lblExportProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkExportPathInherit
            // 
            this.chkExportPathInherit.AutoSize = true;
            this.chkExportPathInherit.Location = new System.Drawing.Point(16, 70);
            this.chkExportPathInherit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExportPathInherit.Name = "chkExportPathInherit";
            this.chkExportPathInherit.Size = new System.Drawing.Size(152, 19);
            this.chkExportPathInherit.TabIndex = 2;
            this.chkExportPathInherit.Text = "Export Path from Image";
            this.chkExportPathInherit.UseVisualStyleBackColor = true;
            this.chkExportPathInherit.CheckedChanged += new System.EventHandler(this.chkExportPathInherit_CheckedChanged);
            // 
            // txtExportPath
            // 
            this.txtExportPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtExportPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtExportPath.Location = new System.Drawing.Point(28, 209);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(324, 23);
            this.txtExportPath.TabIndex = 17;
            this.txtExportPath.TabStop = false;
            this.txtExportPath.TextChanged += new System.EventHandler(this.txtExportPath_TextChanged);
            // 
            // lblExportPath
            // 
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Location = new System.Drawing.Point(28, 191);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(68, 15);
            this.lblExportPath.TabIndex = 18;
            this.lblExportPath.Text = "Export Path";
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Location = new System.Drawing.Point(28, 30);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(45, 15);
            this.lblImages.TabIndex = 19;
            this.lblImages.Text = "Images";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.SubfoldersCheckBox);
            this.grpOptions.Controls.Add(this.chkGMSNaming);
            this.grpOptions.Controls.Add(this.chkFileNameInherit);
            this.grpOptions.Controls.Add(this.chkExportPathInherit);
            this.grpOptions.Location = new System.Drawing.Point(430, 30);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(185, 128);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpFrameSize
            // 
            this.grpFrameSize.Controls.Add(this.numFrameHeight);
            this.grpFrameSize.Controls.Add(this.lblFrameWidth);
            this.grpFrameSize.Controls.Add(this.numFrameWidth);
            this.grpFrameSize.Controls.Add(this.lblFrameHeight);
            this.grpFrameSize.Location = new System.Drawing.Point(630, 30);
            this.grpFrameSize.Name = "grpFrameSize";
            this.grpFrameSize.Size = new System.Drawing.Size(142, 128);
            this.grpFrameSize.TabIndex = 3;
            this.grpFrameSize.TabStop = false;
            this.grpFrameSize.Text = "Frame Size";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 416);
            this.Controls.Add(this.grpFrameSize);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblImages);
            this.Controls.Add(this.lblExportPath);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.lblExportProgress);
            this.Controls.Add(this.prgExport);
            this.Controls.Add(this.rtxLoadedFiles);
            this.Controls.Add(this.btnExportPathSelect);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.tabExportData);
            this.Controls.Add(this.btnSlice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.Text = "Animations Slice";
            ((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameHeight)).EndInit();
            this.tabExportData.ResumeLayout(false);
            this.AnimationTab.ResumeLayout(false);
            this.NameTab.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpFrameSize.ResumeLayout(false);
            this.grpFrameSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFrameWidth;
        private NumericUpDown numFrameWidth;
        private NumericUpDown numFrameHeight;
        private Button btnSlice;
        private FolderBrowserDialog folderBrowserDialog;
        private RichTextBox rtxAnimationNames;
        private TabControl tabExportData;
        private TabPage AnimationTab;
        private TabPage NameTab;
        private RichTextBox rtxFileNames;
        private Label lblFrameHeight;
        private Button btnSelectFolder;
        private Button btnExportPathSelect;
        private RichTextBox rtxLoadedFiles;
        private CheckBox chkGMSNaming;
        private CheckBox chkFileNameInherit;
        private CheckBox SubfoldersCheckBox;
        private ProgressBar prgExport;
        private Label lblExportProgress;
        private CheckBox chkExportPathInherit;
        private TextBox txtExportPath;
        private Label lblExportPath;
        private Label lblImages;
        private GroupBox grpOptions;
        private GroupBox grpFrameSize;
    }
}
namespace AnimationSlice
{
    public partial class frmBase : Form
    {
        public string SelectedFolderPath = "";
        public string ExportFolder = "";
        public List<String> ImagesPaths = new List<String>();

        public frmBase()
        {
            InitializeComponent();
        }




        // --- IMAGES PATHS LOADING ---
        public static List<string> GetImagesAt(string path)
        {
            return Directory.GetFiles(path, "*.*").Where(img => img.EndsWith(".png") || img.EndsWith(".jpg")).ToList();
        }

        public void SelectImages()
        {
            DialogResult selectedFolder = folderBrowserDialog.ShowDialog();
            if (selectedFolder == DialogResult.OK && folderBrowserDialog.SelectedPath != "")
            {
                ImagesPaths.Clear();
                rtxLoadedFiles.Text = "";

                if (SubfoldersCheckBox.Checked) ImagesSearchSubfolders(folderBrowserDialog.SelectedPath);
                else ImagesPaths = GetImagesAt(folderBrowserDialog.SelectedPath);

                if (ImagesPaths.Count > 0)
                {
                    ImagesPaths.Sort();
                    SelectedFolderPath = folderBrowserDialog.SelectedPath;
                    rtxLoadedFiles.Lines = ImagesPaths.ToArray();
                }
                else MessageBox.Show("Selected Folder does not contain Images");
            }
        }

        public void ImagesSearchSubfolders(string folderPath)
        {
            foreach (string folder in Directory.GetDirectories(folderPath))
            {
                ImagesSearchSubfolders(folder);
            }
            GetImagesAt(folderPath).ForEach(i => ImagesPaths.Add(i));
        }




        // --- EXPORT PATH SELECTION ---
        public void SelectExportPath()
        {
            DialogResult selectedFolder = folderBrowserDialog.ShowDialog();

            if (selectedFolder == DialogResult.OK && folderBrowserDialog.SelectedPath != "")
            {
                ExportFolder = folderBrowserDialog.SelectedPath + "\\";
                txtExportPath.Text = folderBrowserDialog.SelectedPath;
            }
        }




        // --- SLICE CONDITIONS CHECK ---
        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch (IndexOutOfRangeException error)
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }

            return message;
        }

        public bool CanSliceCheck() 
        {
            bool[] errorConditions = { 
                String.IsNullOrEmpty(SelectedFolderPath),
                String.IsNullOrEmpty(rtxAnimationNames.Text),
                !chkFileNameInherit.Checked && String.IsNullOrEmpty(ExportFolder),
                ImagesPaths.Count <= 0
            };

            string[] errorMessages = {
                "Images Folder was not selected",
                "Animation Names were not specified",
                "Export Folder was not selected",
                "There are no Images in selected Folder"
            };

            string errorMessage = ComputeErrorMessage(errorConditions, errorMessages);

            if (String.IsNullOrEmpty(errorMessage)) return true;
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            } 
        }

        



        // --- SLICE FUNCTION ---
        public void Slice()
        {
            if (CanSliceCheck())
            {
                btnSlice.Enabled = false;
                btnExportPathSelect.Enabled = false;

                // File Name Data
                string[] animationNames = rtxAnimationNames.Lines;
                string[] fileNames = rtxFileNames.Lines;
                int animationsCount = animationNames.Length;


                // Export Options
                bool IsFileNamesEmpty = String.IsNullOrEmpty(rtxFileNames.Text);
                bool fileNameFromImage = chkFileNameInherit.Checked;
                bool fileExportPathFromImage = chkExportPathInherit.Checked;
                bool fileNameAppendFrameNumber = false;
                string fileNameSuffix = "";

                if (chkGMSNaming.Checked)
                {
                    fileNameSuffix += "_strip";
                    fileNameAppendFrameNumber = true;
                }


                // Progress Data
                int exportedImages = 0;
                prgExport.Value = 1;
                prgExport.Maximum = ImagesPaths.Count + 1;


                // Frame Data
                int frameWidth = (int)numFrameWidth.Value;
                int frameHeight = (int)numFrameHeight.Value;


                for (int currentImageIndex = 0; currentImageIndex < ImagesPaths.Count; currentImageIndex++)
                {
                    Bitmap currentBitmap = (Bitmap)Image.FromFile(ImagesPaths[currentImageIndex]);

                    // Image Data
                    int imageWidth = currentBitmap.Width;
                    int imageHeight = currentBitmap.Height;
                    int columns = (int)Math.Floor(imageWidth / (decimal)frameWidth);
                    int rows = (int)Math.Floor(imageHeight / (decimal)frameHeight);


                    if (columns > 0 && rows > 0)
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            string rowExportPath;
                            Bitmap rowBitmap = new Bitmap(imageWidth, frameHeight);

                            #region Current Frame

                            int frameLast = columns; // used as suffix in GMS2 _stripX
                            for (int column = 0; column < columns; column++)
                            {
                                bool isFrameEmpty = true; // used to determine wether exported image should be resized, when current row has less frames than max
                                for (int x = 0; x < frameWidth; x++)
                                {
                                    for (int y = 0; y < frameHeight; y++)
                                    {
                                        Color currentPixel = currentBitmap.GetPixel(x + column * frameWidth, y + row * frameHeight);
                                        rowBitmap.SetPixel(x + column * frameWidth, y, currentPixel);

                                        if (isFrameEmpty && currentPixel.A > 0) isFrameEmpty = false;
                                    }
                                }

                                // Resize image on current frame empty
                                if (isFrameEmpty)
                                {
                                    Bitmap resizedImage = new Bitmap(column * frameWidth, frameHeight);
                                    using (Graphics g = Graphics.FromImage(resizedImage))
                                    {
                                        g.DrawImage(rowBitmap, 0, 0);
                                    }

                                    rowBitmap = resizedImage;
                                    frameLast = column;
                                    break;
                                }
                            }

                            #endregion

                            #region Current Animation Name

                            // Compute File Export Folder
                            if (fileExportPathFromImage)
                            {
                                rowExportPath = Path.GetDirectoryName(ImagesPaths[currentImageIndex]) + "/";
                            }
                            else rowExportPath = ExportFolder;


                            string imageName;
                            string animationName = row >= animationsCount ? $"Animation{row}" : animationNames[row];

                            // Compute File Name
                            if (fileNameFromImage)
                            {
                                imageName = Path.GetFileNameWithoutExtension(ImagesPaths[currentImageIndex]);
                            }
                            else
                            {
                                if (IsFileNamesEmpty || currentImageIndex >= fileNames.Length) imageName = "img" + currentImageIndex.ToString();
                                else imageName = fileNames[currentImageIndex];
                            }

                            // Add Suffixes
                            rowExportPath += imageName + "_" + animationName + fileNameSuffix;
                            if (fileNameAppendFrameNumber) rowExportPath += frameLast.ToString();

                            #endregion

                            rowBitmap.Save(rowExportPath + ".png");
                            exportedImages++;
                        }
                    }
                    prgExport.Value++;
                }

                if (exportedImages > 0) MessageBox.Show($"{exportedImages} Animations Exported");
                else MessageBox.Show("No Images were exported");

                btnSlice.Enabled = true;
                if(chkExportPathInherit.Checked) btnExportPathSelect.Enabled = true;
                prgExport.Value = 0;
            }

        }




        // --- FORM CONTROLS EVENTS ---
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SelectImages();
        }

        private void btnExportPathSelect_Click(object sender, EventArgs e)
        {
            SelectExportPath();
        }


        private void txtExportPath_TextChanged(object sender, EventArgs e)
        {
            txtExportPath.Select(txtExportPath.Text.Length, 0);
        }


        private void chkExportPathInherit_CheckedChanged(object sender, EventArgs e)
        {
            btnExportPathSelect.Enabled = !chkExportPathInherit.Checked;
        }


        private void btnSlice_Click(object sender, EventArgs e)
        {
            Slice();
        }
    }
}
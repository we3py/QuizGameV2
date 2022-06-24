namespace QuizGame.GUI
{
    public partial class LoadFromFile : Form
    {
        public LoadFromFile()
        {
            InitializeComponent();
        }
        #region Buttons

        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialogChooseFile.ShowDialog();
            labelFileName.Text = openFileDialogChooseFile.FileName;
        }

        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private methods

        private void LoadFile()
        {
            if (openFileDialogChooseFile.FileName != String.Empty)
            {
                var questionToLoad = new ImportQuestionFromCsv().Import(openFileDialogChooseFile.FileName);
                new LoadQuestion().Load(questionToLoad);
                this.Close();
            }
            else
            {
                this.labelFileName.ForeColor = Color.Red;
                this.labelFileName.Text = "Choose file first!";
                labelFileName.Update();
                Thread.Sleep(1000);
                this.labelFileName.ForeColor = Color.Black;
                this.labelFileName.Text = "No file selected to load";
            }
        }

        #endregion
    }
}

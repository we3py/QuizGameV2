using QuizGame.Data.Import;
using QuizGame.GUI.Import;
namespace QuizGame.GUI
{
    public partial class LoadFromFile : Form
    {
        public LoadFromFile()
        {
            InitializeComponent();

        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            var file = openFileDialogChooseFile.ShowDialog();
            labelFileName.Text = openFileDialogChooseFile.FileName;
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}

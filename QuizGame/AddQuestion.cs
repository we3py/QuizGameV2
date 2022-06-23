namespace QuizGame.GUI
{
    public partial class AddQuestion : Form
    {
        private readonly QuestionFactory _questionFactory = new();
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewQuestion()
        {
            if (textBoxQuestion.Text != string.Empty && textBoxAnswerA.Text != string.Empty
                && textBoxAnswerB.Text != string.Empty && textBoxAnswerC.Text != string.Empty
                && textBoxAnswerD.Text != string.Empty && comboBoxCorrectAnswer.SelectedItem != null)
            {
                AssignandSave();
            }
            else
            {
                PointOutEmptyFields();
            }
        }

        private void AssignandSave()
        {
            var query = textBoxQuestion.Text;
            var answerA = textBoxAnswerA.Text;
            var answerB = textBoxAnswerB.Text;
            var answerC = textBoxAnswerC.Text;
            var answerD = textBoxAnswerD.Text;
            string? correctAnswer = comboBoxCorrectAnswer.SelectedItem.ToString();

            string[] answers = { answerA, answerB, answerC, answerD };
            var questionAddToBase = _questionFactory.GetNew(query, correctAnswer!, answers);
            new RepositoryHandler().AddQuestion(questionAddToBase);
            this.Close();
        }
        private void PointOutEmptyFields()
        {
            if (textBoxQuestion.Text?.Length == 0)
            {
                this.labelQuestion.Text = "Empty Question";
                labelQuestion.Update();
            }
            if (textBoxAnswerA.Text?.Length == 0)
            {
                this.labelAnswA.Text = "Empty answer";
                labelAnswA.Update();
            }
            if (textBoxAnswerB.Text?.Length == 0)
            {
                this.labelAnswB.Text = "Empty answer";
                labelAnswB.Update();
            }
            if (textBoxAnswerC.Text?.Length == 0)
            {
                this.labelAnswC.Text = "Empty answer";
                labelAnswC.Update();
            }
            if (textBoxAnswerD.Text?.Length == 0)
            {
                this.labelAnswD.Text = "Empty answer";
                labelAnswD.Update();
            }
            if (comboBoxCorrectAnswer.SelectedItem == null)
            {
                this.labelCorrAnsw.Text = "Choose correct answer";
                labelCorrAnsw.Update();
            }

            Thread.Sleep(1000);
            this.labelQuestion.Text = string.Empty;
            this.labelAnswA.Text = string.Empty;
            this.labelAnswB.Text = string.Empty;
            this.labelAnswC.Text = string.Empty;
            this.labelAnswD.Text = string.Empty;
            this.labelCorrAnsw.Text = string.Empty;
        }
    }
}

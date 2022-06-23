namespace QuizGame.GUI
{
    public partial class ShowListOfQuestions : Form
    {
        public ShowListOfQuestions()
        {
            InitializeComponent();
            RepositoryHandler repository = new();
            var questionList = repository.GetExistingQuestions();
            BindingSource bindingSource = new()
            {
                DataSource = questionList
            };
            listBoxQuestions.DataSource = bindingSource;
            listBoxQuestions.DisplayMember = "Query";
            textBoxAnswer.Text = "Choose question";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string answer = string.Empty;
            if( ((Question)listBoxQuestions.SelectedItem).CorrectAnswer =="A")
            {
                answer = ((Question)listBoxQuestions.SelectedItem).AnswerA;
            }
            if (((Question)listBoxQuestions.SelectedItem).CorrectAnswer == "B")
            {
                answer = ((Question)listBoxQuestions.SelectedItem).AnswerB;
            }
            if (((Question)listBoxQuestions.SelectedItem).CorrectAnswer == "C")
            {
                answer = ((Question)listBoxQuestions.SelectedItem).AnswerC;
            }
            if (((Question)listBoxQuestions.SelectedItem).CorrectAnswer == "D")
            {
                answer = ((Question)listBoxQuestions.SelectedItem).AnswerD;
            }
            textBoxAnswer.Text = answer;
            textBoxAnswer.Update();
        }
    }
}

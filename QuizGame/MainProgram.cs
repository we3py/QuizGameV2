using QuizGame.Data;
using QuizGame.GUI;
using QuizGame.Logic;

namespace QuizGame
{
    public partial class MainProgram : Form
    {
        private IRepositoryHandler _repositoryHandler;
        private IQuizManager _quizManager;
        public MainProgram(IRepositoryHandler repositoryHandler, IQuizManager quizManager)
        {
            _repositoryHandler = repositoryHandler;
            _quizManager = quizManager; 
            InitializeComponent();
        }

        private void DrawQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StartQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _quizManager.SetUpInGameData(_quizManager.QuestionNumber);
            richTextBox1.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .ToString();
            SetAnswersOnButtons();
            _quizManager.IsPlaying = true;
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestion();
            addQuestion.Show();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loadFile = new LoadFromFile();
            loadFile.Show();
        }

        private void showAllQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listOfQuestions = new ShowListOfQuestions();
            listOfQuestions.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonAnwerA_Click(object sender, EventArgs e)
        {
            SetAnswersOnButtons();
            SetAnswerAndGoToNext("A");
        }

        private void buttonAnwerB_Click(object sender, EventArgs e)
        {
            SetAnswersOnButtons();
            SetAnswerAndGoToNext("B");
        }

        private void buttonAnwerC_Click(object sender, EventArgs e)
        {
            SetAnswersOnButtons();
            SetAnswerAndGoToNext("C");
        }

        private void buttonAnwerD_Click(object sender, EventArgs e)
        {
            SetAnswersOnButtons();
            SetAnswerAndGoToNext("D");
        }

        private void SetAnswerAndGoToNext(string answer)
        {
            if (!_quizManager.IsPlaying)
            {
                buttonEndQuiz.Visible = true;
                MessageBox.Show("No more questions. Press End Quiz button");
                return;
            }

            _quizManager.SetUpAnswer(answer);
            richTextBox1.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .ToString();
        }

        private void SetAnswersOnButtons()
        {
            buttonAnwerA.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerA;

            buttonAnwerB.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerB;

            buttonAnwerC.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerC;

            buttonAnwerD.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerD;
        }

        public void SetDefaultValuesInMainProgram()
        {
            buttonAnwerA.Text = "A";
            buttonAnwerB.Text = "B";
            buttonAnwerC.Text = "C";
            buttonAnwerD.Text = "D";

            richTextBox1.Text = String.Empty;
            buttonEndQuiz.Visible = false;
        }

        private void buttonEndQuiz_Click(object sender, EventArgs e)
        {
            var addScore = new AddToScoreList(_quizManager, _repositoryHandler, this);
            addScore.Show();
        }

        private void viewHighscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showHighScores = new ShowHighScoreList();
            showHighScores.Show();
        }

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
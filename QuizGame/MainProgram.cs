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

        }

        private void buttonAnwerB_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnwerC_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnwerD_Click(object sender, EventArgs e)
        {

        }

        private void buttonEndQuiz_Click(object sender, EventArgs e)
        {
            var addScore = new AddToScoreList();
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
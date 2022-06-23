using QuizGame.Data;
using QuizGame.GUI;
using QuizGame.Logic;

namespace QuizGame
{
    public partial class MainProgram : Form
    {
        private IRepositoryHandler _repositoryHandler;
        private IQuizManager _quizManager;
        private List<Button> _answerButtons = new List<Button>();
        public MainProgram(IRepositoryHandler repositoryHandler, IQuizManager quizManager)
        {
            _repositoryHandler = repositoryHandler;
            _quizManager = quizManager;
            InitializeComponent();
        }

        #region Menu
        private void DrawQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartQuiz(1);
        }

        private void StartQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartQuiz(_quizManager.QuestionNumber);
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

        private void viewHighscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showHighScores = new ShowHighScoreList();
            showHighScores.Show();
        }
        #endregion

        #region Answer Buttons
        private void buttonAnwerA_Click(object sender, EventArgs e)
        {
            SetAnswerAndGoToNext("A");
            if (!_quizManager.IsPlaying) { return; }
            SetAnswersOnButtons();
            SetButtonsColorToDefault();
        }

        private void buttonAnwerB_Click(object sender, EventArgs e)
        {
            SetAnswerAndGoToNext("B");
            if (!_quizManager.IsPlaying) { return; }
            SetAnswersOnButtons();
            ShowAnswerResult(buttonAnwerB);
            SetButtonsColorToDefault();
        }

        private void buttonAnwerC_Click(object sender, EventArgs e)
        {
            SetAnswerAndGoToNext("C");
            if (!_quizManager.IsPlaying) { return; }
            SetAnswersOnButtons();
            ShowAnswerResult(buttonAnwerC);
            SetButtonsColorToDefault();
        }

        private void buttonAnwerD_Click(object sender, EventArgs e)
        {
            SetAnswerAndGoToNext("D");
            if (!_quizManager.IsPlaying) { return; }
            SetAnswersOnButtons();
            ShowAnswerResult(buttonAnwerD);
            SetButtonsColorToDefault();
        }
        #endregion

        #region Buttons
        private void buttonEndQuiz_Click(object sender, EventArgs e)
        {
            var addScore = new AddToScoreList(_quizManager, _repositoryHandler, this);
            addScore.Show();
        }

        #endregion
       
        #region Private methods

        private void StartQuiz(int questionNumber)
        {
            _quizManager.SetUpInGameData(questionNumber);
            richTextBox1.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .ToString();
            SetAnswersOnButtons();
            _quizManager.IsPlaying = true;
        }

        private void SetAnswerAndGoToNext(string answer)
        {
            _quizManager.SetUpAnswer(answer);
            richTextBox1.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .ToString();

            if (!_quizManager.IsPlaying)
            {
                if(_quizManager.InGameQuestions.Count == 1)
                {                    
                    MessageBox.Show("Correct answer is: " + _quizManager.InGameQuestions[0].CorrectAnswer);                    
                    SetDefaultValuesInMainProgram();
                    return;
                }

                buttonEndQuiz.Visible = true;
                MessageBox.Show("No more questions. Press End Quiz button");
                return;
            }          
        }

        private void SetAnswersOnButtons()
        {
            _answerButtons.Clear();

            buttonAnwerA.Text = "A: " + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerA;

            buttonAnwerB.Text = "B: " + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerB;

            buttonAnwerC.Text = "C: " + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerC;

            buttonAnwerD.Text = "D: " + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerD;

            _answerButtons.Add(buttonAnwerA);
            _answerButtons.Add(buttonAnwerB);
            _answerButtons.Add(buttonAnwerC);
            _answerButtons.Add(buttonAnwerD);
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

        private void ShowAnswerResult(Button pressedButton)
        {
            bool condition = IsButtonAnswerCorrect(pressedButton);

            if (condition)
            {
                pressedButton.BackColor = Color.Green;
            }
            else
            {
                pressedButton.BackColor = Color.Red;
                foreach (var button in _answerButtons)
                {
                    if (IsButtonAnswerCorrect(button)) { button.BackColor = Color.Green; }
                }
            }
        }

        private void SetButtonsColorToDefault()
        {
            Thread.Sleep(1000);
            foreach (var button in _answerButtons) { button.UseVisualStyleBackColor = true; }
        }

        private bool IsButtonAnswerCorrect(Button button)
        {
            return button.Text[0].ToString()
                == _quizManager.InGameQuestions[_quizManager.AnswerCount].CorrectAnswer;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }
    }
}
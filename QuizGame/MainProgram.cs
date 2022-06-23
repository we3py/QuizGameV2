using QuizGame.Data;
using QuizGame.GUI;
using QuizGame.Logic;

namespace QuizGame
{
    public partial class MainProgram : Form
    {
        private readonly IRepositoryHandler _repositoryHandler;
        private readonly IQuizManager _quizManager;
        private readonly List<Button> _answerButtons = new();
        private readonly int _oneQuestion = 1;
        private int _questionAmmount;
        public MainProgram(IRepositoryHandler repositoryHandler, IQuizManager quizManager)
        {
            _repositoryHandler = repositoryHandler;
            _quizManager = quizManager;
            InitializeComponent();
        }

        #region Menu
        private void DrawQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_repositoryHandler.GetExistingQuestions().Count > 0)
            {
                _questionAmmount = _oneQuestion;
                StartQuiz(_questionAmmount);
                ShowQuizLayout();
            }
            else
            {
                MessageBox.Show("No questions in database!\nAdd at least one question.");
            }
        }


        private void StartQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_repositoryHandler.GetExistingQuestions().Count >= _quizManager.QuestionNumber)
            {
                _questionAmmount = _quizManager.QuestionNumber;
                StartQuiz(_questionAmmount);
                ShowQuizLayout();
            }
            else
            {
                MessageBox.Show("Not enough questions in database!\nAdd more questions.");
            }
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestion();
            addQuestion.Show();
        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loadFile = new LoadFromFile();
            loadFile.Show();
        }

        private void ShowAllQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listOfQuestions = new ShowListOfQuestions();
            listOfQuestions.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewHighscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showHighScores = new ShowHighScoreList();
            showHighScores.Show();
        }
        #endregion

        #region Answer Buttons
        private void ButtonAnwerA_Click(object sender, EventArgs e)
        {
            if (!_quizManager.IsPlaying)
            {
                ShowMessage();
                return;
            }
            SetAnswerAndGoToNext("A");
            ShowAnswerResult(buttonAnwerA);
            SetAnswersOnButtons();
            SetButtonsColorToDefault();
        }

        private void ButtonAnwerB_Click(object sender, EventArgs e)
        {
            if (!_quizManager.IsPlaying)
            {
                ShowMessage();
                return;
            }
            SetAnswerAndGoToNext("B");
            ShowAnswerResult(buttonAnwerB);
            SetAnswersOnButtons();
            SetButtonsColorToDefault();
        }

        private void ButtonAnwerC_Click(object sender, EventArgs e)
        {
            if (!_quizManager.IsPlaying)
            {
                ShowMessage();
                return;
            }
            SetAnswerAndGoToNext("C");
            ShowAnswerResult(buttonAnwerC);
            SetAnswersOnButtons();
            SetButtonsColorToDefault();
        }

        private void ButtonAnwerD_Click(object sender, EventArgs e)
        {
            if (!_quizManager.IsPlaying)
            {
                ShowMessage();
                return;
            }
            SetAnswerAndGoToNext("D");
            ShowAnswerResult(buttonAnwerD);
            SetAnswersOnButtons();
            SetButtonsColorToDefault();
        }
        private void ShowMessage()
        {
            MessageBox.Show("You finished your quiz.\nClick End Quiz to show your score!");
        }
        #endregion

        #region Buttons
        private void ButtonEndQuiz_Click(object sender, EventArgs e)
        {
            var addScore = new AddToScoreList(_quizManager, _repositoryHandler, this);
            addScore.Show();
            HideQuizLayout();
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

            if (_quizManager.InGameQuestions.Count == 1)
            {
                return;
            }
            if (!_quizManager.IsPlaying)
            {
                buttonEndQuiz.Visible = true;
                return;
            }

            richTextBox1.Text = _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .ToString();
        }

        private void SetAnswersOnButtons()
        {
            _answerButtons.Clear();

            buttonAnwerA.Text = "A:\n" + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerA;

            buttonAnwerB.Text = "B:\n " + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerB;

            buttonAnwerC.Text = "C:\n" + _quizManager
                .InGameQuestions[_quizManager.AnswerCount]
                .AnswerC;

            buttonAnwerD.Text = "D:\n" + _quizManager
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
                pressedButton.Update();
            }
            else
            {
                pressedButton.BackColor = Color.Red;
                pressedButton.Update();
                foreach (var button in _answerButtons)
                {
                    if (IsButtonAnswerCorrect(button)) { button.BackColor = Color.Green; button.Update(); }
                }
            }
        }

        private void SetButtonsColorToDefault()
        {
            Thread.Sleep(1000);
            foreach (var button in _answerButtons) { button.UseVisualStyleBackColor = true; }
            if (_questionAmmount == 1)
            {
                Thread.Sleep(2000);
                HideQuizLayout();
            }
        }


        private bool IsButtonAnswerCorrect(Button button)
        {
            if (_quizManager.InGameQuestions.Count == 1)
            {
                return button.Text[0].ToString()
                == _quizManager.InGameQuestions[_quizManager.AnswerCount].CorrectAnswer;
            }

            return button.Text[0].ToString()
                == _quizManager.InGameQuestions[_quizManager.AnswerCount - 1].CorrectAnswer;
        }
        #endregion

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Credits credits = new();
            credits.Show();
        }
        private void ShowQuizLayout()
        {
            richTextBox1.Visible = true;
            buttonAnwerA.Visible = true;
            buttonAnwerB.Visible = true;
            buttonAnwerC.Visible = true;
            buttonAnwerD.Visible = true;
        }
        private void HideQuizLayout()
        {
            buttonEndQuiz.Visible = false;
            richTextBox1.Visible = false;
            buttonAnwerA.Visible = false;
            buttonAnwerB.Visible = false;
            buttonAnwerC.Visible = false;
            buttonAnwerD.Visible = false;
        }
    }
}
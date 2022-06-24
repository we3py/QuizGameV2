namespace QuizGame.GUI
{
    public partial class AddToScoreList : Form
    {
        private readonly IQuizManager _quizManager;
        private readonly IRepositoryHandler _repositoryHandler;
        private readonly MainProgram _mainProgram;
        public AddToScoreList(IQuizManager quizManager, IRepositoryHandler repositoryHandler, MainProgram mainProgram)
        {
            _quizManager = quizManager;
            _repositoryHandler = repositoryHandler;
            _mainProgram = mainProgram;
            InitializeComponent();
            _quizManager.CalculateHighscore();
            labelScore.Text = _quizManager.Highscore.ToString();
            using var soundPlayer = new SoundPlayer("Fanfary.wav");
            soundPlayer.Play();
        }

        private void ButtonAddScore_Click(object sender, EventArgs e)
        {
            AddToHighScoreList();
            _mainProgram.SetDefaultValuesInMainProgram();
        }

        private void AddToHighScoreList()
        {
            if (textBoxUserName.Text != string.Empty)
            {
                _repositoryHandler.AddHighscore(textBoxUserName.Text, _quizManager.Highscore);
                this.Close();
            }
            else
            {
                if (textBoxUserName.Text?.Length == 0)
                {
                    this.labelEmptyName.Text = "Empty Name";
                    labelEmptyName.Update();
                    Thread.Sleep(1000);
                    this.labelEmptyName.Text = string.Empty;
                }
            }
        }
    }
}

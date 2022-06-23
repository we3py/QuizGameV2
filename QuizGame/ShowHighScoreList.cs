using QuizGame.Data;

namespace QuizGame.GUI
{
    public partial class ShowHighScoreList : Form
    {
        public ShowHighScoreList()
        {
            InitializeComponent();
            RepositoryHandler repository = new();
            var highScoreList = repository.GetHighscores();
            BindingSource bindingSource = new()
            {
                DataSource = highScoreList
            };
            listBoxHighScores.DataSource = bindingSource;
            listBoxScores.DataSource = bindingSource;
            listBoxHighScores.DisplayMember = "UserName";
            listBoxScores.DisplayMember = "Score";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using QuizGame.Data;
using QuizGame.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.GUI
{
    public partial class AddToScoreList : Form
    {
        private IQuizManager _quizManager;
        private IRepositoryHandler _repositoryHandler;
        public AddToScoreList(IQuizManager quizManager, IRepositoryHandler repositoryHandler)
        {
            _quizManager = quizManager;
            _repositoryHandler = repositoryHandler;
            InitializeComponent();
            _quizManager.CalculateHighscore();
            labelScore.Text = _quizManager.Highscore.ToString();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            AddToHighScoreList();
        }

        private void AddToHighScoreList()
        {
            if (textBoxUserName.Text != string.Empty)
            {
                _repositoryHandler.AddHighscore(textBoxUserName.Text, _quizManager.Highscore);
                _quizManager.ClearInGameData();
                this.Close();
            }
            else
            {
                if (textBoxUserName.Text == string.Empty)
                {
                    this.labelEmptyName.Text = "Empty Name";
                    labelEmptyName.Update();
                    Thread.Sleep(1000);
                    this.labelEmptyName.Text = string.Empty;
                }
            }
        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }
    }
}

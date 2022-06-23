using QuizGame.Data;
using QuizGame.Data.Factories;
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
        private MainProgram _mainProgram;
        public AddToScoreList(IQuizManager quizManager, IRepositoryHandler repositoryHandler, MainProgram mainProgram)
        {
            _quizManager = quizManager;
            _repositoryHandler = repositoryHandler;
            _mainProgram = mainProgram;
            InitializeComponent();
            _quizManager.CalculateHighscore();
            labelScore.Text = _quizManager.Highscore.ToString();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
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

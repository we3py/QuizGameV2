using QuizGame.Data;
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
    public partial class ShowHighScoreList : Form
    {
        public ShowHighScoreList()
        {
            InitializeComponent();
            RepositoryHandler repository = new();
            var highScoreList = repository.GetHighscores();
            BindingSource bindingSource = new();
            bindingSource.DataSource = highScoreList;
            listBoxHighScores.DataSource = bindingSource;
            listBoxHighScores.DisplayMember = "UserName";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

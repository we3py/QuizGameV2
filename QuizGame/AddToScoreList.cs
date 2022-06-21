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
        public AddToScoreList(int score)
        {
            InitializeComponent();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            AddToHighScoreList();
        }

        private void AddToHighScoreList()
        {
            if (textBoxUserName.Text != string.Empty)
            {
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
    }
}

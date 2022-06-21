using QuizGame.Data;
using QuizGame.Data.DAL;
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
    public partial class AddQuestion : Form
    {
        private QuestionFactory _questionFactory = new();

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewQuestion()
        {
            if (textBoxQuestion.Text != string.Empty && textBoxAnswerA.Text != string.Empty
                && textBoxAnswerB.Text != string.Empty && textBoxAnswerC.Text != string.Empty
                && textBoxAnswerD.Text != string.Empty && comboBoxCorrectAnswer.SelectedItem != null) 
            {
                var query = textBoxQuestion.Text;
                var answerA = textBoxAnswerA.Text;
                var answerB = textBoxAnswerB.Text;
                var answerC = textBoxAnswerC.Text;
                var answerD = textBoxAnswerD.Text;
                var correctAnswer = comboBoxCorrectAnswer.SelectedItem.ToString();

                string[] answers = { answerA, answerB, answerC, answerD };
                var questionAddToBase = _questionFactory.GetNew(query, correctAnswer, answers);
                new DataManage().AddQuestion(questionAddToBase);
                this.Close();
            }
            else
            {
                if (textBoxQuestion.Text == string.Empty)
                {
                    this.labelQuestion.Text = "Empty Question";
                    labelQuestion.Update();
                }
                if (textBoxAnswerA.Text == string.Empty)
                {
                    this.labelAnswA.Text = "Empty answer";
                    labelAnswA.Update();
                }
                if (textBoxAnswerB.Text == string.Empty)
                {
                    this.labelAnswB.Text = "Empty answer";
                    labelAnswB.Update();
                }
                if (textBoxAnswerC.Text == string.Empty)
                {
                    this.labelAnswC.Text = "Empty answer";
                    labelAnswC.Update();
                }
                if (textBoxAnswerD.Text == string.Empty)
                {
                    this.labelAnswD.Text = "Empty answer";
                    labelAnswD.Update();
                }
                if (comboBoxCorrectAnswer.SelectedItem == null)
                {
                    this.labelCorrAnsw.Text = "Choose correct answer";
                    labelCorrAnsw.Update();
                }

                Thread.Sleep(1000);
                this.labelQuestion.Text = string.Empty;
                this.labelAnswA.Text = string.Empty;
                this.labelAnswB.Text = string.Empty;
                this.labelAnswC.Text = string.Empty;
                this.labelAnswD.Text = string.Empty;
                this.labelCorrAnsw.Text = string.Empty;
            }
        }
    }
}

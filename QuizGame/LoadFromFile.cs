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
    public partial class LoadFromFile : Form
    {
        public LoadFromFile()
        {
            InitializeComponent();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            var file = openFileDialogChooseFile.ShowDialog();
            labelFileName.Text = openFileDialogChooseFile.FileName;
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFile()
        {
            if (openFileDialogChooseFile.FileName != String.Empty)
            {
                this.Close();
            }
            else
            {
                this.labelFileName.ForeColor = Color.Red;
                this.labelFileName.Text = "Choose file first!";
                labelFileName.Update();
                Thread.Sleep(1000);
                this.labelFileName.ForeColor = Color.Black;
                this.labelFileName.Text = "No file selected to load";
            }
        }
    }
}

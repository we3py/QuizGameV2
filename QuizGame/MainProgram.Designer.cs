namespace QuizGame
{
    partial class MainProgram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHighscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAnwerA = new System.Windows.Forms.Button();
            this.buttonAnwerB = new System.Windows.Forms.Button();
            this.buttonAnwerC = new System.Windows.Forms.Button();
            this.buttonAnwerD = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonEndQuiz = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.viewHighscoresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawQuestionToolStripMenuItem,
            this.StartQuizToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // DrawQuestionToolStripMenuItem
            // 
            this.DrawQuestionToolStripMenuItem.Name = "DrawQuestionToolStripMenuItem";
            this.DrawQuestionToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.DrawQuestionToolStripMenuItem.Text = "Draw question";
            this.DrawQuestionToolStripMenuItem.Click += new System.EventHandler(this.DrawQuestionToolStripMenuItem_Click);
            // 
            // StartQuizToolStripMenuItem
            // 
            this.StartQuizToolStripMenuItem.Name = "StartQuizToolStripMenuItem";
            this.StartQuizToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.StartQuizToolStripMenuItem.Text = "Start quiz";
            this.StartQuizToolStripMenuItem.Click += new System.EventHandler(this.StartQuizToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddQuestionToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.showAllQuestionsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // AddQuestionToolStripMenuItem
            // 
            this.AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            this.AddQuestionToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.AddQuestionToolStripMenuItem.Text = "Add question";
            this.AddQuestionToolStripMenuItem.Click += new System.EventHandler(this.AddQuestionToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.loadFileToolStripMenuItem.Text = "Load file";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // showAllQuestionsToolStripMenuItem
            // 
            this.showAllQuestionsToolStripMenuItem.Name = "showAllQuestionsToolStripMenuItem";
            this.showAllQuestionsToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.showAllQuestionsToolStripMenuItem.Text = "Show all questions";
            this.showAllQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ShowAllQuestionsToolStripMenuItem_Click);
            // 
            // viewHighscoresToolStripMenuItem
            // 
            this.viewHighscoresToolStripMenuItem.Name = "viewHighscoresToolStripMenuItem";
            this.viewHighscoresToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.viewHighscoresToolStripMenuItem.Text = "View highscores";
            this.viewHighscoresToolStripMenuItem.Click += new System.EventHandler(this.ViewHighscoresToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // buttonAnwerA
            // 
            this.buttonAnwerA.Location = new System.Drawing.Point(31, 247);
            this.buttonAnwerA.Name = "buttonAnwerA";
            this.buttonAnwerA.Size = new System.Drawing.Size(490, 196);
            this.buttonAnwerA.TabIndex = 1;
            this.buttonAnwerA.Text = "A";
            this.buttonAnwerA.UseVisualStyleBackColor = true;
            this.buttonAnwerA.Visible = false;
            this.buttonAnwerA.Click += new System.EventHandler(this.ButtonAnwerA_Click);
            // 
            // buttonAnwerB
            // 
            this.buttonAnwerB.Location = new System.Drawing.Point(531, 247);
            this.buttonAnwerB.Name = "buttonAnwerB";
            this.buttonAnwerB.Size = new System.Drawing.Size(490, 196);
            this.buttonAnwerB.TabIndex = 2;
            this.buttonAnwerB.Text = "B";
            this.buttonAnwerB.UseVisualStyleBackColor = true;
            this.buttonAnwerB.Visible = false;
            this.buttonAnwerB.Click += new System.EventHandler(this.ButtonAnwerB_Click);
            // 
            // buttonAnwerC
            // 
            this.buttonAnwerC.Location = new System.Drawing.Point(31, 456);
            this.buttonAnwerC.Name = "buttonAnwerC";
            this.buttonAnwerC.Size = new System.Drawing.Size(490, 196);
            this.buttonAnwerC.TabIndex = 3;
            this.buttonAnwerC.Text = "C";
            this.buttonAnwerC.UseVisualStyleBackColor = true;
            this.buttonAnwerC.Visible = false;
            this.buttonAnwerC.Click += new System.EventHandler(this.ButtonAnwerC_Click);
            // 
            // buttonAnwerD
            // 
            this.buttonAnwerD.Location = new System.Drawing.Point(531, 456);
            this.buttonAnwerD.Name = "buttonAnwerD";
            this.buttonAnwerD.Size = new System.Drawing.Size(490, 196);
            this.buttonAnwerD.TabIndex = 4;
            this.buttonAnwerD.Text = "D";
            this.buttonAnwerD.UseVisualStyleBackColor = true;
            this.buttonAnwerD.Visible = false;
            this.buttonAnwerD.Click += new System.EventHandler(this.ButtonAnwerD_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(990, 90);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // buttonEndQuiz
            // 
            this.buttonEndQuiz.Location = new System.Drawing.Point(928, 678);
            this.buttonEndQuiz.Name = "buttonEndQuiz";
            this.buttonEndQuiz.Size = new System.Drawing.Size(93, 30);
            this.buttonEndQuiz.TabIndex = 6;
            this.buttonEndQuiz.Text = "End quiz";
            this.buttonEndQuiz.UseVisualStyleBackColor = true;
            this.buttonEndQuiz.Visible = false;
            this.buttonEndQuiz.Click += new System.EventHandler(this.ButtonEndQuiz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(840, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(31, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(803, 29);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 733);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEndQuiz);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAnwerD);
            this.Controls.Add(this.buttonAnwerC);
            this.Controls.Add(this.buttonAnwerB);
            this.Controls.Add(this.buttonAnwerA);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1070, 780);
            this.MinimumSize = new System.Drawing.Size(1070, 780);
            this.Name = "MainProgram";
            this.Text = "Quiz Game by The Riddlers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem DrawQuestionToolStripMenuItem;
        private ToolStripMenuItem StartQuizToolStripMenuItem;
        private ToolStripMenuItem AddQuestionToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem showAllQuestionsToolStripMenuItem;
        private Button buttonAnwerA;
        private Button buttonAnwerB;
        private Button buttonAnwerC;
        private Button buttonAnwerD;
        private RichTextBox richTextBox1;
        private Button buttonEndQuiz;
        private ToolStripMenuItem viewHighscoresToolStripMenuItem;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}
namespace QuizGame.GUI
{
    partial class AddToScoreList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.labelEmptyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your score: ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point(151, 49);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(17, 20);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "0";
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(151, 81);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(214, 27);
            this.textBoxUserName.TabIndex = 3;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Location = new System.Drawing.Point(25, 134);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(340, 29);
            this.buttonAddScore.TabIndex = 4;
            this.buttonAddScore.Text = "Save score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // labelEmptyName
            // 
            this.labelEmptyName.AutoSize = true;
            this.labelEmptyName.BackColor = System.Drawing.Color.White;
            this.labelEmptyName.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyName.Location = new System.Drawing.Point(160, 84);
            this.labelEmptyName.Name = "labelEmptyName";
            this.labelEmptyName.Size = new System.Drawing.Size(0, 20);
            this.labelEmptyName.TabIndex = 5;
            // 
            // AddToScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 185);
            this.Controls.Add(this.labelEmptyName);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Name = "AddToScoreList";
            this.Text = "Save your score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelScore;
        private Label label3;
        private TextBox textBoxUserName;
        private Button buttonAddScore;
        private Label labelEmptyName;
    }
}
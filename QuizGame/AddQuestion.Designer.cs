namespace QuizGame.GUI
{
    partial class AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnswerA = new System.Windows.Forms.TextBox();
            this.textBoxAnswerB = new System.Windows.Forms.TextBox();
            this.textBoxAnswerC = new System.Windows.Forms.TextBox();
            this.textBoxAnswerD = new System.Windows.Forms.TextBox();
            this.comboBoxCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswA = new System.Windows.Forms.Label();
            this.labelAnswB = new System.Windows.Forms.Label();
            this.labelAnswC = new System.Windows.Forms.Label();
            this.labelAnswD = new System.Windows.Forms.Label();
            this.labelCorrAnsw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(106, 28);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(291, 27);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Answer C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Answer D:";
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.Location = new System.Drawing.Point(106, 69);
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.Size = new System.Drawing.Size(291, 27);
            this.textBoxAnswerA.TabIndex = 6;
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.Location = new System.Drawing.Point(106, 101);
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.Size = new System.Drawing.Size(291, 27);
            this.textBoxAnswerB.TabIndex = 7;
            // 
            // textBoxAnswerC
            // 
            this.textBoxAnswerC.Location = new System.Drawing.Point(106, 134);
            this.textBoxAnswerC.Name = "textBoxAnswerC";
            this.textBoxAnswerC.Size = new System.Drawing.Size(291, 27);
            this.textBoxAnswerC.TabIndex = 8;
            // 
            // textBoxAnswerD
            // 
            this.textBoxAnswerD.Location = new System.Drawing.Point(106, 167);
            this.textBoxAnswerD.Name = "textBoxAnswerD";
            this.textBoxAnswerD.Size = new System.Drawing.Size(291, 27);
            this.textBoxAnswerD.TabIndex = 9;
            // 
            // comboBoxCorrectAnswer
            // 
            this.comboBoxCorrectAnswer.FormattingEnabled = true;
            this.comboBoxCorrectAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxCorrectAnswer.Location = new System.Drawing.Point(143, 200);
            this.comboBoxCorrectAnswer.Name = "comboBoxCorrectAnswer";
            this.comboBoxCorrectAnswer.Size = new System.Drawing.Size(59, 28);
            this.comboBoxCorrectAnswer.TabIndex = 10;
            this.comboBoxCorrectAnswer.Text = "Pick";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correct answer:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(203, 234);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(303, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.White;
            this.labelQuestion.ForeColor = System.Drawing.Color.Red;
            this.labelQuestion.Location = new System.Drawing.Point(116, 31);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 20);
            this.labelQuestion.TabIndex = 14;
            // 
            // labelAnswA
            // 
            this.labelAnswA.AutoSize = true;
            this.labelAnswA.BackColor = System.Drawing.Color.White;
            this.labelAnswA.ForeColor = System.Drawing.Color.Red;
            this.labelAnswA.Location = new System.Drawing.Point(116, 72);
            this.labelAnswA.Name = "labelAnswA";
            this.labelAnswA.Size = new System.Drawing.Size(0, 20);
            this.labelAnswA.TabIndex = 15;
            // 
            // labelAnswB
            // 
            this.labelAnswB.AutoSize = true;
            this.labelAnswB.BackColor = System.Drawing.Color.White;
            this.labelAnswB.ForeColor = System.Drawing.Color.Red;
            this.labelAnswB.Location = new System.Drawing.Point(116, 104);
            this.labelAnswB.Name = "labelAnswB";
            this.labelAnswB.Size = new System.Drawing.Size(0, 20);
            this.labelAnswB.TabIndex = 16;
            // 
            // labelAnswC
            // 
            this.labelAnswC.AutoSize = true;
            this.labelAnswC.BackColor = System.Drawing.Color.White;
            this.labelAnswC.ForeColor = System.Drawing.Color.Red;
            this.labelAnswC.Location = new System.Drawing.Point(116, 137);
            this.labelAnswC.Name = "labelAnswC";
            this.labelAnswC.Size = new System.Drawing.Size(0, 20);
            this.labelAnswC.TabIndex = 17;
            // 
            // labelAnswD
            // 
            this.labelAnswD.AutoSize = true;
            this.labelAnswD.BackColor = System.Drawing.Color.White;
            this.labelAnswD.ForeColor = System.Drawing.Color.Red;
            this.labelAnswD.Location = new System.Drawing.Point(116, 170);
            this.labelAnswD.Name = "labelAnswD";
            this.labelAnswD.Size = new System.Drawing.Size(0, 20);
            this.labelAnswD.TabIndex = 18;
            // 
            // labelCorrAnsw
            // 
            this.labelCorrAnsw.AutoSize = true;
            this.labelCorrAnsw.ForeColor = System.Drawing.Color.Red;
            this.labelCorrAnsw.Location = new System.Drawing.Point(208, 203);
            this.labelCorrAnsw.Name = "labelCorrAnsw";
            this.labelCorrAnsw.Size = new System.Drawing.Size(0, 20);
            this.labelCorrAnsw.TabIndex = 19;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 287);
            this.Controls.Add(this.labelCorrAnsw);
            this.Controls.Add(this.labelAnswD);
            this.Controls.Add(this.labelAnswC);
            this.Controls.Add(this.labelAnswB);
            this.Controls.Add(this.labelAnswA);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCorrectAnswer);
            this.Controls.Add(this.textBoxAnswerD);
            this.Controls.Add(this.textBoxAnswerC);
            this.Controls.Add(this.textBoxAnswerB);
            this.Controls.Add(this.textBoxAnswerA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuestion";
            this.Text = "Add question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxQuestion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAnswerA;
        private TextBox textBoxAnswerB;
        private TextBox textBoxAnswerC;
        private TextBox textBoxAnswerD;
        private ComboBox comboBoxCorrectAnswer;
        private Label label6;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelQuestion;
        private Label labelAnswA;
        private Label labelAnswB;
        private Label labelAnswC;
        private Label labelAnswD;
        private Label labelCorrAnsw;
    }
}
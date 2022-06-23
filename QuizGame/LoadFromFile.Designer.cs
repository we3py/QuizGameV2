namespace QuizGame.GUI
{
    partial class LoadFromFile
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
            this.openFileDialogChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(213, 12);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(94, 29);
            this.buttonChooseFile.TabIndex = 0;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(165, 93);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(94, 29);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "Load data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 54);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(165, 20);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "No file selected to load";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(265, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LoadFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 134);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonChooseFile);
            this.Name = "LoadFromFile";
            this.Text = "Load From File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialogChooseFile;
        private Button buttonChooseFile;
        private Button buttonLoadData;
        private Label labelFileName;
        private Button buttonCancel;
    }
}
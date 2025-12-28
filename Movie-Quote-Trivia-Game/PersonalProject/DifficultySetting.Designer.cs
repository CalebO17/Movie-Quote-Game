namespace PersonalProject
{
    partial class DifficultySetting
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
            chooseDifficultyLbl = new Label();
            easyBtn = new Button();
            hardBtn = new Button();
            mediumBtn = new Button();
            SuspendLayout();
            // 
            // chooseDifficultyLbl
            // 
            chooseDifficultyLbl.AutoSize = true;
            chooseDifficultyLbl.BackColor = Color.DarkTurquoise;
            chooseDifficultyLbl.BorderStyle = BorderStyle.FixedSingle;
            chooseDifficultyLbl.Enabled = false;
            chooseDifficultyLbl.FlatStyle = FlatStyle.Popup;
            chooseDifficultyLbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseDifficultyLbl.Location = new Point(528, 68);
            chooseDifficultyLbl.Name = "chooseDifficultyLbl";
            chooseDifficultyLbl.Size = new Size(479, 46);
            chooseDifficultyLbl.TabIndex = 38;
            chooseDifficultyLbl.Text = "Choose your difficulty!";
            // 
            // easyBtn
            // 
            easyBtn.BackgroundImageLayout = ImageLayout.Stretch;
            easyBtn.FlatAppearance.BorderColor = Color.Black;
            easyBtn.FlatAppearance.BorderSize = 5;
            easyBtn.FlatStyle = FlatStyle.Flat;
            easyBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            easyBtn.Location = new Point(573, 180);
            easyBtn.Name = "easyBtn";
            easyBtn.Size = new Size(375, 99);
            easyBtn.TabIndex = 37;
            easyBtn.Text = "Easy";
            easyBtn.UseVisualStyleBackColor = true;
            easyBtn.Click += DifficultyBtn_Click;
            // 
            // hardBtn
            // 
            hardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            hardBtn.FlatAppearance.BorderColor = Color.Black;
            hardBtn.FlatAppearance.BorderSize = 5;
            hardBtn.FlatStyle = FlatStyle.Flat;
            hardBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hardBtn.Location = new Point(573, 616);
            hardBtn.Name = "hardBtn";
            hardBtn.Size = new Size(375, 99);
            hardBtn.TabIndex = 39;
            hardBtn.Text = "Hard";
            hardBtn.UseVisualStyleBackColor = true;
            hardBtn.Click += DifficultyBtn_Click;
            // 
            // mediumBtn
            // 
            mediumBtn.BackgroundImageLayout = ImageLayout.Stretch;
            mediumBtn.FlatAppearance.BorderColor = Color.Black;
            mediumBtn.FlatAppearance.BorderSize = 5;
            mediumBtn.FlatStyle = FlatStyle.Flat;
            mediumBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediumBtn.Location = new Point(573, 398);
            mediumBtn.Name = "mediumBtn";
            mediumBtn.Size = new Size(375, 99);
            mediumBtn.TabIndex = 40;
            mediumBtn.Text = "Medium";
            mediumBtn.UseVisualStyleBackColor = true;
            mediumBtn.Click += DifficultyBtn_Click;
            // 
            // DifficultySetting
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1577, 879);
            Controls.Add(mediumBtn);
            Controls.Add(hardBtn);
            Controls.Add(chooseDifficultyLbl);
            Controls.Add(easyBtn);
            Name = "DifficultySetting";
            Text = "DifficultySetting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseDifficultyLbl;
        private Button easyBtn;
        private Button hardBtn;
        private Button mediumBtn;
    }
}
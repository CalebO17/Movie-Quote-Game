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
            easyBtn = new Button();
            hardBtn = new Button();
            mediumBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            chooseDifficultyLbl = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // easyBtn
            // 
            easyBtn.Anchor = AnchorStyles.Bottom;
            easyBtn.BackgroundImageLayout = ImageLayout.Stretch;
            easyBtn.FlatAppearance.BorderColor = Color.Black;
            easyBtn.FlatAppearance.BorderSize = 5;
            easyBtn.FlatStyle = FlatStyle.Flat;
            easyBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            easyBtn.Location = new Point(601, 267);
            easyBtn.Name = "easyBtn";
            easyBtn.Size = new Size(375, 99);
            easyBtn.TabIndex = 37;
            easyBtn.Text = "Easy";
            easyBtn.UseVisualStyleBackColor = true;
            easyBtn.Click += DifficultyBtn_Click;
            // 
            // hardBtn
            // 
            hardBtn.Anchor = AnchorStyles.Bottom;
            hardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            hardBtn.FlatAppearance.BorderColor = Color.Black;
            hardBtn.FlatAppearance.BorderSize = 5;
            hardBtn.FlatStyle = FlatStyle.Flat;
            hardBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hardBtn.Location = new Point(601, 637);
            hardBtn.Name = "hardBtn";
            hardBtn.Size = new Size(375, 99);
            hardBtn.TabIndex = 39;
            hardBtn.Text = "Hard";
            hardBtn.UseVisualStyleBackColor = true;
            hardBtn.Click += DifficultyBtn_Click;
            // 
            // mediumBtn
            // 
            mediumBtn.Anchor = AnchorStyles.Bottom;
            mediumBtn.BackgroundImageLayout = ImageLayout.Stretch;
            mediumBtn.FlatAppearance.BorderColor = Color.Black;
            mediumBtn.FlatAppearance.BorderSize = 5;
            mediumBtn.FlatStyle = FlatStyle.Flat;
            mediumBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediumBtn.Location = new Point(601, 452);
            mediumBtn.Name = "mediumBtn";
            mediumBtn.Size = new Size(375, 99);
            mediumBtn.TabIndex = 40;
            mediumBtn.Text = "Medium";
            mediumBtn.UseVisualStyleBackColor = true;
            mediumBtn.Click += DifficultyBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(hardBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(mediumBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(chooseDifficultyLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(easyBtn, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2211113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2211113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2211113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(1577, 879);
            tableLayoutPanel1.TabIndex = 41;
            // 
            // chooseDifficultyLbl
            // 
            chooseDifficultyLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chooseDifficultyLbl.BackColor = Color.DarkTurquoise;
            chooseDifficultyLbl.BorderStyle = BorderStyle.FixedSingle;
            chooseDifficultyLbl.Enabled = false;
            chooseDifficultyLbl.FlatStyle = FlatStyle.Popup;
            chooseDifficultyLbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseDifficultyLbl.Location = new Point(549, 138);
            chooseDifficultyLbl.Margin = new Padding(0);
            chooseDifficultyLbl.Name = "chooseDifficultyLbl";
            chooseDifficultyLbl.Size = new Size(479, 46);
            chooseDifficultyLbl.TabIndex = 38;
            chooseDifficultyLbl.Text = "Choose your difficulty!";
            chooseDifficultyLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // DifficultySetting
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1577, 879);
            Controls.Add(tableLayoutPanel1);
            Name = "DifficultySetting";
            Text = "DifficultySetting";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button easyBtn;
        private Button hardBtn;
        private Button mediumBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label chooseDifficultyLbl;
    }
}
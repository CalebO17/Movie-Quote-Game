namespace PersonalProject
{
    partial class DifficultySettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            chooseDifficultyLbl = new Label();
            easyBtn = new Button();
            mediumBtn = new Button();
            hardBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.4375F));
            tableLayoutPanel1.Controls.Add(chooseDifficultyLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(easyBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(mediumBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(hardBtn, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5567017F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1603661F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.Size = new Size(1600, 900);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chooseDifficultyLbl
            // 
            chooseDifficultyLbl.Anchor = AnchorStyles.None;
            chooseDifficultyLbl.AutoSize = true;
            chooseDifficultyLbl.BackColor = Color.DarkTurquoise;
            chooseDifficultyLbl.BorderStyle = BorderStyle.FixedSingle;
            chooseDifficultyLbl.Font = new Font("Microsoft Sans Serif", 12F);
            chooseDifficultyLbl.Location = new Point(682, 162);
            chooseDifficultyLbl.Margin = new Padding(4, 0, 4, 0);
            chooseDifficultyLbl.Name = "chooseDifficultyLbl";
            chooseDifficultyLbl.Size = new Size(206, 27);
            chooseDifficultyLbl.TabIndex = 0;
            chooseDifficultyLbl.Text = "Choose your difficulty!";
            chooseDifficultyLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // easyBtn
            // 
            easyBtn.AutoSize = true;
            easyBtn.Dock = DockStyle.Bottom;
            easyBtn.FlatAppearance.BorderSize = 5;
            easyBtn.FlatStyle = FlatStyle.Flat;
            easyBtn.Font = new Font("Microsoft Sans Serif", 9F);
            easyBtn.Location = new Point(622, 323);
            easyBtn.Margin = new Padding(4);
            easyBtn.Name = "easyBtn";
            easyBtn.Size = new Size(327, 38);
            easyBtn.TabIndex = 1;
            easyBtn.Text = "Easy";
            easyBtn.Click += DifficultyBtn_Click;
            // 
            // mediumBtn
            // 
            mediumBtn.AutoSize = true;
            mediumBtn.Dock = DockStyle.Bottom;
            mediumBtn.FlatAppearance.BorderSize = 5;
            mediumBtn.FlatStyle = FlatStyle.Flat;
            mediumBtn.Font = new Font("Microsoft Sans Serif", 9F);
            mediumBtn.Location = new Point(622, 517);
            mediumBtn.Margin = new Padding(4);
            mediumBtn.Name = "mediumBtn";
            mediumBtn.Size = new Size(327, 38);
            mediumBtn.TabIndex = 2;
            mediumBtn.Text = "Medium";
            mediumBtn.Click += DifficultyBtn_Click;
            // 
            // hardBtn
            // 
            hardBtn.AutoSize = true;
            hardBtn.Dock = DockStyle.Bottom;
            hardBtn.FlatAppearance.BorderSize = 5;
            hardBtn.FlatStyle = FlatStyle.Flat;
            hardBtn.Font = new Font("Microsoft Sans Serif", 9F);
            hardBtn.Location = new Point(622, 711);
            hardBtn.Margin = new Padding(4);
            hardBtn.Name = "hardBtn";
            hardBtn.Size = new Size(327, 38);
            hardBtn.TabIndex = 3;
            hardBtn.Text = "Hard";
            hardBtn.Click += DifficultyBtn_Click;
            // 
            // DifficultySettings
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1600, 900);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DifficultySettings";
            Text = "DifficultySettings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label chooseDifficultyLbl;
        private Button easyBtn;
        private Button mediumBtn;
        private Button hardBtn;
    }
}

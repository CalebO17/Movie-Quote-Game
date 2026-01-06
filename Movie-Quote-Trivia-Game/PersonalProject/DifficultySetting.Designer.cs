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

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.Dock = DockStyle.Fill;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));

            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;

            chooseDifficultyLbl.AutoSize = true;
            chooseDifficultyLbl.Anchor = AnchorStyles.None;
            chooseDifficultyLbl.BackColor = Color.DarkTurquoise;
            chooseDifficultyLbl.BorderStyle = BorderStyle.FixedSingle;
            chooseDifficultyLbl.Font = new Font("Gill Sans Ultra Bold", 12F);
            chooseDifficultyLbl.Text = "Choose your difficulty!";
            chooseDifficultyLbl.TextAlign = ContentAlignment.MiddleCenter;

            easyBtn.Anchor = AnchorStyles.None;
            easyBtn.FlatStyle = FlatStyle.Flat;
            easyBtn.FlatAppearance.BorderSize = 5;
            easyBtn.Font = new Font("Rockwell Extra Bold", 9F);
            easyBtn.Text = "Easy";
            easyBtn.AutoSize = true;
            easyBtn.Click += DifficultyBtn_Click;

            mediumBtn.Anchor = AnchorStyles.None;
            mediumBtn.FlatStyle = FlatStyle.Flat;
            mediumBtn.FlatAppearance.BorderSize = 5;
            mediumBtn.Font = new Font("Rockwell Extra Bold", 9F);
            mediumBtn.Text = "Medium";
            mediumBtn.AutoSize = true;
            mediumBtn.Click += DifficultyBtn_Click;

            hardBtn.Anchor = AnchorStyles.None;
            hardBtn.FlatStyle = FlatStyle.Flat;
            hardBtn.FlatAppearance.BorderSize = 5;
            hardBtn.Font = new Font("Rockwell Extra Bold", 9F);
            hardBtn.Text = "Hard";
            hardBtn.AutoSize = true;
            hardBtn.Click += DifficultyBtn_Click;

            tableLayoutPanel1.Controls.Add(chooseDifficultyLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(easyBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(mediumBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(hardBtn, 0, 4);

            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScaleDimensions = new SizeF(96F, 96F);
            ClientSize = new Size(1577, 879);
            Controls.Add(tableLayoutPanel1);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
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

namespace PersonalProject
{
    partial class TitleScreen
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
            movieGameTitleLbl = new Label();
            headline1Lbl = new Label();
            headline2Lbl = new Label();
            cameraPbx = new PictureBox();
            cameraFlippedPbx = new PictureBox();
            startGameBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)cameraPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // movieGameTitleLbl
            // 
            movieGameTitleLbl.Anchor = AnchorStyles.None;
            movieGameTitleLbl.AutoSize = true;
            movieGameTitleLbl.BackColor = Color.DodgerBlue;
            movieGameTitleLbl.BorderStyle = BorderStyle.FixedSingle;
            movieGameTitleLbl.Font = new Font("Gill Sans Ultra Bold", 18F);
            movieGameTitleLbl.Location = new Point(1093, 490);
            movieGameTitleLbl.Margin = new Padding(6, 0, 6, 0);
            movieGameTitleLbl.Name = "movieGameTitleLbl";
            movieGameTitleLbl.Size = new Size(599, 71);
            movieGameTitleLbl.TabIndex = 0;
            movieGameTitleLbl.Text = "Movie Quote Game!";
            movieGameTitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headline1Lbl
            // 
            headline1Lbl.Anchor = AnchorStyles.None;
            headline1Lbl.AutoSize = true;
            headline1Lbl.BackColor = Color.DarkTurquoise;
            headline1Lbl.BorderStyle = BorderStyle.FixedSingle;
            headline1Lbl.Font = new Font("Gill Sans Ultra Bold", 12F);
            headline1Lbl.Location = new Point(950, 1178);
            headline1Lbl.Margin = new Padding(6, 0, 6, 0);
            headline1Lbl.Name = "headline1Lbl";
            headline1Lbl.Size = new Size(884, 46);
            headline1Lbl.TabIndex = 4;
            headline1Lbl.Text = "Do you want to test your movie knowledge?";
            headline1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headline2Lbl
            // 
            headline2Lbl.Anchor = AnchorStyles.None;
            headline2Lbl.AutoSize = true;
            headline2Lbl.BackColor = Color.MediumTurquoise;
            headline2Lbl.BorderStyle = BorderStyle.FixedSingle;
            headline2Lbl.Font = new Font("Gill Sans Ultra Bold", 12F);
            headline2Lbl.Location = new Point(1132, 1479);
            headline2Lbl.Margin = new Padding(6, 0, 6, 0);
            headline2Lbl.Name = "headline2Lbl";
            headline2Lbl.Size = new Size(520, 46);
            headline2Lbl.TabIndex = 5;
            headline2Lbl.Text = "You're in the right place!";
            headline2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cameraPbx
            // 
            cameraPbx.BackColor = Color.White;
            cameraPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraPbx.Dock = DockStyle.Fill;
            cameraPbx.Image = Properties.Resources.cameragif;
            cameraPbx.Location = new Point(6, 306);
            cameraPbx.Margin = new Padding(6, 6, 6, 6);
            cameraPbx.Name = "cameraPbx";
            cameraPbx.Size = new Size(746, 439);
            cameraPbx.SizeMode = PictureBoxSizeMode.Zoom;
            cameraPbx.TabIndex = 1;
            cameraPbx.TabStop = false;
            // 
            // cameraFlippedPbx
            // 
            cameraFlippedPbx.BackColor = Color.White;
            cameraFlippedPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraFlippedPbx.Dock = DockStyle.Fill;
            cameraFlippedPbx.Image = Properties.Resources.cameragif_flipped;
            cameraFlippedPbx.Location = new Point(2033, 306);
            cameraFlippedPbx.Margin = new Padding(6, 6, 6, 6);
            cameraFlippedPbx.Name = "cameraFlippedPbx";
            cameraFlippedPbx.Size = new Size(747, 439);
            cameraFlippedPbx.SizeMode = PictureBoxSizeMode.Zoom;
            cameraFlippedPbx.TabIndex = 2;
            cameraFlippedPbx.TabStop = false;
            // 
            // startGameBtn
            // 
            startGameBtn.Dock = DockStyle.Fill;
            startGameBtn.FlatAppearance.BorderSize = 5;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Rockwell Extra Bold", 9F);
            startGameBtn.Location = new Point(764, 757);
            startGameBtn.Margin = new Padding(6, 6, 6, 6);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(1257, 288);
            startGameBtn.TabIndex = 3;
            startGameBtn.Text = "Start Game";
            startGameBtn.Click += startGameBtn_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.21F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.58F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.21F));
            tableLayoutPanel1.Controls.Add(movieGameTitleLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(cameraPbx, 0, 1);
            tableLayoutPanel1.Controls.Add(cameraFlippedPbx, 2, 1);
            tableLayoutPanel1.Controls.Add(startGameBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(headline1Lbl, 1, 3);
            tableLayoutPanel1.Controls.Add(headline2Lbl, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6, 6, 6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.18F));
            tableLayoutPanel1.Size = new Size(2786, 1654);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(2786, 1654);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TitleScreen";
            Text = "TitleScreen";
            ((System.ComponentModel.ISupportInitialize)cameraPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label movieGameTitleLbl;
        private Label headline1Lbl;
        private Label headline2Lbl;
        private PictureBox cameraPbx;
        private PictureBox cameraFlippedPbx;
        private Button startGameBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

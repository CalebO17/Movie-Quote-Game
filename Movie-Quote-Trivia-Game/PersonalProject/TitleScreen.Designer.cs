namespace PersonalProject
{
    partial class TitleScreen
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
            movieGameTitleLbl = new Label();
            headline2Lbl = new Label();
            headline1Lbl = new Label();
            cameraFlippedPbx = new PictureBox();
            cameraPbx = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            startGameBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraPbx).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // movieGameTitleLbl
            // 
            movieGameTitleLbl.Anchor = AnchorStyles.Top;
            movieGameTitleLbl.AutoSize = true;
            movieGameTitleLbl.BackColor = Color.DodgerBlue;
            movieGameTitleLbl.BorderStyle = BorderStyle.FixedSingle;
            movieGameTitleLbl.FlatStyle = FlatStyle.Popup;
            movieGameTitleLbl.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieGameTitleLbl.Location = new Point(396, 150);
            movieGameTitleLbl.Name = "movieGameTitleLbl";
            movieGameTitleLbl.Size = new Size(599, 71);
            movieGameTitleLbl.TabIndex = 32;
            movieGameTitleLbl.Text = "Movie Quote Game!";
            // 
            // headline2Lbl
            // 
            headline2Lbl.Anchor = AnchorStyles.Top;
            headline2Lbl.AutoSize = true;
            headline2Lbl.BackColor = Color.MediumTurquoise;
            headline2Lbl.BorderStyle = BorderStyle.FixedSingle;
            headline2Lbl.FlatStyle = FlatStyle.Popup;
            headline2Lbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headline2Lbl.Location = new Point(436, 675);
            headline2Lbl.Name = "headline2Lbl";
            headline2Lbl.Size = new Size(520, 46);
            headline2Lbl.TabIndex = 36;
            headline2Lbl.Text = "You're in the right place!";
            // 
            // headline1Lbl
            // 
            headline1Lbl.AutoSize = true;
            headline1Lbl.BackColor = Color.DarkTurquoise;
            headline1Lbl.BorderStyle = BorderStyle.FixedSingle;
            headline1Lbl.Dock = DockStyle.Bottom;
            headline1Lbl.Enabled = false;
            headline1Lbl.FlatStyle = FlatStyle.Popup;
            headline1Lbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headline1Lbl.Location = new Point(382, 585);
            headline1Lbl.Name = "headline1Lbl";
            headline1Lbl.Size = new Size(628, 90);
            headline1Lbl.TabIndex = 33;
            headline1Lbl.Text = "Do you want to test your movie knowledge?";
            headline1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cameraFlippedPbx
            // 
            cameraFlippedPbx.Anchor = AnchorStyles.Right;
            cameraFlippedPbx.BackColor = Color.White;
            cameraFlippedPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraFlippedPbx.Image = Properties.Resources.cameragif_flipped;
            cameraFlippedPbx.Location = new Point(1114, 155);
            cameraFlippedPbx.Name = "cameraFlippedPbx";
            cameraFlippedPbx.Size = new Size(276, 214);
            cameraFlippedPbx.TabIndex = 35;
            cameraFlippedPbx.TabStop = false;
            // 
            // cameraPbx
            // 
            cameraPbx.BackColor = Color.White;
            cameraPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraPbx.Image = Properties.Resources.cameragif;
            cameraPbx.Location = new Point(3, 153);
            cameraPbx.Name = "cameraPbx";
            cameraPbx.Size = new Size(276, 214);
            cameraPbx.TabIndex = 34;
            cameraPbx.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.21088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5782356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.2108879F));
            tableLayoutPanel1.Controls.Add(movieGameTitleLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(cameraFlippedPbx, 2, 1);
            tableLayoutPanel1.Controls.Add(cameraPbx, 0, 1);
            tableLayoutPanel1.Controls.Add(headline2Lbl, 1, 4);
            tableLayoutPanel1.Controls.Add(headline1Lbl, 1, 3);
            tableLayoutPanel1.Controls.Add(startGameBtn, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1393, 827);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // startGameBtn
            // 
            startGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            startGameBtn.Dock = DockStyle.Fill;
            startGameBtn.FlatAppearance.BorderColor = Color.Black;
            startGameBtn.FlatAppearance.BorderSize = 5;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameBtn.Location = new Point(382, 378);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(628, 144);
            startGameBtn.TabIndex = 37;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click_1;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1393, 827);
            Controls.Add(tableLayoutPanel1);
            Name = "TitleScreen";
            Text = "TitleScreen";
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraPbx).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label movieGameTitleLbl;
        private Label headline2Lbl;
        private Label headline1Lbl;
        private PictureBox cameraFlippedPbx;
        private PictureBox cameraPbx;
        private TableLayoutPanel tableLayoutPanel1;
        private Button startGameBtn;
    }
}
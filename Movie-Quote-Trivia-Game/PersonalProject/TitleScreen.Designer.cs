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
            startGameBtn = new Button();
            gameTitlePnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraPbx).BeginInit();
            gameTitlePnl.SuspendLayout();
            SuspendLayout();
            // 
            // movieGameTitleLbl
            // 
            movieGameTitleLbl.AutoSize = true;
            movieGameTitleLbl.BackColor = Color.DodgerBlue;
            movieGameTitleLbl.BorderStyle = BorderStyle.FixedSingle;
            movieGameTitleLbl.FlatStyle = FlatStyle.Popup;
            movieGameTitleLbl.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieGameTitleLbl.Location = new Point(12, 12);
            movieGameTitleLbl.Name = "movieGameTitleLbl";
            movieGameTitleLbl.Size = new Size(599, 71);
            movieGameTitleLbl.TabIndex = 32;
            movieGameTitleLbl.Text = "Movie Quote Game!";
            // 
            // headline2Lbl
            // 
            headline2Lbl.AutoSize = true;
            headline2Lbl.BackColor = Color.MediumTurquoise;
            headline2Lbl.BorderStyle = BorderStyle.FixedSingle;
            headline2Lbl.FlatStyle = FlatStyle.Popup;
            headline2Lbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headline2Lbl.Location = new Point(438, 668);
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
            headline1Lbl.Enabled = false;
            headline1Lbl.FlatStyle = FlatStyle.Popup;
            headline1Lbl.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headline1Lbl.Location = new Point(256, 610);
            headline1Lbl.Name = "headline1Lbl";
            headline1Lbl.Size = new Size(884, 46);
            headline1Lbl.TabIndex = 33;
            headline1Lbl.Text = "Do you want to test your movie knowledge?";
            // 
            // cameraFlippedPbx
            // 
            cameraFlippedPbx.BackColor = Color.White;
            cameraFlippedPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraFlippedPbx.Image = Properties.Resources.cameragif_flipped;
            cameraFlippedPbx.Location = new Point(1089, 105);
            cameraFlippedPbx.Name = "cameraFlippedPbx";
            cameraFlippedPbx.Size = new Size(276, 245);
            cameraFlippedPbx.TabIndex = 35;
            cameraFlippedPbx.TabStop = false;
            // 
            // cameraPbx
            // 
            cameraPbx.BackColor = Color.White;
            cameraPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            cameraPbx.Image = Properties.Resources.cameragif;
            cameraPbx.Location = new Point(15, 105);
            cameraPbx.Name = "cameraPbx";
            cameraPbx.Size = new Size(276, 245);
            cameraPbx.TabIndex = 34;
            cameraPbx.TabStop = false;
            // 
            // startGameBtn
            // 
            startGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            startGameBtn.FlatAppearance.BorderColor = Color.Black;
            startGameBtn.FlatAppearance.BorderSize = 5;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameBtn.Location = new Point(326, 222);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(730, 340);
            startGameBtn.TabIndex = 31;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // gameTitlePnl
            // 
            gameTitlePnl.BackColor = SystemColors.ActiveCaptionText;
            gameTitlePnl.Controls.Add(movieGameTitleLbl);
            gameTitlePnl.Location = new Point(376, 83);
            gameTitlePnl.Name = "gameTitlePnl";
            gameTitlePnl.Size = new Size(623, 94);
            gameTitlePnl.TabIndex = 37;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1393, 827);
            Controls.Add(gameTitlePnl);
            Controls.Add(headline2Lbl);
            Controls.Add(headline1Lbl);
            Controls.Add(cameraFlippedPbx);
            Controls.Add(cameraPbx);
            Controls.Add(startGameBtn);
            Name = "TitleScreen";
            Text = "TitleScreen";
            ((System.ComponentModel.ISupportInitialize)cameraFlippedPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraPbx).EndInit();
            gameTitlePnl.ResumeLayout(false);
            gameTitlePnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieGameTitleLbl;
        private Label headline2Lbl;
        private Label headline1Lbl;
        private PictureBox cameraFlippedPbx;
        private PictureBox cameraPbx;
        private Button startGameBtn;
        private Panel gameTitlePnl;
    }
}
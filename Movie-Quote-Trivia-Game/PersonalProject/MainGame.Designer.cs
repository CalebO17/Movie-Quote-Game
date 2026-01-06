namespace PersonalProject
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            celebLbl3 = new Label();
            celebLbl2 = new Label();
            celebLbl1 = new Label();
            quoteTxtBox1 = new TextBox();
            choose1Btn = new Button();
            celebPbx1 = new PictureBox();
            celebPbx2 = new PictureBox();
            celebPbx3 = new PictureBox();
            redX1 = new PictureBox();
            redX2 = new PictureBox();
            redX3 = new PictureBox();
            choose3Btn = new Button();
            scoreLbl = new Label();
            scoreNumbLbl = new Label();
            skipPbx = new PictureBox();
            hintPbx = new PictureBox();
            choose2Btn = new Button();
            quoteLbl = new TextBox();
            movieDescriptionPbx = new PictureBox();
            xPbx = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)celebPbx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieDescriptionPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xPbx).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // celebLbl3
            // 
            celebLbl3.Anchor = AnchorStyles.Top;
            celebLbl3.AutoSize = true;
            celebLbl3.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl3.Location = new Point(1001, 592);
            celebLbl3.MaximumSize = new Size(250, 0);
            celebLbl3.Name = "celebLbl3";
            celebLbl3.Size = new Size(153, 25);
            celebLbl3.TabIndex = 1;
            celebLbl3.Text = "Celeb name 3";
            // 
            // celebLbl2
            // 
            celebLbl2.Anchor = AnchorStyles.Top;
            celebLbl2.AutoSize = true;
            celebLbl2.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl2.Location = new Point(667, 592);
            celebLbl2.MaximumSize = new Size(250, 0);
            celebLbl2.Name = "celebLbl2";
            celebLbl2.Size = new Size(153, 25);
            celebLbl2.TabIndex = 2;
            celebLbl2.Text = "Celeb name 2";
            // 
            // celebLbl1
            // 
            celebLbl1.Anchor = AnchorStyles.Top;
            celebLbl1.AutoSize = true;
            celebLbl1.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl1.Location = new Point(334, 592);
            celebLbl1.MaximumSize = new Size(250, 0);
            celebLbl1.Name = "celebLbl1";
            celebLbl1.Size = new Size(153, 25);
            celebLbl1.TabIndex = 3;
            celebLbl1.Text = "Celeb name 1";
            // 
            // quoteTxtBox1
            // 
            quoteTxtBox1.BackColor = Color.DodgerBlue;
            quoteTxtBox1.Font = new Font("Franklin Gothic Medium", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            quoteTxtBox1.Location = new Point(521, 150);
            quoteTxtBox1.Multiline = true;
            quoteTxtBox1.Name = "quoteTxtBox1";
            quoteTxtBox1.Size = new Size(445, 102);
            quoteTxtBox1.TabIndex = 7;
            // 
            // choose1Btn
            // 
            choose1Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            choose1Btn.Location = new Point(306, 258);
            choose1Btn.Name = "choose1Btn";
            choose1Btn.Size = new Size(209, 70);
            choose1Btn.TabIndex = 8;
            choose1Btn.Tag = "celebLbl1";
            choose1Btn.Text = "Choose";
            choose1Btn.UseVisualStyleBackColor = true;
            choose1Btn.Click += ChooseBtn_Click;
            // 
            // celebPbx1
            // 
            celebPbx1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            celebPbx1.BackgroundImageLayout = ImageLayout.None;
            celebPbx1.Location = new Point(306, 334);
            celebPbx1.Name = "celebPbx1";
            celebPbx1.Size = new Size(209, 253);
            celebPbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx1.TabIndex = 11;
            celebPbx1.TabStop = false;
            // 
            // celebPbx2
            // 
            celebPbx2.Anchor = AnchorStyles.Top;
            celebPbx2.BackgroundImageLayout = ImageLayout.None;
            celebPbx2.Location = new Point(637, 334);
            celebPbx2.Name = "celebPbx2";
            celebPbx2.Size = new Size(212, 253);
            celebPbx2.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx2.TabIndex = 12;
            celebPbx2.TabStop = false;
            // 
            // celebPbx3
            // 
            celebPbx3.Anchor = AnchorStyles.Top;
            celebPbx3.BackgroundImageLayout = ImageLayout.None;
            celebPbx3.Location = new Point(972, 334);
            celebPbx3.Name = "celebPbx3";
            celebPbx3.Size = new Size(211, 253);
            celebPbx3.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx3.TabIndex = 13;
            celebPbx3.TabStop = false;
            // 
            // redX1
            // 
            redX1.BackColor = Color.Transparent;
            redX1.Image = (Image)resources.GetObject("redX1.Image");
            redX1.Location = new Point(1306, 3);
            redX1.Name = "redX1";
            redX1.Size = new Size(66, 52);
            redX1.SizeMode = PictureBoxSizeMode.StretchImage;
            redX1.TabIndex = 14;
            redX1.TabStop = false;
            redX1.Visible = false;
            // 
            // redX2
            // 
            redX2.Anchor = AnchorStyles.Top;
            redX2.BackColor = Color.Transparent;
            redX2.BackgroundImageLayout = ImageLayout.None;
            redX2.Image = Properties.Resources.redx_removebg_preview;
            redX2.Location = new Point(1212, 3);
            redX2.Name = "redX2";
            redX2.Size = new Size(66, 52);
            redX2.SizeMode = PictureBoxSizeMode.StretchImage;
            redX2.TabIndex = 15;
            redX2.TabStop = false;
            redX2.Visible = false;
            // 
            // redX3
            // 
            redX3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            redX3.BackColor = Color.Transparent;
            redX3.Image = Properties.Resources.redx_removebg_preview;
            redX3.Location = new Point(1118, 3);
            redX3.Name = "redX3";
            redX3.Size = new Size(66, 52);
            redX3.SizeMode = PictureBoxSizeMode.StretchImage;
            redX3.TabIndex = 16;
            redX3.TabStop = false;
            redX3.Visible = false;
            // 
            // choose3Btn
            // 
            choose3Btn.Dock = DockStyle.Fill;
            choose3Btn.Location = new Point(972, 258);
            choose3Btn.Name = "choose3Btn";
            choose3Btn.Size = new Size(212, 70);
            choose3Btn.TabIndex = 19;
            choose3Btn.Tag = "celebLbl3";
            choose3Btn.Text = "Choose";
            choose3Btn.UseVisualStyleBackColor = true;
            choose3Btn.Click += ChooseBtn_Click;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Location = new Point(3, 0);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(73, 32);
            scoreLbl.TabIndex = 21;
            scoreLbl.Text = "Score";
            // 
            // scoreNumbLbl
            // 
            scoreNumbLbl.AutoSize = true;
            scoreNumbLbl.Cursor = Cursors.Hand;
            scoreNumbLbl.Location = new Point(3, 58);
            scoreNumbLbl.Name = "scoreNumbLbl";
            scoreNumbLbl.Size = new Size(62, 32);
            scoreNumbLbl.TabIndex = 22;
            scoreNumbLbl.Text = "0/10";
            // 
            // skipPbx
            // 
            skipPbx.BackColor = Color.Transparent;
            skipPbx.Image = Properties.Resources.Skip;
            skipPbx.Location = new Point(3, 679);
            skipPbx.Name = "skipPbx";
            skipPbx.Size = new Size(66, 62);
            skipPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            skipPbx.TabIndex = 23;
            skipPbx.TabStop = false;
            skipPbx.Click += skipPbx_Click;
            // 
            // hintPbx
            // 
            hintPbx.BackColor = Color.Transparent;
            hintPbx.Image = Properties.Resources.questionMark;
            hintPbx.Location = new Point(972, 752);
            hintPbx.Name = "hintPbx";
            hintPbx.Size = new Size(66, 63);
            hintPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            hintPbx.TabIndex = 24;
            hintPbx.TabStop = false;
            hintPbx.Click += hintPbx_Click;
            // 
            // choose2Btn
            // 
            choose2Btn.Anchor = AnchorStyles.Top;
            choose2Btn.Location = new Point(637, 258);
            choose2Btn.Name = "choose2Btn";
            choose2Btn.Size = new Size(213, 70);
            choose2Btn.TabIndex = 18;
            choose2Btn.Tag = "celebLbl2";
            choose2Btn.Text = "Choose";
            choose2Btn.UseVisualStyleBackColor = true;
            choose2Btn.Click += ChooseBtn_Click;
            // 
            // quoteLbl
            // 
            quoteLbl.Anchor = AnchorStyles.Bottom;
            quoteLbl.BackColor = Color.White;
            quoteLbl.Font = new Font("Franklin Gothic Medium Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quoteLbl.Location = new Point(664, 70);
            quoteLbl.Multiline = true;
            quoteLbl.Name = "quoteLbl";
            quoteLbl.Size = new Size(158, 74);
            quoteLbl.TabIndex = 26;
            quoteLbl.Text = "Quote:";
            // 
            // movieDescriptionPbx
            // 
            movieDescriptionPbx.BackColor = Color.Transparent;
            movieDescriptionPbx.Image = Properties.Resources.camera;
            movieDescriptionPbx.Location = new Point(306, 752);
            movieDescriptionPbx.Name = "movieDescriptionPbx";
            movieDescriptionPbx.Size = new Size(66, 62);
            movieDescriptionPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            movieDescriptionPbx.TabIndex = 27;
            movieDescriptionPbx.TabStop = false;
            movieDescriptionPbx.Click += movieDescriptionPbx_Click;
            // 
            // xPbx
            // 
            xPbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            xPbx.BackColor = Color.Transparent;
            xPbx.Image = Properties.Resources.blackX1;
            xPbx.Location = new Point(1351, 679);
            xPbx.Name = "xPbx";
            xPbx.Size = new Size(88, 67);
            xPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            xPbx.TabIndex = 28;
            xPbx.TabStop = false;
            xPbx.Click += xPbx_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0124836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9098473F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2948589F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1178923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.044383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.56124F));
            tableLayoutPanel1.Controls.Add(scoreNumbLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(scoreLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(skipPbx, 0, 6);
            tableLayoutPanel1.Controls.Add(redX1, 5, 0);
            tableLayoutPanel1.Controls.Add(xPbx, 5, 6);
            tableLayoutPanel1.Controls.Add(redX2, 4, 0);
            tableLayoutPanel1.Controls.Add(redX3, 3, 0);
            tableLayoutPanel1.Controls.Add(hintPbx, 3, 7);
            tableLayoutPanel1.Controls.Add(celebLbl3, 3, 5);
            tableLayoutPanel1.Controls.Add(choose3Btn, 3, 3);
            tableLayoutPanel1.Controls.Add(choose2Btn, 2, 3);
            tableLayoutPanel1.Controls.Add(celebPbx1, 1, 4);
            tableLayoutPanel1.Controls.Add(celebLbl2, 2, 5);
            tableLayoutPanel1.Controls.Add(celebLbl1, 1, 5);
            tableLayoutPanel1.Controls.Add(choose1Btn, 1, 3);
            tableLayoutPanel1.Controls.Add(quoteLbl, 2, 1);
            tableLayoutPanel1.Controls.Add(quoteTxtBox1, 2, 2);
            tableLayoutPanel1.Controls.Add(movieDescriptionPbx, 1, 7);
            tableLayoutPanel1.Controls.Add(celebPbx2, 2, 4);
            tableLayoutPanel1.Controls.Add(celebPbx3, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.91153145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5133162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8496075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.053133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.8064442F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.905661F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.608491F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.320755F));
            tableLayoutPanel1.Size = new Size(1442, 848);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // MainGame
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1442, 848);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainGame";
            Text = "MainGame";
            ((System.ComponentModel.ISupportInitialize)celebPbx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieDescriptionPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)xPbx).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label celebLbl3;
        private Label celebLbl2;
        private Label celebLbl1;
        private TextBox quoteTxtBox1;
        private Button choose1Btn;
        private PictureBox celebPbx1;
        private PictureBox celebPbx2;
        private PictureBox celebPbx3;
        private PictureBox redX1;
        private PictureBox redX2;
        private PictureBox redX3;
        private Button choose3Btn;
        private Label scoreLbl;
        private Label scoreNumbLbl;
        private PictureBox skipPbx;
        private PictureBox hintPbx;
        private Button choose2Btn;
        private TextBox quoteLbl;
        private PictureBox movieDescriptionPbx;
        private PictureBox xPbx;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

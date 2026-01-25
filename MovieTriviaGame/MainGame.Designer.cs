namespace PersonalProject
{
    partial class MainGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            scoreLbl = new Label();
            quoteLbl = new TextBox();
            quoteTxtBox1 = new TextBox();
            choose1Btn = new Button();
            choose2Btn = new Button();
            choose3Btn = new Button();
            celebPbx1 = new PictureBox();
            celebPbx2 = new PictureBox();
            celebPbx3 = new PictureBox();
            celebLbl1 = new Label();
            celebLbl2 = new Label();
            celebLbl3 = new Label();
            movieDescriptionPbx = new PictureBox();
            redX1 = new PictureBox();
            redX2 = new PictureBox();
            redX3 = new PictureBox();
            skipPbx = new PictureBox();
            hintPbx = new PictureBox();
            xPbx = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)celebPbx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieDescriptionPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xPbx).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(scoreLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(quoteLbl, 2, 1);
            tableLayoutPanel1.Controls.Add(quoteTxtBox1, 2, 2);
            tableLayoutPanel1.Controls.Add(choose1Btn, 1, 3);
            tableLayoutPanel1.Controls.Add(choose2Btn, 2, 3);
            tableLayoutPanel1.Controls.Add(choose3Btn, 3, 3);
            tableLayoutPanel1.Controls.Add(celebPbx1, 1, 4);
            tableLayoutPanel1.Controls.Add(celebPbx2, 2, 4);
            tableLayoutPanel1.Controls.Add(celebPbx3, 3, 4);
            tableLayoutPanel1.Controls.Add(celebLbl1, 1, 5);
            tableLayoutPanel1.Controls.Add(celebLbl2, 2, 5);
            tableLayoutPanel1.Controls.Add(celebLbl3, 3, 5);
            tableLayoutPanel1.Controls.Add(movieDescriptionPbx, 1, 7);
            tableLayoutPanel1.Controls.Add(redX1, 3, 0);
            tableLayoutPanel1.Controls.Add(redX2, 4, 0);
            tableLayoutPanel1.Controls.Add(redX3, 5, 0);
            tableLayoutPanel1.Controls.Add(skipPbx, 0, 7);
            tableLayoutPanel1.Controls.Add(hintPbx, 3, 7);
            tableLayoutPanel1.Controls.Add(xPbx, 5, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.54717F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.056603F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.113208F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.792453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.Size = new Size(1600, 900);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Location = new Point(2, 0);
            scoreLbl.Margin = new Padding(2, 0, 2, 0);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(61, 20);
            scoreLbl.TabIndex = 0;
            scoreLbl.Text = "Score: 0";
            // 
            // quoteLbl
            // 
            quoteLbl.Dock = DockStyle.Fill;
            quoteLbl.Font = new Font("Microsoft Sans Serif", 20F);
            quoteLbl.Location = new Point(658, 47);
            quoteLbl.Margin = new Padding(2);
            quoteLbl.Multiline = true;
            quoteLbl.Name = "quoteLbl";
            quoteLbl.ReadOnly = true;
            quoteLbl.Size = new Size(316, 104);
            quoteLbl.TabIndex = 2;
            quoteLbl.Text = "Quote:";
            quoteLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // quoteTxtBox1
            // 
            quoteTxtBox1.BackColor = Color.DodgerBlue;
            quoteTxtBox1.Dock = DockStyle.Fill;
            quoteTxtBox1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            quoteTxtBox1.Location = new Point(658, 155);
            quoteTxtBox1.Margin = new Padding(2);
            quoteTxtBox1.Multiline = true;
            quoteTxtBox1.Name = "quoteTxtBox1";
            quoteTxtBox1.ReadOnly = true;
            quoteTxtBox1.Size = new Size(316, 154);
            quoteTxtBox1.TabIndex = 3;
            // 
            // choose1Btn
            // 
            choose1Btn.Dock = DockStyle.Fill;
            choose1Btn.Location = new Point(338, 313);
            choose1Btn.Margin = new Padding(2);
            choose1Btn.Name = "choose1Btn";
            choose1Btn.Size = new Size(316, 77);
            choose1Btn.TabIndex = 4;
            choose1Btn.Text = "Choose";
            choose1Btn.Click += ChooseBtn_Click;
            // 
            // choose2Btn
            // 
            choose2Btn.Dock = DockStyle.Fill;
            choose2Btn.Location = new Point(658, 313);
            choose2Btn.Margin = new Padding(2);
            choose2Btn.Name = "choose2Btn";
            choose2Btn.Size = new Size(316, 77);
            choose2Btn.TabIndex = 5;
            choose2Btn.Text = "Choose";
            choose2Btn.Click += ChooseBtn_Click;
            // 
            // choose3Btn
            // 
            choose3Btn.Dock = DockStyle.Fill;
            choose3Btn.Location = new Point(978, 313);
            choose3Btn.Margin = new Padding(2);
            choose3Btn.Name = "choose3Btn";
            choose3Btn.Size = new Size(316, 77);
            choose3Btn.TabIndex = 6;
            choose3Btn.Text = "Choose";
            choose3Btn.Click += ChooseBtn_Click;
            // 
            // celebPbx1
            // 
            celebPbx1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            celebPbx1.Dock = DockStyle.Fill;
            celebPbx1.Location = new Point(338, 394);
            celebPbx1.Margin = new Padding(2);
            celebPbx1.Name = "celebPbx1";
            celebPbx1.Size = new Size(316, 267);
            celebPbx1.SizeMode = PictureBoxSizeMode.Zoom;
            celebPbx1.TabIndex = 7;
            celebPbx1.TabStop = false;
            // 
            // celebPbx2
            // 
            celebPbx2.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            celebPbx2.Dock = DockStyle.Fill;
            celebPbx2.Location = new Point(658, 394);
            celebPbx2.Margin = new Padding(2);
            celebPbx2.Name = "celebPbx2";
            celebPbx2.Size = new Size(316, 267);
            celebPbx2.SizeMode = PictureBoxSizeMode.Zoom;
            celebPbx2.TabIndex = 8;
            celebPbx2.TabStop = false;
            // 
            // celebPbx3
            // 
            celebPbx3.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            celebPbx3.Dock = DockStyle.Fill;
            celebPbx3.Location = new Point(978, 394);
            celebPbx3.Margin = new Padding(2);
            celebPbx3.Name = "celebPbx3";
            celebPbx3.Size = new Size(316, 267);
            celebPbx3.SizeMode = PictureBoxSizeMode.Zoom;
            celebPbx3.TabIndex = 9;
            celebPbx3.TabStop = false;
            // 
            // celebLbl1
            // 
            celebLbl1.Anchor = AnchorStyles.Top;
            celebLbl1.AutoSize = true;
            celebLbl1.Location = new Point(446, 663);
            celebLbl1.Margin = new Padding(2, 0, 2, 0);
            celebLbl1.Name = "celebLbl1";
            celebLbl1.Size = new Size(100, 20);
            celebLbl1.TabIndex = 10;
            celebLbl1.Text = "Celeb name 1";
            celebLbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // celebLbl2
            // 
            celebLbl2.Anchor = AnchorStyles.Top;
            celebLbl2.AutoSize = true;
            celebLbl2.Location = new Point(766, 663);
            celebLbl2.Margin = new Padding(2, 0, 2, 0);
            celebLbl2.Name = "celebLbl2";
            celebLbl2.Size = new Size(100, 20);
            celebLbl2.TabIndex = 11;
            celebLbl2.Text = "Celeb name 2";
            celebLbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // celebLbl3
            // 
            celebLbl3.Anchor = AnchorStyles.Top;
            celebLbl3.AutoSize = true;
            celebLbl3.Location = new Point(1086, 663);
            celebLbl3.Margin = new Padding(2, 0, 2, 0);
            celebLbl3.Name = "celebLbl3";
            celebLbl3.Size = new Size(100, 20);
            celebLbl3.TabIndex = 12;
            celebLbl3.Text = "Celeb name 3";
            celebLbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieDescriptionPbx
            // 
            movieDescriptionPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            movieDescriptionPbx.Dock = DockStyle.Left;
            movieDescriptionPbx.Image = Properties.Resources.camera;
            movieDescriptionPbx.Location = new Point(338, 799);
            movieDescriptionPbx.Margin = new Padding(2);
            movieDescriptionPbx.Name = "movieDescriptionPbx";
            movieDescriptionPbx.Size = new Size(78, 99);
            movieDescriptionPbx.SizeMode = PictureBoxSizeMode.Zoom;
            movieDescriptionPbx.TabIndex = 14;
            movieDescriptionPbx.TabStop = false;
            movieDescriptionPbx.Click += movieDescriptionPbx_Click;
            // 
            // redX1
            // 
            redX1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            redX1.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            redX1.Image = Properties.Resources.redx_removebg_preview;
            redX1.Location = new Point(1216, 2);
            redX1.Margin = new Padding(2);
            redX1.Name = "redX1";
            redX1.Size = new Size(78, 39);
            redX1.SizeMode = PictureBoxSizeMode.Zoom;
            redX1.TabIndex = 17;
            redX1.TabStop = false;
            redX1.Visible = false;
            // 
            // redX2
            // 
            redX2.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            redX2.Image = Properties.Resources.redx_removebg_preview;
            redX2.Location = new Point(1298, 2);
            redX2.Margin = new Padding(2);
            redX2.Name = "redX2";
            redX2.Size = new Size(78, 39);
            redX2.SizeMode = PictureBoxSizeMode.Zoom;
            redX2.TabIndex = 18;
            redX2.TabStop = false;
            redX2.Visible = false;
            // 
            // redX3
            // 
            redX3.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            redX3.Image = Properties.Resources.redx_removebg_preview;
            redX3.Location = new Point(1442, 2);
            redX3.Margin = new Padding(2);
            redX3.Name = "redX3";
            redX3.Size = new Size(78, 39);
            redX3.SizeMode = PictureBoxSizeMode.Zoom;
            redX3.TabIndex = 19;
            redX3.TabStop = false;
            redX3.Visible = false;
            // 
            // skipPbx
            // 
            skipPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            skipPbx.Dock = DockStyle.Left;
            skipPbx.Image = Properties.Resources.Skip;
            skipPbx.Location = new Point(2, 799);
            skipPbx.Margin = new Padding(2);
            skipPbx.Name = "skipPbx";
            skipPbx.Size = new Size(78, 99);
            skipPbx.SizeMode = PictureBoxSizeMode.Zoom;
            skipPbx.TabIndex = 13;
            skipPbx.TabStop = false;
            skipPbx.Click += skipPbx_Click;
            // 
            // hintPbx
            // 
            hintPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            hintPbx.Dock = DockStyle.Right;
            hintPbx.Image = Properties.Resources.questionMark;
            hintPbx.Location = new Point(1216, 799);
            hintPbx.Margin = new Padding(2);
            hintPbx.Name = "hintPbx";
            hintPbx.Size = new Size(78, 99);
            hintPbx.SizeMode = PictureBoxSizeMode.Zoom;
            hintPbx.TabIndex = 15;
            hintPbx.TabStop = false;
            hintPbx.Click += hintPbx_Click;
            // 
            // xPbx
            // 
            xPbx.BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            xPbx.Dock = DockStyle.Right;
            xPbx.Image = Properties.Resources.blackX1;
            xPbx.Location = new Point(1520, 799);
            xPbx.Margin = new Padding(2);
            xPbx.Name = "xPbx";
            xPbx.Size = new Size(78, 99);
            xPbx.SizeMode = PictureBoxSizeMode.Zoom;
            xPbx.TabIndex = 16;
            xPbx.TabStop = false;
            xPbx.Click += xPbx_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1600, 900);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainGame";
            Text = "MainGame";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)celebPbx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieDescriptionPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)xPbx).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label scoreLbl;
        private Label scoreNumbLbl;
        private TextBox quoteLbl;
        private TextBox quoteTxtBox1;
        private Button choose1Btn;
        private Button choose2Btn;
        private Button choose3Btn;
        private PictureBox celebPbx1;
        private PictureBox celebPbx2;
        private PictureBox celebPbx3;
        private Label celebLbl1;
        private Label celebLbl2;
        private Label celebLbl3;
        private PictureBox redX1;
        private PictureBox redX2;
        private PictureBox redX3;
        private PictureBox skipPbx;
        private PictureBox movieDescriptionPbx;
        private PictureBox hintPbx;
        private PictureBox xPbx;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalProject
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }
        private void gameTitlePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startGameBtn_Click_1(object sender, EventArgs e)
        {

            // Create the difficulty settings form
            DifficultySettings difficulty = new DifficultySettings();

            // Show the difficulty form
            difficulty.Show();

            // Hide the title screen
            this.Hide();


        }
    }
}

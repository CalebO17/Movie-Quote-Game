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
    public partial class DifficultySetting : Form
    {
        public DifficultySetting()
        {
            InitializeComponent();
        }

        private void DifficultyBtn_Click(object sender, EventArgs e)
        {
            string difficulty;
            int totalScore;
            int totalIncorrect;
            Button? clickedButton = sender as Button; //Grab the button that was clicked
            //Find out which button was clicked, and active the chooseButtonClick function for the correlating label
            if (clickedButton == easyBtn)
            {
                difficulty = "easy";
                totalScore = 3;
                totalIncorrect = 3;
            }
            else if (clickedButton == mediumBtn)
            {
                difficulty = "medium";
                totalScore = 10;
                totalIncorrect = 2;
            }
            else
            {
                difficulty = "hard";
                totalScore = 25;
                totalIncorrect = 1;
            }
            MainGame mainGame = new MainGame(difficulty, totalScore, totalIncorrect);
            mainGame.Show();
            this.Close();
        }
    }
}

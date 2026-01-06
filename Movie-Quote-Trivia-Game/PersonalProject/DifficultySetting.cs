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
    public partial class DifficultySettings : Form
    {
        public DifficultySettings()
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
                MessageBox.Show("You chose easy! You only need 3 points to win. 3 incorrect guesses and you lose.");
            }
            else if (clickedButton == mediumBtn)
            {
                difficulty = "medium";
                totalScore = 10;
                totalIncorrect = 2;
                MessageBox.Show("You chose medium! You need 10 points to win. 2 incorrect guesses and you lose.");
            }
            else
            {
                difficulty = "hard";
                totalScore = 15;
                totalIncorrect = 1;
                MessageBox.Show("You chose hard! You need 15 points to win. 1 incorrect guess and you lose(BONUS ROUNDS INCLUDED)");
            }
            MainGame mainGame = new MainGame(difficulty, totalScore, totalIncorrect);
            mainGame.Show();
            this.Close();
        }
    }
}

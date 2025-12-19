using System;
using System.Media;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PersonalProject
{


    public partial class Form1 : Form
    {
        //Creating lists that will represent each table from MYSQL
        List<Celebrity> celebrities = new List<Celebrity>();
        List<Film> movies = new List<Film>();
        List<Quote> quotes = new List<Quote>();
        List<Hint> hints = new List<Hint>();
        List<PictureBox> redXList = new List<PictureBox>();
        SoundPlayer soundPlayer = new SoundPlayer();
        Random randomNumb = new Random();

        //Class level Variables
        int chosenQuoteIndex = 0;
        int score = 0;
        int incorrectGuesses = 0;
        bool mode = true;

        //Runs when exe file runs
        public Form1()
        {
            InitializeComponent();
            this.Load += MainGameForm_Load;

        }
        private void MainGameForm_Load(object sender, EventArgs e)
        {
            PlaySound("click.wav");
            startGame();
        }

        // Function that will play a sound effect stored in the "sounds" folder, with the 
        // name of the sound file being passed into the function
        private void PlaySound(string fileName)
        {
            string soundPath = Path.Combine(Application.StartupPath, "Sounds", fileName);
            if (File.Exists(soundPath))
            {
                SoundPlayer player = new SoundPlayer(soundPath);
                player.Play();
            }
        }

        //Function for loading data from database into array
        void loadData()
        {
            redXList = new List<PictureBox> { redX1, redX2, redX3 };
            //Declaring strings to represent each environment variable to connect to SQl database
            string server = Environment.GetEnvironmentVariable("DB_SERVER");
            string port = Environment.GetEnvironmentVariable("DB_PORT");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            string database = Environment.GetEnvironmentVariable("DB_NAME");

            //Connecting to SQL database
            string connectionString = $"server={server};port={port};user={user};password={password};database={database}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try //Attempting to connect to database, providing an error message if it fails
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");
                }
                catch (Exception failure)
                {
                    Console.WriteLine("Error connecting to mysql database");
                };
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Connectiong to the database using the connectionString
            {
                connection.Open();
                //Running queries and taking that data to put into objects and adding to the lists
                string actorQuery = "SELECT * FROM Actors ORDER BY actor_id";
                string quoteQuery = "SELECT q.quote_line, a.actor_name, m.movie_name\r\nFROM Quotes q\r\nLEFT JOIN Actors a on q.actor_id = a.actor_id\r\nLEFT JOIN Movies m on q.movie_id = m.movie_id";
                string movieQuery = "SELECT * FROM Movies ORDER BY movie_id";
                string hintQuery = "SELECT h.hint, a.actor_name\r\nFROM Hints h\r\nLEFT JOIN Actors a ON a.actor_id = h.actor_id";
                string actorMovieQuery = "SELECT a.actor_name, m.movie_name\r\nFROM Actors a\r\nLEFT JOIN ActorMovies am ON a.actor_id = am.actor_id\r\nLEFT JOIN Movies m ON m.movie_id = am.movie_id;\r\n";
                using (MySqlCommand command = new MySqlCommand(actorQuery, connection)) // Using actorQuery
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding celebrity data to objects and adding to list
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString("actor_name");
                        DateTime birthday = dataReader.GetDateTime("birthday");
                        string resourceName = dataReader.GetString("actor_image_directory");

                        // Load the image dynamically from project resources
                        Image actorImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

                        // Create the celebrity object with that image
                        Celebrity celeb = new Celebrity(name, birthday, actorImage);
                        // Add the newly created Celebrity object to the celebrities list
                        celebrities.Add(celeb);
                    }
                }
                using (MySqlCommand command = new MySqlCommand(movieQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        //Adding movie data to objects and adding to list
                        string name = dataReader.GetString("movie_name");
                        DateTime releaseDate = dataReader.GetDateTime("movie_release_date");
                        string director = dataReader.GetString("movie_director");
                        string description = dataReader.GetString("movie_description");
                        string resourceName = dataReader["movie_image_directory"].ToString();

                        // Load the image dynamically from project resources
                        Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);


                        Film movie = new Film(name, description, director, releaseDate, movieImage);
                        movies.Add(movie);
                    }
                }


                using (MySqlCommand command = new MySqlCommand(quoteQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding quote data to objects and adding to list
                    while (dataReader.Read())
                    {
                        Quote quote = new Quote();
                        string quoteLine = dataReader.GetString("quote_line");
                        string quoteCelebName = dataReader.GetString("actor_name");
                        string quoteMovieName = dataReader.GetString("movie_name");
                        //Matching quote data with data from the other tables
                        foreach (Celebrity celeb in celebrities)
                        {
                            if (celeb.Name == quoteCelebName) // If the celeb is the same celeb as in the quote, then add that celeb to the quote object
                            {
                                quote.Celebrity = celeb;
                            }

                        }
                        foreach (Film movie in movies)
                        {
                            if (movie.Name == quoteMovieName) // If the film is the same as the film in the quote then add the film to the quote object
                            {
                                quote.Film = movie;

                            }

                        }

                        quote.MovieQuote = quoteLine;
                        quotes.Add(quote); // Add quote to quotes list
                    }
                }

                using (MySqlCommand command = new MySqlCommand(hintQuery, connection))
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    //Adding hint data to objects and adding to list
                    while (dataReader.Read())
                    {
                        Hint hint = new Hint();
                        string hintTxt = dataReader.GetString("hint");
                        string hintCeleb = dataReader.GetString("actor_name");
                        //Matching quote data with data from the other tables
                        foreach (Celebrity celeb in celebrities)
                        {
                            if (celeb.Name == hintCeleb) // If celeb matches celeb in the hint, add that celeb to the hint object
                            {
                                hint.Celebrity = celeb;
                                hint.HintText = hintTxt;
                            }
                        }
                        hints.Add(hint); // Add hint to the hints list
                    }

                }
                using (MySqlCommand command = new MySqlCommand(actorMovieQuery, connection))
                //Using the ActorMovies junction table to fill the actors list in each movie object
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string movieName = dataReader.GetString("movie_name");
                        string celebName = dataReader.GetString("actor_name");
                        //For each movie in the movie list, go through each celebrity in the celebrity list
                        //and find which ones match the movie in the actorMovies table, then add them to 
                        //the "Actors" list that is in each movie object
                        foreach (Film movie in movies)
                        {
                            if (movieName == movie.Name.ToString())
                            {
                                foreach (Celebrity celebrity in celebrities)
                                {
                                    if (celebName == celebrity.Name.ToString())
                                    {
                                        movie.Actors.Add(celebrity);
                                    }
                                }
                            }
                        }
                    }

                }
            }

        }

        //Function for adjusting visibility of components for starting the game
        void startGame()
        {
            celebrities.Clear();
            quotes.Clear();
            movies.Clear();
            hints.Clear();
            score = 0;
            scoreNumbLbl.Text = score.ToString() + "/10";
            incorrectGuesses = 0;
            redX1.Visible = false;
            redX2.Visible = false;
            redX3.Visible = false;
            skipPbx.Visible = true;
            hintPbx.Visible = true;
            xPbx.Visible = true;
            movieDescriptionPbx.Visible = true;
            loadData();
            displayRules();
            startRound();

        }

        //Function for adjusting visibility for starting round and adding logic
        void startRound()
        {
            choose1Btn.Visible = true;
            choose2Btn.Visible = true;
            choose3Btn.Visible = true;
            celebLbl1.Tag = null;
            celebLbl2.Tag = null;
            celebLbl3.Tag = null;

            chosenQuoteIndex = randomNumb.Next(quotes.Count); // Choosing quote by having a random number as the index value of the quotes list
            Quote chosenQuote = quotes[chosenQuoteIndex]; // Creating quote object for the chosen quote
            List<Celebrity> otherCelebrities = new List<Celebrity>(); // Creating celebrities list of celebrities that are NOT the chosen quote celebrities

            foreach (Celebrity celeb in celebrities) // Creating a list of celebrities that are incorrect answers
            {
                if (chosenQuote.Celebrity != celeb)
                {
                    otherCelebrities.Add(celeb);
                }
            }
            Celebrity randomCeleb1 = otherCelebrities[randomNumb.Next(otherCelebrities.Count)]; // Coming up with random celebrities to display next to the correct one
            otherCelebrities.Remove(randomCeleb1); // Removing that celebrity after they are chosen, so that they do not appear twice
            Celebrity randomCeleb2 = otherCelebrities[randomNumb.Next(otherCelebrities.Count)];
            otherCelebrities.Remove(randomCeleb2);

            List<Celebrity> round = new List<Celebrity> { chosenQuote.Celebrity, randomCeleb1, randomCeleb2 }; // Creating a list of all three celebs that will be displayed this round
            round = round.OrderBy(x => randomNumb.Next()).ToList(); // Randomizing the celebrities for this round

            quoteTxtBox1.Text = quotes[chosenQuoteIndex].MovieQuote.ToString(); // Filling the quote textbox with the chosen quote


            assignTextboxes(0, round[0], round[0] == chosenQuote.Celebrity); // Assigning the chosen celebrities to the images and textboxes
            assignTextboxes(1, round[1], round[1] == chosenQuote.Celebrity); // Checking for true or false by seeing if the chosen celebrity matches the celebrity being assigned to the location
            assignTextboxes(2, round[2], round[2] == chosenQuote.Celebrity);
        }

        // Function for assigning each celebrity to their location in the game and assigning the correct answer with a tag
        void assignTextboxes(int celebLocation, Celebrity celeb, bool correctAnswer)
        {
            // Using a switch statement to assign each celebrity to their location and give them a "correct" tag if they are the right answer
            switch (celebLocation)
            {
                case 0:
                    celebLbl1.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl1.Tag = "Correct";
                    }
                    celebPbx1.Image = celeb.Image;
                    break;
                case 1:
                    celebLbl2.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl2.Tag = "Correct";
                    }
                    celebPbx2.Image = celeb.Image;
                    break;
                case 2:
                    celebLbl3.Text = celeb.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl3.Tag = "Correct";
                    }
                    celebPbx3.Image = celeb.Image;

                    break;
            }
        }

        // Function for adding a red X if the answer is incorrect and incrementing number of wrong guesses
        void wrongAnswer()
        {
            PlaySound("incorrect.wav");
            incorrectGuesses++;
            if (incorrectGuesses < 4)
            {
                redXList[incorrectGuesses - 1].Visible = true;
            }
        }



        //Function for running the "Guess the movie" round after an actor is correctly guessed
        void guessTheMovie(Quote chosenQuote)
        {
            MessageBox.Show("You got it correct, it was " + chosenQuote.Celebrity.Name.ToString() + " but can you guess the movie for an extra point?");

            Random randomNumb = new Random(); //Creating a random number to be used to choose the incorrect movies

            List<Film> otherMovies = new List<Film>(); //Creating a list that will contain all incorrect movies
            //Loop through each movie in the movie list
            foreach (Film movie in movies)
            {
                //Loop through each actor associated with the movie
                foreach (Celebrity celebrity in movie.Actors)
                {
                    //Loop thorugh each actor associated with the film in the chosen quote
                    foreach (Celebrity quoteCeleb in chosenQuote.Film.Actors)
                    {
                        //If the movie does not match the correct answer, and
                        //it is a movie that features the same celebrity, add
                        // it to the incorrect answers list
                        if (chosenQuote.Film != movie && celebrity == quoteCeleb)
                        {
                            otherMovies.Add(movie);
                        }
                    }
                }
            }

            Film randomMovie1 = otherMovies[randomNumb.Next(otherMovies.Count)]; //Choose an incorrect answer at random
            otherMovies.Remove(randomMovie1); //Then remove that incorrect answer from the list so it does not appear twice
            Film randomMovie2 = otherMovies[randomNumb.Next(otherMovies.Count)]; //Choose a second incorrect answer at random
            otherMovies.Remove(randomMovie2); //Then remove that incorrect answer from the list aswell

            List<Film> round = new List<Film> { chosenQuote.Film, randomMovie1, randomMovie2 }; //Create a list of each film that will appear in the round
            round = round.OrderBy(x => randomNumb.Next()).ToList(); //Randomize the list

            quoteTxtBox1.Text = quotes[chosenQuoteIndex].MovieQuote.ToString(); //Display the quote

            //Assign each movie to their slots on the UI
            assignMovieTextboxes(0, round[0], round[0] == chosenQuote.Film); //Checking if it is the correct answer and passing the answer in as a bool
            assignMovieTextboxes(1, round[1], round[1] == chosenQuote.Film);
            assignMovieTextboxes(2, round[2], round[2] == chosenQuote.Film);


        }


        //Function for assigning movie information onto the UI for the movie guessing round
        void assignMovieTextboxes(int movieLocation, Film movie, bool correctAnswer)
        {
            //Using a switch statement to assign a movie passed in ro a specific location on the UI
            switch (movieLocation)
            {
                case 0:
                    celebLbl1.Text = movie.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl1.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl1.Tag = null;
                    }
                    celebPbx1.Image = movie.Image;
                    break;
                case 1:
                    celebLbl2.Text = movie.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl2.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl2.Tag = null;
                    }
                    celebPbx2.Image = movie.Image;
                    break;
                case 2:
                    celebLbl3.Text = movie.Name.ToString();
                    if (correctAnswer)
                    {
                        celebLbl3.Tag = "Correct";
                    }
                    else
                    {
                        celebLbl3.Tag = null;
                    }
                    celebPbx3.Image = movie.Image;

                    break;
            }
        }

        //Function that occurs when a user guesses an answer, and checks whether or not its correct
        void chooseButtonClick(Label lbl)
        {
            PlaySound("click.wav");

            bool isCorrect = lbl.Tag != null;

            if (!isCorrect)
            {
                if (!mode)
                {
                    MessageBox.Show("You got it wrong, but that's okay. It was only the bonus round!");
                    quotes.RemoveAt(chosenQuoteIndex);
                    startRound();
                    mode = true;
                }
                else
                {
                    MessageBox.Show("Incorrect!");
                    wrongAnswer();
                    checkForGameOver();
                }
                return; //Return because the incorrect path is handled
            }

            //Correct answer path
            MessageBox.Show("Correct!");
            addToScore();
            checkForGameOver();

            if (mode)
            {
                //Switch to movie guessing mode
                guessTheMovie(quotes[chosenQuoteIndex]);
                mode = false;
            }
            else
            {
                //Movie guessing mode finished, start next round
                quotes.RemoveAt(chosenQuoteIndex);
                startRound();
                mode = true;
            }
        }


        //Function that occurs when the user clicks the skip powerup
        private void skipPbx_Click(object sender, EventArgs e)
        {
            PlaySound("click.wav");
            if (!mode)
            {
                MessageBox.Show("You cannot use a skip in the bonus round!");
            }
            else
            {
                //If user is at less than 9 they can use the skip powerup, essentially giving them a point
                if (score < 9)
                {
                    addToScore();
                    skipPbx.Visible = false;
                    startRound();
                }
                //User cannot use skip powerup to win the game
                else
                {
                    MessageBox.Show("You cannot use the skip powerup when you're at 9/10!");
                }
            }
        }


        //Function for incrementing score when an answer is correctly guessed
        void addToScore()
        {
            PlaySound("correct.wav");
            score++;
            scoreNumbLbl.Text = (score.ToString() + "/10");
        }

        //Function for giving the user a hint when they click on the hint powerup
        private void hintPbx_Click(object sender, EventArgs e)
        {
            PlaySound("click.wav");
            if (!mode)
            {
                MessageBox.Show("You cannot use a hint in the bonus round!");
            }
            else
            {
                hintPbx.Visible = false;
                List<Hint> chosenCelebHint = new List<Hint>(); //Create a list of 10 hints related to the chosen celebrity
                foreach (Hint hint in hints) //Go through the hints list and add each hint matching the chosen celebrity
                                             // to the hints list
                {
                    if (hint.Celebrity.Name == quotes[chosenQuoteIndex].Celebrity.Name) //If hint matches the chosen celebrity, add it to the list
                    {
                        chosenCelebHint.Add(hint);
                    }
                }
                chosenCelebHint = chosenCelebHint.OrderBy(x => randomNumb.Next()).ToList(); //Randomize the order of the hints
                MessageBox.Show("Hint: " + chosenCelebHint[0].HintText.ToString()); //Display the first hint in the randomized list
            }
        }

        //Function for going back to the title screen and changing the UI elements
        void loadTitleScreen()
        {
            TitleScreen titleScreen = new TitleScreen();
            this.Hide();          // hide the current form
            titleScreen.Show();   // show the title screen form
        }

        //Function for displaying the rules of the game
        void displayRules()
        {
            MessageBox.Show("How to play: \n1)A movie quote will be displayed to you\n" +
        "2)You will be given three options of who said the quote" +
        "\n3)If you guess correctly, you will gain a point and proceed to a bonus round. 10 points and you win! if you get it incorrect you will be given an X. Three X's and you lose" +
        "\n4)In the bonus round, you will be given an opportunity to guess which movie the quote is from. If you guess correctly, you gain a point. However, if you guess incorrectly you do NOT gain an X");
        }

        //Function that checks if the game has ended yet
        void checkForGameOver()
        {
            //If the user has lost, tell them and display an option to play again
            if (incorrectGuesses == 3)
            {
                PlaySound("boo.wav");
                MessageBox.Show("You lose!");
                DialogResult gameOver = MessageBox.Show("Play again?", "Game Over", MessageBoxButtons.YesNo);
                if (gameOver == DialogResult.Yes)
                {
                    startGame();

                }
                else
                {
                    loadTitleScreen();
                }
            }
            //If user has won, tell them and display an option to play again
            else if (score == 10)
            {
                PlaySound("cheer.wav");
                MessageBox.Show("You win!");
                DialogResult gameOver = MessageBox.Show("Play again?", "Game Over", MessageBoxButtons.YesNo);
                if (gameOver == DialogResult.Yes)
                {
                    startGame();

                }
                else
                {
                    loadTitleScreen();
                }
            }

        }

        private void movieDescriptionPbx_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The description of the film that the quote belongs to is \n" + quotes[chosenQuoteIndex].Film.Description.ToString());
            movieDescriptionPbx.Visible = false;
        }

        private void xPbx_Click(object sender, EventArgs e)
        {
            List<Label> incorrectLabels = new List<Label>();

            if (celebLbl1.Tag == null)
            {
                incorrectLabels.Add(celebLbl1);
            }
            if (celebLbl2.Tag == null)
            {
                incorrectLabels.Add(celebLbl2);
            }
            if (celebLbl3.Tag == null)
            {
                incorrectLabels.Add(celebLbl3);
            }

            if (incorrectLabels.Count == 0)
            {
                return;
            }

            Label revealed = incorrectLabels[randomNumb.Next(incorrectLabels.Count)];

            MessageBox.Show("The correct answer is NOT " + revealed.Text.ToString());
            xPbx.Visible = false;
        }
        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton == choose1Btn)
            {
                chooseButtonClick(celebLbl1);
            }
            else if (clickedButton == choose2Btn)
            {
                chooseButtonClick(celebLbl2);
            }
            else if (clickedButton == choose3Btn)
            {
                chooseButtonClick(celebLbl3);
            }
        }
    }
}



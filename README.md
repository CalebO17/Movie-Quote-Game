# Movie Quote Trivia Game

## A fully functional trivia game that tests knowledge on movie quotes using a MySQL database and a C# windows form application

This project uses C# with MySQL integration to create a movie trivia game that runs endlessly until the user closes the application. The project was created using knowledge gained from studying Computer Programming & Analysis, as well as various research into concepts I had not learned yet.

## Tech Stack

- C# (.NET 8, Windows Forms)
- MySQL
- Visual Studio
- MySQL Workbench

## Features

- Endless movie quote trivia gameplay
- Three difficulty modes (Easy, Medium, Hard)
- MySQL database for Actors, Movies, Hints, and Quotes
- Bonus rounds and power-up system
- Dynamic score tracking
- Replayable game loop

## Installation

Make sure you have Visual Studio installed to run the C# `.sln` file, along with MySQL or another database tool that can open and run `.sql` files.

To install the Movie Trivia Game, you must first clone the repository to your local PC.

```bash
  git clone https://github.com/CalebO17/Movie-Quote-Game
```

Open the `personalproject.sql` file inside of the `PersonalProject` folder using your MySQL database tool. Run the code to create the database.

![A screenshot taken inside of MySQL workbench showcasing some of the text of the personalproject MySQL file. ](https://github.com/user-attachments/assets/2c3bfb60-0e1a-4045-8a2d-75cf23e0bff7)

## Environment Variables

To run this project, you will need to add the following environment variables to the project. They can be added via .env files or through environment variables embedded into your software such as Visual Studio.

`DB_SERVER` - The server your database exists on

`DB_PORT` - The port of the database

`DB_USER` - Your MySQL username

`DB_PASSWORD` - Your MySQL password

`DB_NAME` - Your MySQL database name (it should be named movies if you ran the SQL code provided)

Once all of these steps are done, you simply need to run the project and play the game! You can either run the .exe file by opening up the project in Visual Studio and clicking build, then going to your bin/Debug/net8.0-windows folder and clicking it, or you can simply open the `.sln` file, and click the green arrow at the top of the screen.

![Green arrow with the text "PersonalProject" next to it.](https://github.com/user-attachments/assets/9ed4cc38-c52f-4b81-90af-b8c87b65a219)

NOTE: If Visual Studio asks you to install .NET, then you must do it.<img width="1832" height="658" alt="Screenshot 2026-01-12 135248" src="https://github.com/user-attachments/assets/e9a9289a-b5f1-4f64-8e3a-2ddc931a3176" />
<img width="1832" height="658" alt="Screenshot 2026-01-12 135248" src="https://github.com/user-attachments/assets/1789e55a-6a1d-4965-a2af-c989a9489b50" />

<img width="805" height="567" alt="Screenshot 2026-01-12 135301" src="https://github.com/user-attachments/assets/36ef4231-0bcb-45db-931f-23b519b3fc86" />


## How to play

After successfuly installing and running the software, you will be greeted with a title screen with a "Start Game" button.

![Green background and in the center of it is a start game button with two cameras on either side pointing to the button. Text below the button says "Do you want to test your movie knowledge? You're in the right place!](https://github.com/user-attachments/assets/110301f5-1147-47d1-ab52-d150b6d64dd6)


After clicking the button, it will ask you what difficulty you would like to play

![Green background with a caption that says "choose your difficulty. Below it are three boxes saying "easy", "medium" or "hard"](https://github.com/user-attachments/assets/39c82dda-0fd9-4893-a1c4-cdbba45cca87)


- Easy - You need to get 3 correct answers to win. 3 incorrect answers and you lose. Bonus rounds are for extra points but you will not gain an X for incorrectly answering during the bonus round.
- Medium - You will need to get 10 correct answers to win. 2 incorrect answers and you lose. Bonus rounds are mandatory and you will gain an X if you answer incorrectly.
- Hard - You will need to get 25 correct answers to win. 1 incorrect answer and you lose. Bonus rounds are mandatory and you will lose the game if you answer incorrectly. You also cannot use powerups.

After a difficulty is selected, the rules will appear, and the game will begin. You will see...

- A screen with the quote
- Three potential actors
- Three buttons that say "choose"
- Four powerup buttons

![Image displaying a round of the game where the quote is "My planet Arrakis is so beautiful when the sun is low. Rolling over the sands, you can see spice in the air. The three options of who said the quote are displayed along with images of them - Zendaya, Margaret Qualley, and Jennifer Lawrence.](https://github.com/user-attachments/assets/41ff448c-856d-4f63-b581-a110e9cca047)

Each powerup will give a different benefit to the player to assist them in winning the game.

- Skip - Allows the player to skip the current round, giving them a point and beginning a second round with a different quote.

- Hint - Gives the player a random fact about the celebrity who said the quote.

- Movie Description - Gives the player a synopsis of the film that the quote is from.

- X - Tells the player one of the celebrities that is "NOT" correct, essentially giving them a 50/50 chance of guessing the correct answer.

If you guess correctly, you will gain a point and move onto the bonus round. If you guess incorrectly, you will gain an X. ![Image of a message box with the text "You got it correct, it was Zendaya Coleman, but can you guess the movie for an extra point?"](https://github.com/user-attachments/assets/1d256417-8ccc-4633-8d9b-efa1301e1302)



The bonus round is an opportunity to gain an extra point. If you chose "Easy" then you will not gain a red X for guessing incorrectly. However if you chose "Medium" or "Hard" you will gain a red X for answering incorrectly.

![The movie bonus round with the three options as "The Godfather", "The Wild One", and "A Streetcar Named Desire". In the middle of the screen is a white box that says "You got it wrong, but that's okay, it was only the bonus round!" Below that and to the right is a button that says "OK"](https://github.com/user-attachments/assets/b71c4ed9-f811-4d6b-ad2e-25e4f46b8ada)


The cycle of the game will continue until you either gain too many red Xs (depending on your chosen difficulty), or gain the maximum score (also depending on your chosen difficulty). Once the game is over, it will ask you to play again. If you say "No" it will take you back to the title screen. If you say "Yes" it will begin the cycle of the game again.

![A white box that has text at the top which says "Game over". Below that is text that says "Play again" and at the very bottom of the white box are two buttons that say "Yes" and "No"](https://github.com/user-attachments/assets/791a3206-8c45-40a8-86d1-8ec83177cf85)


## Future Improvements

- Expanded database with hundreds of entries in each table
- Background music
- More voiceover during gameplay
- Player prefs (a scoreboard)
- More UI improvements

## Troubleshooting

- Make sure MySQL database is created before launching the game
- Verify environment variables are correctly set
- Ensure the database name matches `Movies`

# License

MIT License

Copyright (c) [2025] [Caleb O'Hara]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Author

Created by Caleb O.  
Developed as a personal project using concepts learned in Computer Programming & Analysis.

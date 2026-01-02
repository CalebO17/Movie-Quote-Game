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

![White text on a black background that showcases cloning a github repo using the command prompt. The command is "git clone https://github.com/CalebO17/Movie-Quote-Game](https://cdn.discordapp.com/attachments/1359281286325469375/1454905376519753809/Screenshot_2025-12-28_133334.png?ex=6952c9b8&is=69517838&hm=0861e3aee5a9d8de470420a5e0d4be963a24f3801c03cda5977c539c317544f4&)

```bash
  git clone https://github.com/CalebO17/Movie-Quote-Game
```

Open the `personalproject.sql` file inside of the `PersonalProject` folder using your MySQL database tool. Run the code to create the database.

![A screenshot taken inside of MySQL workbench showcasing some of the text of the personalproject MySQL file. ](https://cdn.discordapp.com/attachments/1359281286325469375/1454907434513600652/image.png?ex=6952cba3&is=69517a23&hm=7c0ee045ba89c6e6e39e5e47e1659b2bf8534edba308c3ae5594a836fc9d48bc&)

## Environment Variables

To run this project, you will need to add the following environment variables to the project. They can be added via .env files or through environment variables embedded into your software such as Visual Studio.

`DB_SERVER` - The server your database exists on

`DB_PORT` - The port of the database

`DB_USER` - Your MySQL username

`DB_PASSWORD` - Your MySQL password

`DB_NAME` - Your MySQL database name (it should be named movies if you ran the SQL code provided)

Once all of these steps are done, you simply need to run the project and play the game! You can either run the .exe file by opening up the project in Visual Studio and clicking build, then going to your bin/Debug/net8.0-windows folder and clicking it, or you can simply open the `.sln` file, and click the green arrow at the top of the screen.

![Green arrow with the text "PersonalProject" next to it.](https://cdn.discordapp.com/attachments/1359281286325469375/1454909030454526107/image.png?ex=6952cd1f&is=69517b9f&hm=02138dd9a3a72ced2598ae7ad5e9f392abc97a81640ae1a7d3f33c2e04854e70&)

## How to play

After successfuly installing and running the software, you will be greeted with a title screen with a "Start Game" button.

![Green background and in the center of it is a start game button with two cameras on either side pointing to the button. Text below the button says "Do you want to test your movie knowledge? You're in the right place!](https://cdn.discordapp.com/attachments/1359281286325469375/1454895347993280688/Screenshot_2025-12-28_125339.png?ex=6952c061&is=69516ee1&hm=15c1142624e9c5fe127abd1acd3ea6775db3aff073e1918093ec9876d86469db&)

After clicking the button, it will ask you what difficulty you would like to play

![Green background with a caption that says "choose your difficulty. Below it are three boxes saying "easy", "medium" or "hard"](https://cdn.discordapp.com/attachments/1359281286325469375/1454897334747005010/image.png?ex=6952c23b&is=695170bb&hm=a1b835b67ef78fa181480422160006e9aa5077fec6ae26bdc00379a68b7eca8d&)

- Easy - You need to get 3 correct answers to win. 3 incorrect answers and you lose. Bonus rounds are for extra points but you will not gain an X for incorrectly answering during the bonus round.
- Medium - You will need to get 10 correct answers to win. 2 incorrect answers and you lose. Bonus rounds are mandatory and you will gain an X if you answer incorrectly.
- Hard - You will need to get 25 correct answers to win. 1 incorrect answer and you lose. Bonus rounds are mandatory and you will lose the game if you answer incorrectly. You also cannot use powerups.

After a difficulty is selected, the rules will appear, and the game will begin. You will see...

- A screen with the quote
- Three potential actors
- Three buttons that say "choose"
- Four powerup buttons

![Green background with a textbox at the top that says "Quote". In a textbox below that it says "We have hope. All rebellions are built on hope.". On the top left corner of the screen is a label that says "Score" and one below that says "0/10". In the middle of the screen are three buttons that say "Choose" with images of celebrities and names below those images. The celebrities featured are Felicity Jones, Zendaya Coleman, and Hunter Schafer. At the very bottom of the screen are four images each representing a "power-up". On the left there is a "skip" symbol similar to what would be seen on a television remote. This represents the "skip" powerup. To the right of this there is a question mark. This represents the "hint" powerup. To the right of the hint powerup is an image of a camera, this represents the "movie description" powerup. Finally, the powerup on the rightmost part of the screen is the "X" powerup, represented by a big black "X" ](https://cdn.discordapp.com/attachments/1359281286325469375/1454898790485065729/image.png?ex=6952c396&is=69517216&hm=46e231fa6733d0f11e031b95d9613a1be37c36d476cd9d846023ff6d0e4d413a&)

Each powerup will give a different benefit to the player to assist them in winning the game.

- Skip - Allows the player to skip the current round, giving them a point and beginning a second round with a different quote.

- Hint - Gives the player a random fact about the celebrity who said the quote.

- Movie Description - Gives the player a synopsis of the film that the quote is from.

- X - Tells the player one of the celebrities that is "NOT" correct, essentially giving them a 50/50 chance of guessing the correct answer.

If you guess correctly, you will gain a point and move onto the bonus round. If you guess incorrectly, you will gain an X. ![Green background with a textbox at the top that says "Quote". In a textbox below that it says "We have hope. All rebellions are built on hope.". On the top left corner of the screen is a label that says "Score" and one below that says "1/10". Near the right corner of the screen is a red X representing a single incorrectly guessed answer. In the middle of the screen are three buttons that say "Choose" with images of films and the names of the films below those images. The films featured are "The Theory of Everything","Rogue One: A Star Wars Story", and "Train Dreams". At the very bottom of the screen are four images each representing a "power-up". On the left there is a "skip" symbol similar to what would be seen on a television remote. This represents the "skip" powerup. To the right of this there is a question mark. This represents the "hint" powerup. To the right of the hint powerup is an image of a camera, this represents the "movie description" powerup. Finally, the powerup on the rightmost part of the screen is the "X" powerup, represented by a big black "X" ](https://cdn.discordapp.com/attachments/1359281286325469375/1454901582595620994/image.png?ex=6952c630&is=695174b0&hm=6ad22084570a3f446d6307917bbe59870c4b27285f2eb1317774a244326e10bb&)

The bonus round is an opportunity to gain an extra point. If you chose "Easy" then you will not gain a red X for guessing incorrectly. However if you chose "Medium" or "Hard" you will gain a red X for answering incorrectly.

![A white box that says "You got it wrong, but that's okay, it was only the bonus round!" Below that and to the right is a button that says "OK"](https://cdn.discordapp.com/attachments/1359281286325469375/1454902937569591493/image.png?ex=6952c773&is=695175f3&hm=f16b8882e246343abc1907770c16553bdcbb78167591cc4bc357405d8424879d&)

The cycle of the game will continue until you either gain too many red Xs (depending on your chosen difficulty), or gain the maximum score (also depending on your chosen difficulty). Once the game is over, it will ask you to play again. If you say "No" it will take you back to the title screen. If you say "Yes" it will begin the cycle of the game again.

![A white box that has text at the top which says "Game over". Below that is text that says "Play again" and at the very bottom of the white box are two buttons that say "Yes" and "No"](https://cdn.discordapp.com/attachments/1359281286325469375/1454903768976982167/image.png?ex=6952c839&is=695176b9&hm=831d8888d30f9891a5a636c53ed7efe8e4de3075af340f06fc7d41e9e34f4cc2&)

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

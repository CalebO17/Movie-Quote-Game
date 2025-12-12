DROP SCHEMA IF EXISTS Movies;

CREATE SCHEMA Movies;
USE Movies;

CREATE TABLE Actors (
actor_id INT AUTO_INCREMENT PRIMARY KEY,
actor_name VARCHAR(50),
birthday DATE,
actor_image_directory VARCHAR(75)
);

CREATE TABLE Movies (
movie_id INT AUTO_INCREMENT PRIMARY KEY,
movie_name VARCHAR(100),
movie_release_date DATE,
movie_director VARCHAR(50),
movie_description VARCHAR(300),
movie_image_directory VARCHAR(100)
);

CREATE TABLE Quotes (
quote_id INT AUTO_INCREMENT PRIMARY KEY,
quote_line VARCHAR (200),
actor_id INT, 
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
movie_id INT,
FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

CREATE TABLE Hints (
hint_id INt AUTO_INCREMENT PRIMARY KEY,
actor_id INT,
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
hint VARCHAR(250)
);

CREATE TABLE ActorMovies (
actor_id INT NOT NULL,
movie_id INT NOT NULL,
primary key (actor_id, movie_id),
FOREIGN KEY (actor_id) REFERENCES Actors(actor_id),
FOREIGN KEY (movie_id) REFERENCES Movies(movie_id)
);

INSERT INTO Actors (actor_name, birthday, actor_image_directory) VALUES
('Samuel L. Jackson', '1948-12-21', 'SamJackson'),
('Anya Taylor-Joy', '1996-04-16', 'AnyaTaylorJoy'),
('Andrew Garfield', '1983-08-20', 'AndrewGarfield'),
('Robert Redford', '1936-08-18', 'RobertRedford'),
('Jennifer Lawrence', '1990-08-15', 'JenniferLawrence'),
('Elizabeth Olsen', '1989-02-16', 'ElizabethOlsen'),
('Tom Hanks', '1956-07-09', 'TomHanks'),
('Zendaya Coleman', '1996-09-01', 'Zendaya'),
('Hunter Schafer', '1998-12-31', 'HunterSchafer');
INSERT INTO Movies (movie_name, movie_release_date, movie_director, movie_description, movie_image_directory) VALUES
('Pulp Fiction', '1994-10-14', 'Quentin Tarantino', 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 'PulpFiction'),
('The Long Kiss Goodnight', '1996-10-07', 'Renny Harlin', 'Government agents come after an amnesiac woman, who gradually remembers her past.', 'TheLongKissGoodnight'),
('Unbreakable', '2000-11-22', 'M. Night Shyamalan', 'A man learns something extraordinary about himself after a devastating accident.', 'Unbreakable'),
('Coach Carter', '2005-01-14', 'Thomas Carter', 'Controversy surrounds high school basketball coach Ken Carter after he benches his entire team for breaking their academic contract with him.', 'CoachCarter'),
('A Time To Kill', '1996-07-24', 'Joel Schumacher', 'A young Mississippi lawyer defends a black man who killed the two white men that assaulted his preteen daughter.', 'ATimeToKill'),
('The Menu', '2022-11-18', 'Mark Mylod', 'A young couple travels to a remote island to eat at an exclusive restaurant where the chef has prepared a lavish menu, with some shocking surprises.', 'TheMenu'),
('The Witch', '2016-02-19', 'Robert Eggers', 'In 1630, a farmer relocates his family to a remote plot of land on the edge of a forest where strange, unsettling things happen.', 'TheWitch'),
('Split', '2017-01-20', 'M. Night Shyamalan', 'A man with multiple personalities abducts three teenage girls, forcing them to adapt and survive as he reveals his hidden persona.', 'Split'),
('Glass', '2019-01-18', 'M. Night Shyamalan', 'Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities.', 'Glass'),
('The Social Network', '2010-10-01', 'David Fincher','As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business.', 'TheSocialNetwork'),
('Tick Tick Boom', '2021-11-19', 'Lin-Manuel Miranda', 'On the brink of turning 30, a promising theater composer navigates love, friendship and the pressure to create something great before time runs out.', 'TickTickBoom'),
('The Amazing Spider-Man', '2012-07-03', 'Marc Webb', 'After being bitten by a genetically altered spider, Peter Parker gains incredible powers and becomes Spider-Man.', 'TheAmazingSpiderman'),
('The Amazing Spider-Man 2', '2014-05-02', 'Marc Webb', 'Spider-Man faces new challenges as he confronts Electro and Green Goblin while trying to protect Gwen Stacy.', 'TheAmazingSpiderman2'),
('Hacksaw Ridge', '2016-11-04', 'Mel Gibson', 'WWII American Army Medic Desmond T. Doss refuses to kill people and becomes the first man in American history to receive the Medal of Honor without firing a shot.', 'HacksawRidge'),
('Butch Cassidy and the Sundance Kid', '1969-09-24', 'George Roy Hill', 'In 1890s Wyoming, Butch Cassidy and The Sundance Kid lead a band of outlaws and flee a relentless posse after a train robbery goes wrong.', 'ButchCassidyAndTheSundanceKid'),
('The Sting', '1973-12-25', 'George Roy Hill', 'Two grifters team up to pull off the ultimate con against a mob boss.', 'TheSting'),
('All the President’s Men', '1976-04-09', 'Alan J. Pakula', 'The Washington Post reporters uncover the Watergate scandal that leads to the resignation of President Nixon.', 'AllThePresidentsMen'),
('The Natural', '1984-05-11', 'Barry Levinson', 'An unknown baseball player with a mysterious past comes to the big leagues and inspires his team to win.', 'TheNatural'),
('The Old Man & the Gun', '2018-09-28', 'David Lowery', 'Based on the true story of Forrest Tucker, who escaped from San Quentin and carried out an unprecedented string of heists.', 'TheOldManAndTheGun'),
('Don\'t Look Up', '2021-12-10', 'Adam McKay', 'Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.', 'DontLookUp'),
('The Hunger Games', '2012-03-23', 'Gary Ross', 'Katniss Everdeen volunteers to take her sister\'s place in a televised fight to the death.', 'TheHungerGames'),
('Silver Linings Playbook', '2012-11-21', 'David O. Russell', 'After a stint in a mental institution, a former teacher meets a mysterious woman with her own problems.', 'SilverLiningsPlaybook'),
('American Hustle', '2013-12-13', 'David O. Russell', 'A con artist and his partner are forced to work for a wild FBI agent to catch corrupt politicians.', 'AmericanHustle'),
('Joy', '2015-12-25', 'David O. Russell', 'A woman rises to become founder of a powerful business dynasty.', 'Joy'),
('Wind River', '2017-08-04', 'Taylor Sheridan', 'An FBI agent teams with a veteran tracker to investigate a murder on a Native American reservation.', 'WindRiver'),
('Avengers: Age of Ultron', '2015-05-01', 'Joss Whedon', 'Earth\'s mightiest heroes must reunite to stop the villainous Ultron from enacting his plan of human extinction.', 'AvengersAgeOfUltron'),
('Doctor Strange in the Multiverse of Madness', '2022-05-06', 'Sam Raimi', 'Doctor Strange and Wanda Maximoff traverse alternate realities to face unimaginable consequences.', 'DoctorStrangeInTheMultiverseOfMadness'),
('Forrest Gump', '1994-07-06', 'Robert Zemeckis', 'A simple man with a low IQ recounts his extraordinary life and the events that shaped him.', 'ForrestGump'),
('Cast Away', '2000-12-22', 'Robert Zemeckis', 'After a plane crash, a FedEx employee struggles to survive alone on a deserted island.', 'CastAway'),
('Saving Private Ryan', '1998-07-24', 'Steven Spielberg', 'U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.', 'SavingPrivateRyan'),
('Big', '1988-06-03', 'Penny Marshall', 'A young boy makes a wish to be big and wakes up as an adult.', 'Big'),
('Catch Me If You Can', '2002-12-25', 'Steven Spielberg', 'The true story of Frank Abagnale Jr., who successfully conned millions of dollars before his 19th birthday.', 'CatchMeIfYouCan'),
('Dune', '2021-10-22', 'Denis Villeneuve', 'Paul Atreides arrives on Arrakis after his father accepts stewardship of the dangerous planet. Chaos ensues after betrayal as forces clash for control of spice.', 'Dune'),
('Spider-Man: Homecoming', '2017-07-07', 'Jon Watts', 'Peter Parker balances high school life with being Spider-Man under Tony Stark\'s mentorship.', 'SpidermanHomecoming'),
('The Greatest Showman', '2017-12-20', 'Michael Gracey ', 'The story of American showman P.T. Barnum, founder of the circus that became the famous traveling Ringling Bros. and Barnum & Bailey Circus.', 'TheGreatestShowman'),
('Challengers', '2024-04-26', 'Luca Guadagnino', 'A tennis coach faces off against her husband and ex-lover in a competitive tournament.', 'Challengers'),
('Cuckoo', '2024-08-29', 'Tilman Singer', 'A 17-year-old is forced to move with her family to a resort where things are not what they seem.', 'Cuckoo'),
('Belle', '2021-07-16', 'Mamoru Hosoda', 'A shy high school student becomes a world-famous singer in a massive virtual world.', 'Belle'),
('The Hunger Games: The Ballad of Songbirds and Snakes', '2023-11-17', 'Francis Lawrence', 'Coriolanus Snow mentors Lucy Gray Baird during the 10th Hunger Games.', 'TheHungerGamesTheBalladOfSongbirdsAndSnakes');



INSERT INTO Quotes (quote_line, actor_id, movie_id) VALUES
('Mmm, This Is A Tasty Burger!', 1, 1),
('Other charcter: Were you always this stupid, or did you take lessons? _________: I took lessons.', 1,2),
('Now that... is a cheeseburger.', 2, 6),
('You better lawyer up, because I\'m not coming back for 30%, I\'m coming back for EVERYTHING.', 3, 10),
('You just keep thinking, Butch. That\'s what you\'re good at', 4, 15),
('I\'m not on a diet. I\'m just crying five times a day', 5, 20),
('How far do you think someone could run barefoot out here?', 6, 25),
('Stupid is as stupid does', 7, 28),
('My planet Arrakis is so beautiful when the sun is low. Rolling over the sands. You can see spice in the air', 8, 33),
('We\'ve gotten through worse than this. Snow lands on top', 9, 39);

INSERT INTO Hints (actor_id, hint) VALUES
(1, 'This person was an usher at Martin Luther King\'s funeral'),
(1, 'This person is known to actively enjoy watching their own movies'),
(1, 'This person has a clause in their movie contracts that states they are required easy access to golf courses'),
(1, 'This actor/actress is known for their frequent use of the F bomb'),
(1, 'This actor/actress is close friends with Simon Pegg'),
(2, 'This actor/actress was discovered as a model whilst walking their dog'),
(2, 'This person is a fluent Spanish speaker who learned English by reading Harry Potter'),
(2, 'This actor/actress had their first lead role in a Robert Eggers film'),
(2, 'This person is an insomniac'),
(2, 'This person has recieved many accolades including a Golden Globe award in 2020'),
(3, 'This person is known for their chemistry and flirtations with someone who takes people on chicken shop dates'),
(3, 'This person played a superhero'),
(3, 'This person is close friends with Robert Pattinson and Matt Smith'),
(3, 'This actor/actress does not participate in social media'),
(3, 'This persons father is a swimmming coach'),
(4, 'This actor/actress passed away in 2025'),
(4, 'This person dislikes watching his own films'),
(4, 'This actor/actress was considered for a prominent role in the Godfather'),
(4, 'This persons daughter, Shauna, was in a relationship someone who was then murdered on August 1, 1983. The prime suspect has been on the run since 1986 over theft charges.'),
(4, 'This person was once voted the 30th greatest movie star of all time by Entertainment Weekly'),
(5, 'This person once dated an actor who played Lex Luthor'),
(5, 'This actor/actress auditioned for a prominent role in Twilight but lost'),
(5, 'This actor/actress was the second person to play a prominent Marvel character in live action'),
(5, 'This person once had to eat a raw fish for one of their movies'),
(5, 'This person is most well known for playing a character named K______'),
(6, 'This person has two famous sisters'),
(6, 'This actor/actresses favorite film growing up was Tremors'),
(6, 'This person auditioned for a prominent role in Michael Bay\'s TMNT movies, but lost out'),
(6, 'This actor/actress\' middle name is Chase because their parents want them to chase after their siblings'),
(6, 'This person was almost a lead in the new Star Wars trilogy but had scheduling conflicts'),
(7, 'This actor/actress attended Princess Diana\'s funeral'),
(7, 'This person is good friends with Bruce Springsteen'),
(7, 'This person stars in Caleb O\'Haras favorite movie of all time'),
(7, 'This person sold popcorn and peanuts as a teenager'),
(7, 'This person gained 55 pounds and then lost it for a role in a 2000 movie'),
(8, 'This actor/actress is close friends with Hunter Schafer'),
(8, 'This person was in a Kidz Bop music video'),
(8, 'This person was offered a prominent role in a Marvel movie but said no'),
(8, 'This actor/actress is a big fan of Law&Order SVU'),
(8, 'Both of this persons parents are teachers'),
(9, 'This persons first acting role was in a popular HBO television series'),
(9, 'This person studied art in University'),
(9, 'This actor/actress was in prominent headlines in 2016 for their activism'),
(9, 'This person was heavily fancast as a popular video game character, but lost the role to someone else'),
(9, 'This actor/actress was born in New Jersey');

INSERT INTO ActorMovies(actor_id, movie_id) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(2, 6),
(2, 7),
(2, 8),
(2, 9),
(3, 10),
(3, 11),
(3, 12),
(3, 13),
(3, 14),
(4, 15),
(4, 16),
(4, 17),
(4, 18),
(4, 19),
(5, 20),
(5, 21),
(5, 22),
(5, 23),
(5, 24),
(6, 25),
(6, 26),
(6, 27),
(7, 28),
(7, 29),
(7, 30),
(7, 31),
(7, 32),
(8, 33),
(8, 34),
(8, 35),
(8, 36),
(9, 37),
(9, 38),
(9, 39);


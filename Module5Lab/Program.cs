using Module5Lab;
// creating a new player with one life, and add points to the player's score
Player player = new Player("Count MoLouph", 1);
player.AddPoints(100);

SuperPlayer superPlayer = new SuperPlayer();
superPlayer.AddPoints(200);
superPlayer.Fly();
Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");

// display player's score
Console.WriteLine("Welcome to...The Game!\nScore: " + player.GetScore() + "\n" + "Lives: " + player.GetLivesLeft());

// murder
player.Kill();

// deliver the news
Console.WriteLine("An orc leans on a trebuchet opposite you on the field you walk,\naccidentally releasing an explosive barrel that hits you in the back of your head.\nYou have " + player.GetLivesLeft() + " lives left.\nYou are dead.");

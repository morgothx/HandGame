public enum Move
{
	Paper,
	Rock,
	Scissors,
	Lizzard,
	Spock,
}

public class HandGame
{
	public int Player2VictoriesCount
	{
		get;
		private set;
	}
	
	public void Play (IPlayer player1, IPlayer player2)
	{
		if (player2.Move == Move.Scissors)
			player2.VictoriesCount = 1;
		else
			player1.VictoriesCount = 1;
	}
}
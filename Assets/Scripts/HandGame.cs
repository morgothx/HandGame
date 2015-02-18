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
		if (player1.Move == Move.Paper && player2.Move == Move.Rock)
			WinRound(player1);
		if (player1.Move == Move.Paper && player2.Move == Move.Spock)
			WinRound(player1);
		if (player1.Move == Move.Paper && player2.Move == Move.Scissors)
			WinRound(player2);
		if (player1.Move == Move.Paper && player2.Move == Move.Lizzard)
			WinRound(player2);
		
		if (player1.Move == Move.Rock && player2.Move == Move.Scissors)
			WinRound(player1);
		if (player1.Move == Move.Rock && player2.Move == Move.Lizzard)
			WinRound(player1);
		if (player1.Move == Move.Rock && player2.Move == Move.Paper)
			WinRound(player2);
		if (player1.Move == Move.Rock && player2.Move == Move.Spock)
			WinRound(player2);
		
		if (player1.Move == Move.Scissors && player2.Move == Move.Paper)
			WinRound(player1);
		if (player1.Move == Move.Scissors && player2.Move == Move.Lizzard)
			WinRound(player1);
		if (player1.Move == Move.Scissors && player2.Move == Move.Rock)
			WinRound(player2);
		if (player1.Move == Move.Scissors && player2.Move == Move.Spock)
			WinRound(player2);
		
		if (player1.Move == Move.Spock && player2.Move == Move.Scissors)
			WinRound(player1);
		if (player1.Move == Move.Spock && player2.Move == Move.Rock)
			WinRound(player1);
		if (player1.Move == Move.Spock && player2.Move == Move.Paper)
			WinRound(player2);
		if (player1.Move == Move.Spock && player2.Move == Move.Lizzard)
			WinRound(player2);
	}
	
	private void WinRound(IPlayer player)
	{
		player.VictoriesCount++;
	}
}
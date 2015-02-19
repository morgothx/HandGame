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
	
	private IPlayer player1;
	private IPlayer player2;
	
	public void Play (IPlayer player1, IPlayer player2)
	{
		this.player1 = player1;
		this.player2 = player2;
		WinRound(GetWinner());
	}
	
	private IPlayer GetWinner()
	{
		switch (player1.Move)
		{
			case Move.Paper:
				return DeterminateResultAgainstPaper ();
			case Move.Rock:
				return DeterminateResultAgainstRock ();
			case Move.Scissors:
				return DeterminateResultAgainstScissors ();
			case Move.Spock:
				return DeterminateResultAgainstSpock ();
			case Move.Lizzard:
				return DeterminateResultAgainstLizzard ();
			default:
				return player1;
		}
	}
	
	private IPlayer DeterminateResultAgainstPaper ()
	{
		return (player2.Move == Move.Rock || player2.Move == Move.Spock) ? player1 : player2;
	}
	
	private IPlayer DeterminateResultAgainstRock ()
	{
		return (player2.Move == Move.Scissors || player2.Move == Move.Lizzard) ? player1 : player2;
	}

	private IPlayer DeterminateResultAgainstScissors ()
	{
		return (player2.Move == Move.Paper || player2.Move == Move.Lizzard) ? player1 : player2;
	}
	
	private IPlayer DeterminateResultAgainstSpock ()
	{
		return (player2.Move == Move.Scissors || player2.Move == Move.Rock) ? player1 : player2;
	}
	
	private IPlayer DeterminateResultAgainstLizzard ()
	{
		return (player2.Move == Move.Spock || player2.Move == Move.Paper) ? player1 : player2;
	}
	
	private void WinRound(IPlayer player)
	{
		player.VictoriesCount++;
	}
}
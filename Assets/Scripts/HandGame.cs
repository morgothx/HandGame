
public enum MoveType
{
	Paper,
	Rock,
	Scissors,
	Lizzard,
	Spock,
}

public interface Move
{
	bool Beats (MoveType move);
}

public class HandGame
{
	private IPlayer player1;
	private IPlayer player2;
	
	public void Play (IPlayer player1, IPlayer player2)
	{
		this.player1 = player1;
		this.player2 = player2;
		GetWinner ().VictoriesCount ++;
	}
	
	private IPlayer GetWinner()
	{
		if (Moves.Beats (player1.Move, player2.Move))
			return player1;
		else
			return player2;
	}
}

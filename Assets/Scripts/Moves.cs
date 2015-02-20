using System.Collections.Generic;

public class Moves
{
	private static Dictionary<MoveType, Move> moves = new Dictionary<MoveType, Move>
	{
		{ MoveType.Paper, new Paper () },
		{ MoveType.Rock, new Rock () },
		{ MoveType.Scissors, new Scissors () },
		{ MoveType.Lizzard, new Lizzard () },
		{ MoveType.Spock, new Spock () },
	};

	public static bool Beats (MoveType move1, MoveType move2)
	{
		return moves [move1].Beats (move2);
	}
}

public class Paper : Move
{
	public bool Beats (MoveType move)
	{
		return move == MoveType.Rock || move == MoveType.Spock;
	}
}

public class Rock : Move
{
	public bool Beats (MoveType move)
	{
		return move == MoveType.Scissors || move == MoveType.Lizzard;
	}
}

public class Scissors : Move
{
	public bool Beats (MoveType move)
	{
		return move == MoveType.Paper || move == MoveType.Lizzard;
	}
}

public class Lizzard : Move
{
	public bool Beats (MoveType move)
	{
		return move == MoveType.Spock || move == MoveType.Paper;
	}
}

public class Spock : Move
{
	public bool Beats (MoveType move)
	{
		return move == MoveType.Rock || move == MoveType.Scissors;
	}
}

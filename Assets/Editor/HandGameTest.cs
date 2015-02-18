using NUnit.Framework;
using NSubstitute;

[TestFixture]
public class HandGameTest 
{
	private HandGame handGame;
	private IPlayer player1;
	private IPlayer player2;
	
	[SetUp]
	public void SetUp ()
	{
		handGame = new HandGame ();
		player1 = Substitute.For<IPlayer> ();
		player2 = Substitute.For<IPlayer> ();
	}
	
	private void Play (Move player1Move, Move player2Move)
	{
		player1.Move.Returns (player1Move);
		player2.Move.Returns (player2Move);
		handGame.Play (player1, player2);
	}
	
	private void AssertPlayer1Wins(Move player1Move, Move player2Move)
	{
		Play (player1Move, player2Move);
		Assert.AreEqual (1, player1.VictoriesCount);
		Assert.AreEqual (0, player2.VictoriesCount);
	}
	
	private void AssertPlayer2Wins(Move player1Move, Move player2Move)
	{
		Play (player1Move, player2Move);
		Assert.AreEqual (0, player1.VictoriesCount);
		Assert.AreEqual (1, player2.VictoriesCount);
	}
	
	[Test]
	public void AssertPaperBeatsRock ()
	{
		AssertPlayer1Wins (Move.Paper, Move.Rock);
	}
	
	[Test]
	public void AssertPaperBeatsSpock ()
	{
		AssertPlayer1Wins (Move.Paper, Move.Spock);
	}
	
	[Test]
	public void AssertPaperIsBeatedByScissors ()
	{
		AssertPlayer2Wins (Move.Paper, Move.Scissors);
	}
	
	[Test]
	public void AssertPaperIsBeatedByLizzard ()
	{
		AssertPlayer2Wins (Move.Paper, Move.Lizzard);
	}
	
	[Test]
	public void AssertRockBeatsScissors ()
	{
		AssertPlayer1Wins (Move.Rock, Move.Scissors);
	}
	
	[Test]
	public void AssertRockBeatsLizzard ()
	{
		AssertPlayer1Wins (Move.Rock, Move.Lizzard);
	}
	
	[Test]
	public void AssertRockIsBeatedByPaper ()
	{
		AssertPlayer2Wins (Move.Rock, Move.Paper);
	}
	
	[Test]
	public void AssertRockIsBeatedBySpock ()
	{
		AssertPlayer2Wins (Move.Rock, Move.Spock);
	}
	
	[Test]
	public void AssertScissorsBeatsPaper ()
	{
		AssertPlayer1Wins (Move.Scissors, Move.Paper);
	}
	
	[Test]
	public void AssertScissorsBeatsLizzard ()
	{
		AssertPlayer1Wins (Move.Scissors, Move.Lizzard);
	}
	
	[Test]
	public void AssertScissorsIsBeatedByRock ()
	{
		AssertPlayer2Wins (Move.Scissors, Move.Rock);
	}
	
	[Test]
	public void AssertScissorsIsBeatedBySpock ()
	{
		AssertPlayer2Wins (Move.Scissors, Move.Spock);
	}
	
	[Test]
	public void AssertSpockBeatsScissors ()
	{
		AssertPlayer1Wins (Move.Spock, Move.Scissors);
	}
	
	[Test]
	public void AssertSpockBeatsRock ()
	{
		AssertPlayer1Wins (Move.Spock, Move.Rock);
	}
	
	[Test]
	public void AssertSpocksIsBeatedByPaper ()
	{
		AssertPlayer2Wins (Move.Spock, Move.Paper);
	}
	
	[Test]
	public void AssertSpockIsBeatedByLizzard ()
	{
		AssertPlayer2Wins (Move.Spock, Move.Lizzard);
	}
}
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
	
	private void Play (MoveType player1Move, MoveType player2Move)
	{
		player1.Move.Returns (player1Move);
		player2.Move.Returns (player2Move);
		handGame.Play (player1, player2);
	}
	
	private void AssertPlayer1Wins(MoveType player1Move, MoveType player2Move)
	{
		Play (player1Move, player2Move);
		Assert.AreEqual (1, player1.VictoriesCount);
		Assert.AreEqual (0, player2.VictoriesCount);
	}
	
	private void AssertPlayer2Wins(MoveType player1Move, MoveType player2Move)
	{
		Play (player1Move, player2Move);
		Assert.AreEqual (0, player1.VictoriesCount);
		Assert.AreEqual (1, player2.VictoriesCount);
	}
	
	[Test]
	public void AssertPaperBeatsRock ()
	{
		AssertPlayer1Wins (MoveType.Paper, MoveType.Rock);
	}
	
	[Test]
	public void AssertPaperBeatsSpock ()
	{
		AssertPlayer1Wins (MoveType.Paper, MoveType.Spock);
	}
	
	[Test]
	public void AssertPaperIsBeatedByScissors ()
	{
		AssertPlayer2Wins (MoveType.Paper, MoveType.Scissors);
	}
	
	[Test]
	public void AssertPaperIsBeatedByLizzard ()
	{
		AssertPlayer2Wins (MoveType.Paper, MoveType.Lizzard);
	}
	
	[Test]
	public void AssertRockBeatsScissors ()
	{
		AssertPlayer1Wins (MoveType.Rock, MoveType.Scissors);
	}
	
	[Test]
	public void AssertRockBeatsLizzard ()
	{
		AssertPlayer1Wins (MoveType.Rock, MoveType.Lizzard);
	}
	
	[Test]
	public void AssertRockIsBeatedByPaper ()
	{
		AssertPlayer2Wins (MoveType.Rock, MoveType.Paper);
	}
	
	[Test]
	public void AssertRockIsBeatedBySpock ()
	{
		AssertPlayer2Wins (MoveType.Rock, MoveType.Spock);
	}
	
	[Test]
	public void AssertScissorsBeatsPaper ()
	{
		AssertPlayer1Wins (MoveType.Scissors, MoveType.Paper);
	}
	
	[Test]
	public void AssertScissorsBeatsLizzard ()
	{
		AssertPlayer1Wins (MoveType.Scissors, MoveType.Lizzard);
	}
	
	[Test]
	public void AssertScissorsIsBeatedByRock ()
	{
		AssertPlayer2Wins (MoveType.Scissors, MoveType.Rock);
	}
	
	[Test]
	public void AssertScissorsIsBeatedBySpock ()
	{
		AssertPlayer2Wins (MoveType.Scissors, MoveType.Spock);
	}
	
	[Test]
	public void AssertSpockBeatsScissors ()
	{
		AssertPlayer1Wins (MoveType.Spock, MoveType.Scissors);
	}
	
	[Test]
	public void AssertSpockBeatsRock ()
	{
		AssertPlayer1Wins (MoveType.Spock, MoveType.Rock);
	}
	
	[Test]
	public void AssertSpocksIsBeatedByPaper ()
	{
		AssertPlayer2Wins (MoveType.Spock, MoveType.Paper);
	}
	
	[Test]
	public void AssertSpockIsBeatedByLizzard ()
	{
		AssertPlayer2Wins (MoveType.Spock, MoveType.Lizzard);
	}
	
	[Test]
	public void AssertLizzardBeatsSpock ()
	{
		AssertPlayer1Wins (MoveType.Lizzard, MoveType.Spock);
	}
	
	[Test]
	public void AssertLizzardBeatsPaper ()
	{
		AssertPlayer1Wins (MoveType.Lizzard, MoveType.Paper);
	}
	
	[Test]
	public void AssertLizzarIsBeatedByRock ()
	{
		AssertPlayer2Wins (MoveType.Lizzard, MoveType.Rock);
	}
	
	[Test]
	public void AssertLizzardIsBeatedByScissors ()
	{
		AssertPlayer2Wins (MoveType.Lizzard, MoveType.Scissors);
	}
}
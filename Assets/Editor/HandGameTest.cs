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
	
	[Test]
	public void AssertPaperBeatsRock ()
	{
		Play (Move.Paper, Move.Rock);
		Assert.AreEqual (1, player1.VictoriesCount);
		Assert.AreEqual (0, player2.VictoriesCount);
	}
	
	[Test]
	public void AssertScissorsBeatsPaper ()
	{
		IPlayer player1 = Substitute.For<IPlayer> ();
		player1.Move.Returns (Move.Paper);
		
		IPlayer player2 = Substitute.For<IPlayer> ();
		player2.Move.Returns (Move.Scissors);
		
		handGame.Play (player1, player2);
		Assert.AreEqual (0, player1.VictoriesCount );
		Assert.AreEqual (1, player2.VictoriesCount );
	}
}
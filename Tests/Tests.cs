using Lab_9;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void DefineWinner_Test1()
        {
            //Arrange
            Coach coach = new Coach(19, "r", "r");
            Team team1 = new Team(1917, "q", "q", 0, 12, coach);
            Team team2 = new Team(1917, "q", "q", 1, 12, coach);
            Game game = new Game(team1, team2);
            //Act
            Team actual = game.DefineWinner(team1, team2);
            //Assert
            Assert.AreEqual(team2, actual);
        }
        [TestMethod]
        public void DefineWinner_Test2()
        {
            //Arrange
            Coach coach = new Coach(19, "r", "r");
            Team team1 = new Team(1917, "q", "q", 5, 12, coach);
            Team team2 = new Team(1917, "q", "q", 1, 12, coach);
            Game game = new Game(team1, team2);
            //Act
            Team actual = game.DefineWinner(team1, team2);
            //Assert
            Assert.AreEqual(team1, actual);
        }
    }
}
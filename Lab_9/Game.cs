using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Game : IWin
    {
        public delegate void ReadinessToGame(string message);
        public delegate void Finish(string message);
        public event ReadinessToGame OnReadinessToGame;
        public event Finish OnFinish;
        private Team team1;
        private Team team2;

        public Game(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
        public void StartGame(Faculty faculty)
        {
            OnReadinessToGame?.Invoke($"Команди факультету {faculty.NameFaculty} готові до гри.");
        }
        public void FinishGame(Team team)
        {
            OnFinish?.Invoke($"Команда \"{team.Name}\" отримала грошову винагороду - 100 галеон.");
        }
        public Team DefineWinner(Team team1, Team team2)
        {
            if(team1.Goal > team2.Goal)
            {
                return team1;
            }
            return team2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Team
    {
        private int founded;//year
        private string? name;
        private string? colorForm;
        private int goal;
        private int cup;
        private Coach coach;
        public List<Player> players;
        private Broom broom;
        public double Balance { get; set; }
        public int Founded
        {
            get => founded;
            set
            {
                if (value < 1000 || value > 2022) throw new ArgumentOutOfRangeException();
                founded = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                name = value;
            }
        }
        public string ColorForm
        {
            get => colorForm; 
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                colorForm = value;
            }
        }
        public int Goal
        {
            get => goal;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                goal = value;
            }
        }
        public int Cup
        {
            get => cup;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                cup = value;
            }
        }
        public Coach Coach { get => coach; set => coach = value; }
        public Broom Broom { get => broom; set => broom = value; }
        public Team(int founded, string name, string colorForm, int goal, int cup, Coach coach)
        {
            Founded = founded;
            Name = name;
            ColorForm = colorForm;
            Goal = goal;
            Cup = cup;
            Coach = coach;
            players = new List<Player>();
        }
    }
}

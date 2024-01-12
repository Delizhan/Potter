using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Player : IPerson
    {
        private int age;
        private string? firstName;
        private string? lastName;
        private Position position;
        public Position Position { get => position; set => position = value; }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                age = value;
            }
        }

        public Player(int age, string firstName, string lastName, Position position)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}


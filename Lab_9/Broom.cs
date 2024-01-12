using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public abstract class Broom: IBroom, IDescriptionBrooms
    {
        public abstract string Model { get; }
        public abstract int Speed { get; }
        public abstract string Fly();
        public string DescriptionBrooms
        {
            get => "\nМітла \"Блискавка\" - мітла професійного рівня, дуже швидка, дуже чутлива, забезпечена авто-гальмом.\nНа момент випуску це була найкраща гоночна мітла у світі.\n\nМітла \"Німбус-2001\" - мітла \"літає як реактивний літак\", на момент випуску вважалась флагманською версією виробника.\n";
        }
    }
}

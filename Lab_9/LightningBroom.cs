using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class LightningBroom : Broom
    {
        public override string Model => "\"Блискавка\"";

        public override int Speed => 150;

        public override string Fly() => "Дана команда користується мітлою \"Блискавка\".";

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class NimbysBroom: Broom
    {
        public override string Model => "\"Німбус-2001\"";

        public override int Speed => 60;

        public override string Fly() => "Дана команда користується мітлою \"Німбус-2001\".";
    }
}

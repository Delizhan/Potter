using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Faculty : IDescription
    {
        private NameFaculty nameFaculty;
        private Animal animal;
        private string? description;
        public List<Team> teams;
        public NameFaculty NameFaculty 
        { 
            get => nameFaculty;
            set
            {
                nameFaculty = value;
                if (nameFaculty == NameFaculty.gryffindor)
                    description = "Відмінні риси учнів цього факультету: хоробрість, честь, шляхетність.";
                else if (nameFaculty == NameFaculty.hufflepuff)
                    description = "Цінує працьовитість, вірність та чесність.";
                else if (nameFaculty == NameFaculty.ravenclaw)
                    description = "Цінує розум, творчість, дотепність та мудрість.";
                else if (nameFaculty == NameFaculty.slytherin)
                    description = "Цінує хитрість, честолюбство, рішучість, винахідливість.";
            }
        }
        public Animal Animal { get => animal; set => animal = value; }
        public string Description { get => description; }
        public Faculty(NameFaculty nameFaculty, Animal animal)
        {
            NameFaculty = nameFaculty;
            Animal = animal;
            teams = new List<Team>();
        }

    }
}

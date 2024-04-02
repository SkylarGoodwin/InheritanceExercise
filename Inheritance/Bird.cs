using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird() 
        { 
            Extinct = false;
            LegCount = 2;
            Habbitat = "Forrest Canopy";
            Diet = "Bugs";
        }
        public string Coloration { get; set; }
        public bool Flightless { get; set; }
        public bool Migratory { get; set; }
        public double BeakLength { get; set; }
    }
}

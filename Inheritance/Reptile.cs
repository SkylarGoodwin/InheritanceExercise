using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            Extinct = false;
            LegCount = 4;
            Diet = "fruit";
            Habbitat = "Gardens";
        }
        public bool Venomous { get; set; }
        public double TailLength { get; set; }
        public int AliveMYA { get; set; }
        public bool CanSwim { get; set; }


    }
}

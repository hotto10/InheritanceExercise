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
            Name = "Bob";
            Size = "small";
            Legs = 0;
            IsFast = true;
        }

        public string Posion { get; set; }
        public string ColdBlooded { get; set; }
        public string Friendly { get; set; }
        public string Scales { get; set; }
    }
}

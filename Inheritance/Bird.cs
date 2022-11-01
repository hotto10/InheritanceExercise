using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Name = "RawRaw";
            Size = "Medium Sized";
            Legs = 2;
            IsFast = true;
        }

        public bool CanFly { get; set; }
        public bool CanSing { get; set; }
        public bool IsTropical { get; set; }
        public bool CanTalk { get; set; }

    }
}

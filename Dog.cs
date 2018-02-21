using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t6
{
    class Dog
    {
        public string Name { get; set; }
        public String Breed { get; set; }
        public String RegNumber { get; set; }

        public override string ToString()
        {
            return "Dog: " + Name + " is a " + Breed + " and is registered under the registration number " + RegNumber;
        }
    }
}

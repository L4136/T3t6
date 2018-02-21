using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog { Name = "Bobe", Breed = "mudi", RegNumber = "FI12345/14" };
            dogs[1] = new Dog { Name = "Alfa", Breed = "german shepherd", RegNumber = "FI98765/17" };
            dogs[2] = new Dog { Name = "Ritu", Breed = "malinois", RegNumber = "FI91827/05" };
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.ToString());

            }
        }
    }
}

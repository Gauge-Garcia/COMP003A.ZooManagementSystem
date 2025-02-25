using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public class Parrot : Animal
    {
        public Parrot(string name, string species) : base(name, species)
        { }
        public override void MakeSound()
        {
            Console.Write("The Parrot Squawks! ");
        }
    }
}

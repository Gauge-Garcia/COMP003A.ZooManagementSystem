using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public class ZooUtility
    {
        public void DescribeAnimal(string name)
        {
            Console.WriteLine("Animal Name: " + name);
        }

        public void DescribeAnimal(string name, string species)
        {
            Console.WriteLine("Animal Name: " + name);
            Console.WriteLine("Animal Species: " + species);
        }
        public void DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine("Animal Name: " + name);
            Console.WriteLine("Animal Species: " + species);
            Console.WriteLine("Animal Age: " + age);
        }
    }
}

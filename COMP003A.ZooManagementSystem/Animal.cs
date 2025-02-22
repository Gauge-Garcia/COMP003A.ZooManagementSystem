using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    abstract class Animal
    {
        private string _name;
        private string _species;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is required");
                }
            }
        }
        public string Species
        {
            get { return _species; }
            set
            {
                _species = value;
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Species is required");
                }
            }
        }

        public abstract void MakeSound();
    }
}

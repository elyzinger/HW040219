using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        public string _name;
        public Animal(string name)
        {
            _name = name;
        }
        public abstract void MakeSound();

        public override string ToString()
        {
            return $"name: {_name}";
        }
    }
}

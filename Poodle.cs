using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Poodle : Dog
    {
        public string _numberOfPonyTails;
        public Poodle(string name, string FavoriteFood, string numberOfPonyTails) : base (name, FavoriteFood)
        {
            _numberOfPonyTails = numberOfPonyTails;
        }
        public override void bark()
        {
            base.bark();
        }

        public override string ToString()
        {
            return $"numberOfPonyTails: {_numberOfPonyTails} + base.ToString()";
        }
    }
}

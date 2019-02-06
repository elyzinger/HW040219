using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class Dog : Animal
    {
        public string _FavoritFood;
        public Dog(string name, string FavoritFood) : base (name)
        {
            _FavoritFood = FavoritFood;
        }
        public virtual void bark()
        {
            Console.WriteLine("hao hao");
        }

        public override string ToString()
        {
            return $"FavoritFood: {_FavoritFood}  {base.ToString()}";
        }
    }
}

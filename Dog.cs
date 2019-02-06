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
        public Dog(string name, string FavoritFood) : base(name)
        {
            _FavoritFood = FavoritFood;
        }
        public override void MakeSound()
        {
            Bark();
        }
        public virtual void Bark()
        {

        }
        public override string ToString()
        {
            return $"FavoritFood: {_FavoritFood}  {base.ToString()}";
        }
    }
}

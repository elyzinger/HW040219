using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Wolf : Dog
    {
        public string _nameOfPack;
        public Wolf(string name, string FavoritFood, string nameOfPack) : base(name, FavoritFood)
        {
            _nameOfPack = nameOfPack;
        }
        public override void Bark()
        {
            Console.WriteLine("rrrrrrr");
        }

        public override string ToString()
        {
            return $"nameOfPack: {_nameOfPack}  {base.ToString()}";
        }
    }   
}

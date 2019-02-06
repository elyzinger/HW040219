using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class PetWolf : Wolf
    {
        public PetWolf(string name, string FavoritFood, string nameOfPack) : base(name, FavoritFood, nameOfPack)
        {
        }

        public override void Bark()
        {
            Console.WriteLine(".......");
        }
    }
}

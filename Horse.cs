using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Horse : Animal
    {
        public bool _RacingHorse;
        public Horse(string name, bool RacingHorse) : base(name)
        {
            _RacingHorse = RacingHorse;
        }
        public virtual void Neigh()
        {
            Console.WriteLine("aaaaa");
        }

        public override string ToString()
        {
            return $"racing horse: {_RacingHorse} {base.ToString()}";
        }
    }
}

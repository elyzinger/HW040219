using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {

        static void Main(string[] args)
        {
            Wolf a = new Wolf("a", "meat", "brave");
            Poodle doby = new Poodle("doby", "dogly", "2");
            Console.WriteLine(a);
            Animal[] zoo = new Animal[]
            {
                new Poodle ("doby", "dogly", "2" ),
                new Wolf("a", "meat", "brave"),
                new Horse("guko", true),
            };
            Horse[] herde = new Horse[]
            {
                new Horse("titen", true),
                new Horse("brave", false),
                new Horse("goon", false),
                new Horse("polly", true),
            };
                
            AnimalSing(zoo);
            GetRacingHorse(herde);
        }
        public static void AnimalSing(Animal[] v)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine( v[i] );
                }
            }
        public static void GetRacingHorse(Horse[] v)
        {
            for (int i = 0; i < v.Length; i++)
                if(v[i]._RacingHorse == true)
            {
                  Console.WriteLine(v[i]);    
            }
        }
    }
}

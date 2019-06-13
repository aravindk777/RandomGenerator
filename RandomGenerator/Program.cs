using Randomizer.Core.Logic;
using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#*#*#*#\t\t Welcome to Random Generator\t\t *#*#*#*#");
            IRandomize randomizer = new RandomGeneratorLogic();
            //randomizer.Randomize()
        }
    }
}

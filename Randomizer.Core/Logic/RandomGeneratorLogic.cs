using System;
using System.Collections.Generic;
using System.Text;
using Randomizer.Core.Models;

namespace Randomizer.Core.Logic
{
    public class RandomGeneratorLogic : IRandomize
    {
        /// <summary>
        /// generate a given length of numbers randomize by moving position rules from input
        /// </summary>
        /// <param name="input">multi dimensional array input</param>
        /// <param name="startNumber">to begin</param>
        /// <param name="randomGeneratorLength">like 7 or 5</param>
        /// <param name="moveRule">1</param>
        /// <returns></returns>
        public int[] Randomize(int[][] input, int startNumber, int randomGeneratorLength, MovingRules moveRule)
        {
            int[] randomSequence = new int[randomGeneratorLength];

            int counter = 0;
            randomSequence[counter++] = startNumber;
            do
            {

            } while (counter < randomGeneratorLength);

            return randomSequence;
        }
    }
}

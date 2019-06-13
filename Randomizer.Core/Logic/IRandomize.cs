using Randomizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.Core.Logic
{
    public interface IRandomize
    {
        int[] Randomize(int[][] input, int startNumber, int randomGeneratorLength, MovingRules moveRule);
    }
}

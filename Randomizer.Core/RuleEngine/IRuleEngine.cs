using Randomizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.Core.RuleEngine
{
    public interface IRuleEngine
    {
        int[] GetAvailableMoves(int start, int[][] data, MovingRules moveType);
    }
}

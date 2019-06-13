using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Randomizer.Core.Models;

namespace Randomizer.Core.RuleEngine
{
    public class RuleEngine : IRuleEngine
    {
        public int[] GetAvailableMoves(int start, int[][] data, MovingRules moveType)
        {
            int hop = (int) moveType;
            List<int> possibleMoves = new List<int>();
            for(int iOuter = 0; iOuter < data.Length; iOuter++)
            {
                if (data[iOuter].Contains(start))
                {
                    for (int iInner = 0; iInner < data[iOuter].Length; iInner++)
                    {
                        // find the position of the starting element
                        if (data[iOuter][iInner] == start)
                        {
                            int posNextInner = iInner + hop, posNextOuter = iOuter + hop, posPrevInner = iInner - hop, posPrevOuter = iOuter - hop;

                            if (posNextOuter == data.Length) posNextOuter = 0;
                            if (posPrevOuter < 0) posPrevOuter = iOuter + data[iOuter].Length - hop;

                            if (posNextInner == data[iOuter].Length) posNextInner = 0;
                            if (posPrevInner < 0) posPrevInner = iInner + data[iOuter].Length - hop;

                            possibleMoves.Add(data[iOuter][posNextInner]);
                            possibleMoves.Add(data[iOuter][posPrevInner]);
                            possibleMoves.Add(data[posNextOuter][iInner]);
                            possibleMoves.Add(data[posPrevOuter][iInner]);

                            break;
                        }
                    }
                    break;
                }
                else
                    continue;
            }
            return possibleMoves.ToArray();
        }
    }
}

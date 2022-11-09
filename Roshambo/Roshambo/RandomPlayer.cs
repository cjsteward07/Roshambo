using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            name = "Random Player";
        }

        public override Roshambo GenerateRoshambo()
        {
            roshambo = (Roshambo)new Random().Next(3) + 1;
            return roshambo;
        }
    }
}

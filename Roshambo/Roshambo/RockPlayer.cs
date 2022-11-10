using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RockPlayer : Player
    {
        public RockPlayer()
        {
            name = "Rock Player";
            roshambo = Roshambo.Rock;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}

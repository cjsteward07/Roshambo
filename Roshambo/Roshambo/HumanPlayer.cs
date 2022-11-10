using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            name = UserInput.HumanPlayerInputString();
        }

        public override Roshambo GenerateRoshambo()
        {
            return roshambo = UserInput.WeaponSelector();
        }

    }
}

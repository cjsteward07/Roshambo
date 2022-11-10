using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public enum Roshambo
    {
        Rock = 1,
        Paper,
        Scissors
    }
    public abstract class Player
    {
        protected string name;
        protected Roshambo roshambo;

        public abstract Roshambo GenerateRoshambo();

        public string GetName()
        {
            return name;
        }
    }

   


}

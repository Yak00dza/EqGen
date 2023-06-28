using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Variable : Expression
    {
        private char symbol;

        public Variable(char symbol, Expression power)
        {
            this.symbol = symbol;
            this.power = power;
        }

        public Variable(char symbol)
        {
            this.symbol = symbol;
        }
        public override string GetAsLaTeX()
        {
            if (power != null)
            {
                return $"{symbol}^{{{power.GetAsLaTeX()}}}";
            }
            else
            {
                return $"{symbol}";
            }
        }
    }
}

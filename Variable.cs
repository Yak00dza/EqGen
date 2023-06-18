using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen
{
    class Variable : Factor
    {
        private char symbol;

        public Variable(char symbol, Polynominal power)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Fraction : Expression
    {


        private Expression numerator;
        private Expression denominator;
        public Fraction(Expression numerator, Expression denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        public override string GetAsLaTeX()
        {
            string preOut = $"\\frac{{{numerator.GetAsLaTeX()}}}{{{denominator.GetAsLaTeX()}}}";
            if (power != null)
            {
                return ApplyPower(preOut);
            }
            return preOut;
        }

        private string ApplyPower(string input)
        {
            return $"({input})^{power}";
        }
    }
}

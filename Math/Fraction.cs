using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen
{
    class Fraction : Term
    {
        private Polynominal numerator;
        private Polynominal denominator;
        public Fraction(Polynominal numerator, Polynominal denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        public override string GetAsLaTeX()
        {
            return $"\\frac{{{numerator.GetAsLaTeX()}}}{{{denominator.GetAsLaTeX()}}}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen
{
    class Equation
    {
        private Polynominal leftSide;
        private Polynominal rightSide;

        public Equation(Polynominal left, Polynominal right)
        {
            leftSide = left;
            rightSide = right;
        }

        public string GetAsLaTeX()
        {
            return $"{leftSide.GetAsLaTeX()} = {rightSide.GetAsLaTeX()}";
        }
    }
}

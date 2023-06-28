using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Equation
    {

        private Expression leftSide;
        private Expression rightSide;

        public Equation(Expression left, Expression right)
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

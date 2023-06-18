using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Function : Term
    {
        protected string name;
        protected Polynominal argument;

        public Function(string name, Polynominal argument)
        {
            this.name = name;
            this.argument = argument;
        }
        public Function(string name, Term argument)
        {
            this.name = name;
            this.argument = new Polynominal(argument);
        }
        public Function(string name, Factor argument)
        {
            this.name = name;
            this.argument = new Polynominal(argument);
        }

        public override string GetAsLaTeX()
        {
            return $"{name}({argument.GetAsLaTeX()})";
        }
    }
}

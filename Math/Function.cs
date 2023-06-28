using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Function : Expression
    {

        protected string name;
        protected Expression argument;

        public Function(string name, Expression argument)
        {
            this.name = name;
            this.argument = argument;
        }

        public override string GetAsLaTeX()
        {
            return $"{name}({argument.GetAsLaTeX()})";
        }
    }
}

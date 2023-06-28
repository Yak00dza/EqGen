using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class TrigFunction : Function
    {
        public TrigFunction(string name, Expression argument) : base(name, argument)
        {
            
        }

        public override string GetAsLaTeX()
        {
            if (power != null)
            {
                return $"\\{name}^{{{power.GetAsLaTeX()}}}({argument.GetAsLaTeX()})";
            }
            return $"\\{name}({argument.GetAsLaTeX()})";
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class TrigFunction : Function
    {
        public TrigFunction(string name, Polynominal argument) : base(name, argument)
        {
            
        }
        public TrigFunction(string name, Term argument) : base(name, argument)
        {

        }
        public TrigFunction(string name, Factor argument) : base(name, argument)
        {

        }
        public override string GetAsLaTeX()
        {
            return $"\\{name}({argument.GetAsLaTeX()})";
        }    
    }
}

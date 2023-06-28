using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    abstract class Expression
    {
        protected Expression power;

        public abstract string GetAsLaTeX();
        
        public void SetPower(Expression value)
        {
            power = value;
        }
        
    }
}

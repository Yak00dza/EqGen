using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Constant : Expression
    {

        private float value;
        public Constant(float value, Expression power)
        {
            this.value = value;
            this.power = power;
        }
        public Constant(float value)
        {
            this.value = value;
            power = null;
        }

        public override string GetAsLaTeX()
        {
            if (power != null)
            {
                return $"{value}^{{{power.GetAsLaTeX()}}}";
            }
            else
            {
                return $"{value}";
            }
        }

        public bool IsBaseNegative()
        {
            return value < 0;
        }
    }
}

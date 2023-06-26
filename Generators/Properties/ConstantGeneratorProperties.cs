using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Generators.Properties
{
    class ConstantGeneratorProperties
    {
        private int minValue;
        private int maxValue;
        private bool isOutFloat;

        public ConstantGeneratorProperties(int minValue, int maxValue, bool isOutFloat)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.isOutFloat = isOutFloat;

        }
        public bool IsOutFloat()
        {
            return isOutFloat;
        }
        public int GetMinValue()
        {
            return minValue;
        }
        public int GetMaxValue()
        {
            return maxValue;
        }
    }
}

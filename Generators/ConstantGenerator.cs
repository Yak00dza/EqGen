using System;
using EqGen.Generators.Properties;

namespace EqGen.Generators
{
    static class ConstantGenerator
    {

        public static Constant GenerateRandomConstant(ConstantGeneratorProperties properties)
        {
            int min = properties.GetMinValue();
            int max = properties.GetMaxValue();
            if (properties.IsOutFloat())
            {
                return GenerateFloatConstant(min, max);
            }
            return GenerateIntConstant(min, max);
        }

        private static Constant GenerateFloatConstant(int minValue, int maxValue)
        {
            return new Constant(NumberGenerator.GenerateRandomFloat(minValue, maxValue));
        }
        private static Constant GenerateIntConstant(int minValue, int maxValue)
        {
            return new Constant(NumberGenerator.GenerateRandomInt(minValue, maxValue));
        }
    }
}


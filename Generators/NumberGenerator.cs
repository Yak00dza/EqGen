using System;
using SystemMath = System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EqGen.Generators
{
    static class NumberGenerator
    {
        private static readonly int DIGITS_AFTER_COMMA_BY_DEFAULT = 2;
        private static readonly int MAX_DIGITS_AFTER_COMMA = 6;
        private static readonly int MIN_DIGITS_AFTER_COMMA = 1;

        private static Random random = new Random();
        private static int digitsAfterComma = DIGITS_AFTER_COMMA_BY_DEFAULT;

        public static float GenerateRandomFloat(int min, int max)
        {
            float output = random.Next(min+1, max);
            for (int i = 1; i < digitsAfterComma+1; i++)
            {
                output += (float)random.Next(9) * (float)SystemMath.Pow(0.1, i);
            }
            return output;
        }
        public static int GenerateRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static void SetDigitsAfterComma(int value)
        {
            if (value >= MIN_DIGITS_AFTER_COMMA && value <= MAX_DIGITS_AFTER_COMMA)
            {
                digitsAfterComma = value;
            }
        }
    }
}

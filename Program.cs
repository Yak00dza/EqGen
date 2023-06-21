using System;
using EqGen.Math;
using EqGen.Generators;
using EqGen.Generators.Properties;

namespace EqGen
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstantGeneratorProperties properties = new ConstantGeneratorProperties(-5, 15, false);
            ConstantGeneratorProperties propertiesFloat = new ConstantGeneratorProperties(-5, 15, true);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ConstantGenerator.GenerateRandomConstant(properties).GetAsLaTeX());
                Console.WriteLine(ConstantGenerator.GenerateRandomConstant(propertiesFloat).GetAsLaTeX());
            }
            Console.ReadLine();
        }
    }
}

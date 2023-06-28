using System;
using System.Collections.Generic;
using EqGen.Math;
using EqGen.Generators;
using EqGen.Generators.Properties;

namespace EqGen
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplySettings();

            Variable x = new Variable('x', new Constant(2));
            Constant a = new Constant(5, new Constant(3));

            Variable y = new Variable('y');
            Constant b = ConstantGenerator.GenerateRandomConstant(new ConstantGeneratorProperties(-7, -2, false));

            Function f = new Function("f", x);
            TrigFunction sin = new TrigFunction("sin", y);

            Term testTerm = new Term(new List<Expression>() {new Fraction(sin, new Constant(2)), x});

            Polynominal polynominal = new Polynominal(new List<Expression>() {new Variable('z'), sin, b});

            Term term = new Term(new List<Expression>(){x, a, sin, y, testTerm, b, polynominal, f,});

            Console.WriteLine(term.GetAsLaTeX());
            Console.ReadLine();
        }

        static void ApplySettings()
        {
            NumberGenerator.SetDigitsAfterComma(Properties.Settings.Default.numberOfDigitsAfterComma);
        }
    }
}

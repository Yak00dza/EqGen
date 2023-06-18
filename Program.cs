using System;
using System.Collections.Generic;
using EqGen.Math;


namespace EqGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Function f = new Function("f", new Variable('x'));
            Function cosx = new TrigFunction("cos", new Variable('x'));

            Polynominal left = new Polynominal(f);
            Polynominal right = new Polynominal(cosx);

            Equation eq = new Equation(left, right);

            Console.WriteLine(eq.GetAsLaTeX());
            Console.ReadLine();
        }
    }
}

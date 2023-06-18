using System;
using System.Collections.Generic;


namespace EqGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Variable x = new Variable('x', new Constant(2));

            Variable y = new Variable('y');

            Constant a = new Constant(9);
            Constant b = new Constant(-4);
            Constant c = new Constant(3.5f);

            Term term1 = new Term(new List<Factor>() {a, b, c, x, y});
            Term term2 = new Term(new List<Factor>() { b, y });
            Term term3 = new Term(new List<Factor>() {x, new Constant(3)});

            Polynominal poly1 = new Polynominal(new List<Term>() { term1, term2 });
            Polynominal poly2 = new Polynominal(term3);
            Polynominal frac = new Polynominal(new Fraction(poly2, poly1));

            Equation eq = new Equation(poly1, frac);

            Console.WriteLine(x.GetAsLaTeX());
            Console.WriteLine(term1.GetAsLaTeX());
            Console.WriteLine(term2.GetAsLaTeX());
            Console.WriteLine(poly1.GetAsLaTeX());
            Console.WriteLine(eq.GetAsLaTeX());
            Console.ReadLine();
        }
    }
}

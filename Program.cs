using System;
using System.Collections.Generic;


namespace EqGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Variable x = new Variable('x', new Polynominal(new List<Term>() {new Term(new List<Factor>() {new Constant(2)})}));
            Variable y = new Variable('y');

            Constant a = new Constant(9);
            Constant b = new Constant(-4);
            Constant c = new Constant(3.5f);

            Term term1 = new Term(new List<Factor>() {a, b, c, x, y});
            Term term2 = new Term(new List<Factor>() { b, y });

            Polynominal polynom = new Polynominal(new List<Term>() { term1, term2 });

            Console.WriteLine(x.GetAsLaTeX());
            Console.WriteLine(term1.GetAsLaTeX());
            Console.WriteLine(term2.GetAsLaTeX());
            Console.WriteLine(polynom.GetAsLaTeX());

            Console.ReadLine();
        }
    }
}

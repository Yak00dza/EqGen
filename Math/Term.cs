using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Term : Expression
    {
        private List<Expression> factors = new List<Expression>();

        public Term(List<Expression> factors)
        {
            this.factors = factors;
        }
       
        public override string GetAsLaTeX()
        {   
            return $"{ConstantsToLaTeX()}{VariablesToLaTeX()}{FractionsToLaTeX()}{FunctionsToLaTeX()}{TermsToLaTeX()}{PolynominalsToLaTeX()}";
        }

        private string ConstantsToLaTeX()
        {
            List<Constant> constants = factors.OfType<Constant>().ToList();
            List<string> latexContainer = new List<string>();
            for (int i = 0; i < constants.Count; i++)
            {
                Constant obj = constants[i];

                if (obj.IsBaseNegative() && i != 0)
                {
                    latexContainer.Add($"({obj.GetAsLaTeX()})");
                }
                else
                {
                    latexContainer.Add(obj.GetAsLaTeX());
                }
            }

            return string.Join(" \\cdot ", latexContainer);

        }
        private string VariablesToLaTeX()
        {
            List<Variable> variables = factors.OfType<Variable>().ToList();

            List<string> latexContainer = new List<string>();
            foreach (Variable obj in variables)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join("", latexContainer);
        }

        private string FractionsToLaTeX()
        {
            List<Fraction> fractions = factors.OfType<Fraction>().ToList();
            List<string> latexContainer = new List<string>();

            foreach (Fraction obj in fractions)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join("", latexContainer);
        }
        private string FunctionsToLaTeX()
        {
            List<Function> functions = factors.OfType<Function>().ToList();
            List<string> latexContainer = new List<string>();

            foreach (Function obj in functions)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join("", latexContainer);
        }
        private string TermsToLaTeX()
        {
            List<Term> terms = factors.OfType<Term>().ToList();
            List<string> latexContainer = new List<string>();

            foreach (Term obj in terms)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join("", latexContainer);
        }
        private string PolynominalsToLaTeX()
        {
            List<Polynominal> polynominals = factors.OfType<Polynominal>().ToList();
            List<string> latexContainer = new List<string>();

            foreach (Polynominal obj in polynominals)
            {
                latexContainer.Add($"({obj.GetAsLaTeX()})");
            }
            return string.Join("", latexContainer);
        }

        public bool IsFirstFactorNegative()
        {
            return GetAsLaTeX()[0] == '-';
        }

    }
}

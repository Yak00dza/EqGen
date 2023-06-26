using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen
{
    class Polynominal
    {
        List<Term> terms = new List<Term>();
        public Polynominal(List<Term> terms)
        {
            this.terms = terms;
        }
        public Polynominal(Term term)
        {
            terms.Add(term);
        }
        public Polynominal(Factor factor)
        {
            terms.Add(new Term(factor));
        }
        public string GetAsLaTeX()
        {
            List<string> latexContainer = new List<string>();
            for (int i = 0; i < terms.Count; i++)
            {
                Term obj = terms[i];
                if (obj.IsFirstFactorNegative() && i != 0)
                {
                    latexContainer.Add($"({obj.GetAsLaTeX()})");
                }
                else
                {
                    latexContainer.Add(obj.GetAsLaTeX());
                }
            }

            return string.Join(" + ", latexContainer);
        }
    }
    
}

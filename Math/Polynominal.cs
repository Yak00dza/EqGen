using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen.Math
{
    class Polynominal : Expression
    {

        List<Expression> terms = new List<Expression>();
        public Polynominal(List<Expression> terms)
        {
            this.terms = terms;
        }
        
        public override string GetAsLaTeX()
        {
            List<string> latexContainer = new List<string>();
            foreach (Expression obj in terms)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join(" + ", latexContainer).Replace("+ -", "- ");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqGen
{
    class Term
    {
        private List<Factor> factors = new List<Factor>();

        public Term(List<Factor> factors)
        {
            this.factors = factors;
        }
        public Term(Factor factor)
        {
            this.factors.Add(factor);
        }

        public bool IsFirstFactorNegative()
        {
            return GetAsLaTeX()[0] == '-';
        }
        public Term()
        {

        }
        public virtual string GetAsLaTeX()
        {
            List<Constant> constants = factors.OfType<Constant>().ToList();
            List<Variable> variables = factors.OfType<Variable>().ToList();

            string constLaTeX = ConstantsToLaTeX(constants);
            string varLaTeX = VariablesToLaTeX(variables);
            return constLaTeX + varLaTeX;

        }

        private string ConstantsToLaTeX(List<Constant> constants)
        {
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
        private string VariablesToLaTeX(List<Variable> variables)
        {
            List<string> latexContainer = new List<string>();
            foreach (Variable obj in variables)
            {
                latexContainer.Add(obj.GetAsLaTeX());
            }
            return string.Join("", latexContainer);
        }

    }
}

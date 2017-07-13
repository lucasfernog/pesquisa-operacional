using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNL_Mono_Variável.Math;

namespace PNL_Multivariável.Math
{
    class Derivative
    {
        public static Vector gradient(String functionExpression, Vector x)
        {
            Vector gradient = new Vector(x.Count);

            for (int i = 0, n = x.Count; i < n; i++)
            {
                String currentFunction = functionExpression, variable = "";
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                        variable = "x" + (j + 1);
                    else
                        currentFunction = currentFunction.Replace("x" + (j + 1), Utils.round(x[j]).ToString().Replace(",", "."));
                }
                Expression function = new Expression(currentFunction);
                function.defineArgument(variable, 0);
                gradient[i] = PNL_Mono_Variável.Math.Derivative.evalOrder1(function, variable, x[i]);
            }

            return gradient;
        }
    }
}

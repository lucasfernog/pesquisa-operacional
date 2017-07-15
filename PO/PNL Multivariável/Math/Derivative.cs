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

        public static Matrix hessian(String functionExpression, Vector x)
        {
            Matrix hessian = new Matrix(x.Count);

            for (int i = 0, n = x.Count; i < n; i++)
            {
                String variable1 = "x" + (i + 1);

                for (var j = i; j < n; j++)
                {
                    String currentFunction = functionExpression;
                    for (int k = 0; k < n; k++)
                    {
                        if (k != i && k != j)
                            currentFunction = currentFunction.Replace("x" + (k + 1), Utils.round(x[k]).ToString().Replace(",", "."));
                    }
                    Expression function = new Expression(currentFunction);

                    String variable2 = "x" + (j + 1);
                    function.defineArgument(variable1, 0);
                    if (variable2 != variable1)
                        function.defineArgument(variable2, 0);

                    hessian[i, j] = hessian[j, i] = PNL_Mono_Variável.Math.Derivative.derivativeIJ(function, variable1, variable2, x[i], x[j]);
                }
            }

            return hessian;
        }
    }
}

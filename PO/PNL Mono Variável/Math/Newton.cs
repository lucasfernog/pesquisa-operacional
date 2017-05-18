using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Mono_Variável.Math
{
    public class Newton
    {
        private static readonly string VARIABLE = "x";

        public static Response<NewtonStep> eval(String function, double a, double b, double tolerance)
        {
            Response< NewtonStep> response = new Response<NewtonStep>();

            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            int maxIt = 100; //TODO
            int k = 0;

            double x = a, previousX, f1, f2;

            do
            {
                previousX = x;

                f1 = Derivative.evalOrder1(expression, VARIABLE, x);

                if (Double.IsInfinity(f1) || Double.IsNaN(f1))
                    break;
                else if (f1 == 0.0f)
                {
                    break;
                }

                f2 = Derivative.evalOrder2(expression, VARIABLE, x);
                if (Double.IsInfinity(f2) || Double.IsNaN(f2))
                    break;

                x -= f1 / f2;

                //TODO o que fazer se cair nisso na primeira iteração? erro?
                if (Double.IsInfinity(x) || Double.IsNaN(x))
                {
                    x = previousX;
                    break;
                }

                response.Steps.Add(new NewtonStep(k, previousX, x));

                k++;
            } while (k != maxIt && System.Math.Abs(x - previousX) > tolerance);

            response.X = x;
            response.FunctionValue = expression.eval(VARIABLE, x);

            return response;
        }
    }
}

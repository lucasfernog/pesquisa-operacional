using System;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Math
{
    class Bisection
    {
        private static readonly string VARIABLE = "x";

        public static Response eval(String function, double a, double b, double tolerance)
        {
            Response response = new Response();

            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            double xk;
            double derivative1_xk;

            double derivativeTolerance = tolerance / 1000000;

            int k = 0;
            int maxIt = (int) System.Math.Ceiling(System.Math.Log(tolerance / (b - a), 0.5));

            do
            {
                xk = (a + b) / 2;
                derivative1_xk = Derivative.evalOrder1(expression, VARIABLE, xk, tolerance);

                response.Steps.Add(new StepX(k, a, b, xk, derivative1_xk));

                if (derivative1_xk > 0)
                    b = xk;
                else
                    a = xk;

                k++;
            } while (k < maxIt && derivative1_xk != 0.0f);

            response.X = xk;
            response.FunctionValue = expression.eval(VARIABLE, response.X);

            return response;
        }
    }
}

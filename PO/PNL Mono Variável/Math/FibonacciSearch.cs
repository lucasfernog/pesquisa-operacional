using System;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Math
{
    class FibonacciSearch
    {
        private static readonly String VARIABLE = "x";

        private static List<float> fibonacci(double maxValRequired)
        {
            List<float> fibonacci = new List<float>();

            int a = 1, b = 1;
            fibonacci.Add(a);
            fibonacci.Add(b);

            int nextFibonacciVal = 1;

            while (maxValRequired > nextFibonacciVal)
            {
                nextFibonacciVal = a + b;
                a = b;
                b = nextFibonacciVal;
                fibonacci.Add(nextFibonacciVal);
            }

            return fibonacci;
        }

        public static Response<StepAB> eval(String function, double a, double b, double tolerance)
        {
            Response<StepAB> response = new Response<StepAB>();
            
            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            List<float> fibonacciList = fibonacci((b - a) / tolerance);

            int maxIt = fibonacciList.Count;
            int n = fibonacciList.Count - 1;

            int k = 0;

            double mi = a + (fibonacciList[n - 2] / fibonacciList[n]) * (b - a);
            double? f_mi = expression.eval(VARIABLE, mi);
            double lambda = 0;
            double? f_lambda = null;

            do
            {
                //a cada iteração, apenas um ponto precisa ser calculado
                if (f_mi == null)
                {
                    mi = a + (fibonacciList[n - k - 2] / fibonacciList[n - k]) * (b - a);
                    f_mi = expression.eval(VARIABLE, mi);
                }
                else
                {
                    lambda = a + (fibonacciList[n - k - 1] / fibonacciList[n - k]) * (b - a);
                    f_lambda = expression.eval(VARIABLE, lambda);
                }

                response.Steps.Add(new StepAB(k, mi, lambda, (double) f_mi, (double) f_lambda));

                if (f_mi > f_lambda)
                {
                    a = mi;
                    mi = lambda;
                    f_mi = f_lambda;
                    f_lambda = null; //na próxima iteração, é necessário calcular lambda
                }
                else
                {
                    b = lambda;
                    lambda = mi;
                    f_lambda = f_mi;
                    f_mi = null; //na próxima iteração, é necessário calcular mi
                }

                k++;
            } while (k < maxIt && System.Math.Abs(b - a) >= tolerance);
           
            response.X = (a + b) / 2;
            response.FunctionValue = expression.eval(VARIABLE, response.X);

            return response;
        }
    }
}

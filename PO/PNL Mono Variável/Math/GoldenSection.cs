using System;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Math
{
    class GoldenSection
    {
        private static readonly String VARIABLE = "x";
        private static readonly double GOLDEN_SECTION_NUMBER = (System.Math.Sqrt(5) - 1) / 2;
        private static readonly double ONE_MINUS_GOLDEN_SECTION_NUMBER = 1 - GOLDEN_SECTION_NUMBER;
        
        public static Response<StepAB> eval(String function, double a, double b, double tolerance)
        {
            Response<StepAB> response = new Response<StepAB>();

            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            int maxIt = (int) System.Math.Ceiling(
                System.Math.Log(GOLDEN_SECTION_NUMBER / (b - a)) / 
                System.Math.Log(GOLDEN_SECTION_NUMBER));

            int k = 0;

            double mi = a + ONE_MINUS_GOLDEN_SECTION_NUMBER * (b - a);
            double? f_mi = expression.eval(VARIABLE, mi);
            double lambda = 0;
            double? f_lambda = null;
            
            do
            {
                //a cada iteração, apenas um ponto precisa ser calculado
                if (f_mi == null)
                {
                    mi = a + ONE_MINUS_GOLDEN_SECTION_NUMBER * (b - a);
                    f_mi = expression.eval(VARIABLE, mi);
                }
                else
                {
                    lambda = a + GOLDEN_SECTION_NUMBER * (b - a);
                    f_lambda = expression.eval(VARIABLE, lambda);
                }

                response.Steps.Add(new StepAB(k, mi, lambda, (double)f_mi, (double)f_lambda));

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

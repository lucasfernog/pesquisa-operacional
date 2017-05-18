using System;

namespace PNL_Mono_Variável.Math
{
    class DichotomicSearch
    {
        private static readonly String VARIABLE = "x";

        public static Response<DichotomicSearchStep> eval(String function, double a, double b, double delta, double tolerance)
        {
            Response<DichotomicSearchStep> response = new Response<DichotomicSearchStep>();

            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            int k = 0;
            double middle, f_x, f_z, x, z;
            DichotomicSearchStep step;

            while (b - a >= tolerance)
            {
                middle = (a + b) / 2;

                x = middle - delta;
                z = middle + delta;

                f_x = expression.eval(VARIABLE, x);
                f_z = expression.eval(VARIABLE, z);

                step = new DichotomicSearchStep(k, x, z, f_x, f_z);
                response.Steps.Add(step);

                if (step.Is_F_XGreaterThanF_Z)
                    a = x;
                else
                    b = z;
                k++;
            }

            response.X = (a + b) / 2;
            response.FunctionValue = expression.eval(VARIABLE, response.X);

            return response;
        }
    }
}

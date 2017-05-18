using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Mono_Variável.Math
{
    public class UniformSearch
    {
        private static readonly string VARIABLE = "x";

        public static Response<UniformSearchStep> eval(String function, double a, double b, double delta, double tolerance)
        {
            Response<UniformSearchStep> response = new Response<UniformSearchStep>();

            Expression expression = new Expression(function);
            expression.defineArgument(VARIABLE, 0); //definir variável apenas para ser reconhecida pelo checkSyntax

            if (!expression.checkSyntax())
                throw new ArgumentException(expression.getErrorMessage());

            double xk = a;
            double f_xk = expression.eval(VARIABLE, xk);
            double previous_f_xk;
            int k = 0;
            bool found = false;
            UniformSearchStep step;

            while (xk < b && !found)
            {
                xk += delta;
                previous_f_xk = f_xk;
                f_xk = expression.eval(VARIABLE, xk);

                step = new UniformSearchStep(++k, xk, f_xk, previous_f_xk);
                response.Steps.Add(step);

                //refinamento
                if (!step.IsF_xDecreasing)
                {
                    delta = tolerance;
                    //retorna 2 pontos (se possível)
                    UniformSearchStep returnStep = response.Steps[response.Steps.Count == 1 ? 0 : response.Steps.Count - 2];
                    xk = returnStep.X;
                    f_xk = returnStep.F_x;
                    while (xk < b)
                    {
                        xk += delta;
                        previous_f_xk = f_xk;
                        f_xk = expression.eval(VARIABLE, xk);
                        step = new UniformSearchStep(++k, xk, f_xk, previous_f_xk);
                        response.Steps.Add(step);
                        if (!step.IsF_xDecreasing)
                        {
                            found = true;
                            break;
                        }
                    }
                }
            }

            //aceita o ponto anterior como ponto ótimo
            response.X = xk - delta;
            response.FunctionValue = expression.eval(VARIABLE, response.X);

            return response;
        }
    }
}

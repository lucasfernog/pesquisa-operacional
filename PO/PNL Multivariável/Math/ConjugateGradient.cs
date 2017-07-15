using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class ConjugateGradient
    {
        public static Response<StepConjugateGradient> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepConjugateGradient> response = new Response<StepConjugateGradient>();

            int k = 0, n = x.Count;
            Vector oldX, gradient = null, d = null;

            do
            {
                if (k == 0)
                {
                    gradient = Derivative.gradient(function.getExpressionString(), x);
                    d = -gradient;
                }

                oldX = x.clone();
                Matrix hessian = Derivative.hessian(function.getExpressionString(), x);
                double lambda = -((gradient * d) / (d * hessian * d));

                x = oldX + lambda * d;
                Vector gradientK = gradient.clone();
                gradient = Derivative.gradient(function.getExpressionString(), x);

                Vector oldD = d.clone();

                double? beta = null;
                int it = k;
                if (k < n - 1)
                {
                    beta = (gradient * hessian * d) / (d * hessian * d);
                    d = -gradient + (double)beta * d;
                    k++;
                }
                else
                {
                    k = 0;
                }

                response.Steps.Add(new StepConjugateGradient(it, oldX, gradientK, oldD, hessian, lambda, x, gradient, beta));
            } while (k != 0 /* k = 0 quando as N iterações foram realizadas */ || gradient.norm() >= epsilon);

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class FletcherAndReeves
    {
        public static Response<StepFletcherAndReeves> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepFletcherAndReeves> response = new Response<StepFletcherAndReeves>();

            int n = x.Count;
            Vector oldX, gradient = Derivative.gradient(function.getExpressionString(), x), d = -gradient;
            
            while (gradient.norm() >= epsilon)
            {
                int k = 0;
                do
                {
                    oldX = x.clone();
                    double lambda = Utils.lineSearch(function, oldX, d, epsilon);
                    x = oldX + lambda * d;

                    Vector gk = gradient.clone();
                    gradient = Derivative.gradient(function.getExpressionString(), x);

                    double? beta = null;
                    Vector oldD = d.clone();
                    int it = k;
                    if (k < n - 1)
                    {
                        beta = (gradient * gradient) / (gk * gk);
                        d = -gradient + (double) beta * d;
                        k++;
                    }
                    else
                    {
                        k = 0;
                    }

                    response.Steps.Add(new StepFletcherAndReeves(it, oldX, gk, oldD, lambda, x, gradient, beta));
                } while (k != 0 /* k = 0 ao completar as N iterações */);
            }

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class SteepestDescent
    {
        public static Response<StepSteepestDescent> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepSteepestDescent> response = new Response<StepSteepestDescent>();

            Vector gradient;
            int k = 0;
            while((gradient = Derivative.gradient(function.getExpressionString(), x)).norm() >= epsilon)
            {
                k++;
                Vector direction = -gradient;
                double lambda = Utils.lineSearch(function, x, direction, epsilon);
                Vector oldX = x.clone();
                x += lambda * direction;
                response.Steps.Add(new StepSteepestDescent(k, oldX, x, gradient, lambda));
            }

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

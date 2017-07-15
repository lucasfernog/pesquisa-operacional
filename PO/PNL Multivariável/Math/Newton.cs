using PNL_Mono_Variável.Math;
using PNL_Multivariável.Math.MNC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class Newton
    {
        public static Response<StepNewton> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepNewton> response = new Response<StepNewton>();

            Vector gradient, oldX;
            int k = 0;
            do
            {
                k++;
                gradient = Derivative.gradient(function.getExpressionString(), x);
                Matrix hessian = Derivative.hessian(function.getExpressionString(), x);
                Vector w = LinearSystem.solve(hessian, -gradient);
                oldX = x.clone();
                x = oldX + w;

                response.Steps.Add(new StepNewton(k, oldX, gradient, hessian, w, x));

            } while (gradient.norm() >= epsilon && x.distance(oldX) >= epsilon);

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

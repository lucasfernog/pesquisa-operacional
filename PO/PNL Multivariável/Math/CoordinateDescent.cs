using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class CoordinateDescent
    {
        public static Response<StepCoordinateDescent> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepCoordinateDescent> response = new Response<StepCoordinateDescent>();

            int k = 0, n = x.Count;
            Vector oldX, direction = new Vector(n);
            do
            {
                k++;
                oldX = x.clone();
                Vector lambda = new Vector(n);

                for (int j = 0; j < n; j++)
                {
                    direction[j] = 1;
                    lambda[j] = Utils.lineSearch(function, x, direction, epsilon);
                    x[j] += lambda[j];
                    direction[j] = 0;
                }

                response.Steps.Add(new StepCoordinateDescent(k, x.clone(), lambda.clone()));
            } while (x.distance(oldX) >= epsilon);

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

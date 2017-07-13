using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class HookeAndJeeves
    {
        public static Response<StepHookeAndJeeves> eval(Expression function, Vector x, double epsilon)
        {
            Response<StepHookeAndJeeves> response = new Response<StepHookeAndJeeves>();

            int k = 0, n = x.Count;
            Vector oldX = x.clone(), direction = new Vector(n);
            bool flag;

            do
            {
                k++;

                Vector lambda = new Vector(n);

                for (int j = 0; j < n; j++)
                {
                    direction[j] = 1;
                    lambda[j] = Utils.lineSearch(function, x, direction, epsilon);
                    x[j] += lambda[j];
                    direction[j] = 0;
                }

                Vector d = x - oldX;

                Vector xBeforeAdditionalStep = x.clone();
                oldX = xBeforeAdditionalStep;

                flag = d.norm() >= epsilon;

                double? mi = null;
                if (flag)
                {
                    mi = Utils.lineSearch(function, x, d, epsilon);
                    for (int j = 0; j < n; j++)
                        x[j] += (double) mi * d[j];
                }

                response.Steps.Add(new StepHookeAndJeeves(k, xBeforeAdditionalStep, lambda.clone(), 
                    d, mi, mi == null ? null : x.clone()));

            } while (flag);

            response.X = x;
            response.FunctionValue = Utils.eval(function, x);

            return response;
        }
    }
}

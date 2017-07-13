using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class Utils
    {
        public static double round(double value)
        {
            return System.Math.Round(value, 4);
        }

        public static double eval(Expression expression, Vector x)
        {
            int i = 0;
            foreach (double value in x)
            {
                expression.defineArgument("x" + ++i, value);
            }

            return expression.calculate();
        }

        //retorna min function(old + x*direction)
        public static double lineSearch(Expression function, Vector old, Vector direction, double tolerance)
        {
            string expressionString = function.getExpressionString();

            IEnumerator<double> directionEnumerator = direction.GetEnumerator();
            int i = 0;
            foreach (double value in old)
            {
                directionEnumerator.MoveNext();
                expressionString = expressionString.Replace("x" + ++i, "(" + round(value).ToString().Replace(",", ".") + "+x*" + directionEnumerator.Current + ")");
            }

            return Newton.eval(expressionString, 0, 0, tolerance).X;
        }
    }
}

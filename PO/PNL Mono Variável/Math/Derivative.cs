using System;

namespace PNL_Mono_Variável.Math
{
    class Derivative
    {
        public static double evalOrder1(Expression expression, String variable, double variableValue, double errorMax = 0.00001, double hVal = 0.00001, int itMax = 100)
        {
            double h = hVal * 1024;

            double p, q, f1, f2;
            int it = 0;

            f1 = expression.eval(variable, variableValue + h);
            f2 = expression.eval(variable, variableValue - h);

            p = (f1 - f2) / (2 * h);

            do
            {
                it++;
                q = p;
                h /= 2;

                f1 = expression.eval(variable, variableValue + h);
                f2 = expression.eval(variable, variableValue - h);

                p = (f1 - f2) / (2 * h);

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                    return q;
                
            } while (it != itMax && System.Math.Abs(p - q) > errorMax);

            return p;
        }

        public static double evalOrder2(Expression expression, String variable, double variableValue, double errorMax = 0.00001, double hVal = 0.00001, int itMax = 100)
        {
            double h = hVal * 1024;

            double p, q, f1, f2, f3;
            int it = 0;

            f1 = expression.eval(variable, variableValue + 2 * h);
            f2 = expression.eval(variable, variableValue);
            f3 = expression.eval(variable, variableValue - 2 * h);

            p = (f1 - 2 * f2 + f3) / (4 * h * h);

            do
            {
                it++;
                q = p;
                h /= 2;

                f1 = expression.eval(variable, variableValue + 2 * h);

                f2 = expression.eval(variable, variableValue);

                f3 = expression.eval(variable, variableValue - 2 * h);

                p = (f1 - 2 * f2 + f3) / (4 * h * h);

                if (Double.IsInfinity(p) || Double.IsNaN(p))
                {
                    return q;
                }
            } while (it != itMax && System.Math.Abs(p - q) > errorMax);

            return p;
        }

        public static double derivativeIJ(Expression function, String variable1, String variable2, double x1, double x2, double errorMax = 0.00001, double h = 0.00001, int itMax = 100)
        {
            if (variable1 == variable2)
                return derivativeII(function, variable1, x1);
            double p, q;
            int it = 0;

            p = (function.eval(variable1, x1 + h, variable2, x2 + h) -
                function.eval(variable1, x1 + h, variable2, x2 - h) -
                function.eval(variable1, x1 - h, variable2, x2 + h) +
                function.eval(variable1, x1 - h, variable2, x2 - h)) / (4 * (h * h));
            do
            {
                q = p;
                p = (function.eval(variable1, x1 + h, variable2, x2 + h) -
                function.eval(variable1, x1 + h, variable2, x2 - h) -
                function.eval(variable1, x1 - h, variable2, x2 + h) +
                function.eval(variable1, x1 - h, variable2, x2 - h)) / (4 * (h * h));
                if (Double.IsInfinity(p) || Double.IsNaN(p))
                    throw new Exception("Erro ao calcular derivada parcial de segunda ordem");
            } while (it != itMax && System.Math.Abs(p - q) > errorMax);

            return p;
        }

        public static double derivativeII(Expression function, String variable, double x, double errorMax = 0.00001, double h = 0.00001, int itMax = 100)
        {
            double p, q;
            int it = 0;

            p = (function.eval(variable, x + 2 * h) -
                    2 * function.eval(variable, x) +
                    function.eval(variable, x - 2 * h)) / (4 * (h * h));
            do
            {
                q = p;
                p = (function.eval(variable, x + 2 * h) -
                        2 * function.eval(variable, x) +
                        function.eval(variable, x - 2 * h)) / (4 * (h * h));
                if (Double.IsInfinity(p) || Double.IsNaN(p))
                    throw new Exception("Erro ao calcular derivada parcial de ordem segunda");
            } while (it != itMax && System.Math.Abs(p - q) > errorMax);

            return p;
        }
    }
}

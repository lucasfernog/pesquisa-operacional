using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Mono_Variável.Math
{
    public class Expression : org.mariuszgromada.math.mxparser.Expression
    {
        public Expression(String func) : base(func)
        {
        }

        public double eval(String variable, double val)
        {
            setArgumentValue(variable, val);
            return calculate();
        }

        public double eval(String variable1, double val1, String variable2, double val2)
        {
            setArgumentValue(variable1, val1);
            setArgumentValue(variable2, val2);
            return calculate();
        }
    }
}

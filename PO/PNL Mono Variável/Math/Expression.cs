using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Mono_Variável.Math
{
    class Expression : org.mariuszgromada.math.mxparser.Expression
    {
        public Expression(String func) : base(func)
        {
        }

        public double eval(String variable, double val)
        {
            setArgumentValue(variable, val);
            return calculate();
        }
    }
}

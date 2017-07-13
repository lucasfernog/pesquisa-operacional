using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Multivariável.Math
{
    public class StepCoordinateDescent : Step
    {
        [DisplayName("x")]
        public Vector x { get; set; }
        [DisplayName("λ")]
        public Vector lambda { get; set; }

        public StepCoordinateDescent(int k, Vector x, Vector lambda) : base(k)
        {
            this.x = x;
            this.lambda = lambda;
        }
    }
}

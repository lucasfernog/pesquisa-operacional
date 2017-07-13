using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Multivariável.Math
{
    public class StepSteepestDescent : Step
    {
        [DisplayName("x anterior")]
        public Vector previousX { get; set; }

        [DisplayName("x")]
        public Vector x { get; set; }

        [DisplayName("∇f(x)")]
        public Vector gradient { get; set; }

        [DisplayName("|∇f(x)|")]
        public double gradientNorm
        {
            get
            {
                return gradient.norm();
            }
        }

        [DisplayName("λ")]
        public double lambda { get; set; }

        public StepSteepestDescent(int k, Vector previousX, Vector x, Vector gradient, double lambda) : base(k)
        {
            this.previousX = previousX;
            this.x = x;
            this.gradient = gradient;
            this.lambda = lambda;
        }
    }
}

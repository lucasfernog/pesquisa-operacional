using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Multivariável.Math
{
    public class StepNewton : Step
    {
        [DisplayName("x anterior")]
        public Vector oldX { get; set; }

        [DisplayName("∇f(x)")]
        public Vector gradient { get; set; }

        [DisplayName("H(x)")]
        public Matrix hessian { get; set; }

        [DisplayName("w")]
        public Vector w { get; set; }

        [DisplayName("x")]
        public Vector x { get; set; }

        public StepNewton(int k, Vector oldX, Vector gradient, Matrix hessian, Vector w, Vector x) : base(k)
        {
            this.oldX = oldX;
            this.gradient = gradient;
            this.hessian = hessian;
            this.w = w;
            this.x = x;
        }
    }
}

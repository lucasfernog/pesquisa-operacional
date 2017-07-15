using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Multivariável.Math
{
    public class StepFletcherAndReeves : Step
    {
        [DisplayName("x anterior")]
        public Vector oldX { get; set; }

        [DisplayName("∇f(x anterior)")]
        public Vector gk { get; set; }

        [DisplayName("d")]
        public Vector d { get; set; }

        [DisplayName("λ")]
        public double lambda { get; set; }

        [DisplayName("x")]
        public Vector x { get; set; }   

        [DisplayName("∇f(x)")]
        public Vector gNextK { get; set; }

        [DisplayName("β")]
        public double? beta { get; set; }

        public StepFletcherAndReeves(int k, Vector oldX, Vector gk, Vector d, double lambda, Vector x, Vector gNextK, double? beta) : base(k)
        {
            this.oldX = oldX;
            this.gk = gk;
            this.d = d;
            this.lambda = lambda;
            this.x = x;
            this.gNextK = gNextK;
            this.beta = beta;
        }
    }
}

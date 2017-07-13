using PNL_Mono_Variável.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Multivariável.Math
{
    public class StepHookeAndJeeves : Step
    {
        [DisplayName("x")]
        public Vector xBeforeAdditionalStep { get; set; }

        [DisplayName("λ")]
        public Vector lambda { get; set; }

        [DisplayName("d")]
        public Vector d { get; set; }

        [DisplayName("|d|")]
        public double dNorm
        {
            get
            {
                return d.norm();
            }
        }

        [DisplayName("μ")]
        public double? mi { get; set; }

        [DisplayName("x + μd")]
        public Vector xAfterAdditionalStep { get; set; }

        public StepHookeAndJeeves(int k, Vector xBeforeAdditionalStep, Vector lambda, Vector d, double? mi, Vector xAfterAdditionalStep) : base(k)
        {
            this.xBeforeAdditionalStep = xBeforeAdditionalStep;
            this.lambda = lambda;
            this.d = d;
            this.mi = mi;
            this.xAfterAdditionalStep = xAfterAdditionalStep;
        }
    }
}

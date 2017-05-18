using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PNL_Mono_Variável.Math
{
    public class UniformSearchStep : Step
    {
        [DisplayName("x")]
        public double X { get; set; }
        [DisplayName("f(x)")]
        public double F_x { get; set; }
        [DisplayName("f(x) anterior")]
        public double PreviousF_x { get; set; }
        [DisplayName("Decrescente")]
        public Boolean IsF_xDecreasing { get; set; }

        public UniformSearchStep(int K, double X, double F_x, double PreviousF_x)
        {
            this.K = K;
            this.X = X;
            this.F_x = F_x;
            this.PreviousF_x = PreviousF_x;
            this.IsF_xDecreasing = F_x < PreviousF_x;
        }
    }
}

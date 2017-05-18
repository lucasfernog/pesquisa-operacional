using System.ComponentModel;

namespace PNL_Mono_Variável.Math
{
    class DichotomicSearchStep : Step
    {
        [DisplayName("x")]
        public double X { get; set; }

        [DisplayName("z")]
        public double Z { get; set; }

        [DisplayName("f(x)")]
        public double F_X { get; set; }

        [DisplayName("f(z)")]
        public double F_Z { get; set; }

        [DisplayName("f(x) > f(z)")]
        public bool Is_F_XGreaterThanF_Z {get; set;}

        public DichotomicSearchStep(int K, double X, double Z, double F_X, double F_Z)
        {
            this.K = K;
            this.X = X;
            this.Z = Z;
            this.F_X = F_X;
            this.F_Z = F_Z;
            Is_F_XGreaterThanF_Z = F_X > F_Z;
        }
    }
}

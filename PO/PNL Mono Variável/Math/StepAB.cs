using System.ComponentModel;

namespace PNL_Mono_Variável.Math
{
    public class StepAB : Step
    {
        [DisplayName("a")]
        public double A { get; set; }

        [DisplayName("b")]
        public double B { get; set; }

        [DisplayName("f(a)")]
        public double F_A { get; set; }

        [DisplayName("f(b)")]
        public double F_B { get; set; }

        public StepAB(int K, double A, double B, double F_A, double F_B)
        {
            this.K = K;
            this.A = A;
            this.B = B;
            this.F_A = F_A;
            this.F_B = F_B;
        }
    }
}

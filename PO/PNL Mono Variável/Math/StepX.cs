using System.ComponentModel;

namespace PNL_Mono_Variável.Math
{
    public class StepX : Step
    {
        [DisplayName("x")]
        public double X { get; set; }

        [DisplayName("f'(x)")]
        public double F1_X { get; set; }

        [DisplayName("a")]
        public double A { get; set; }

        [DisplayName("b")]
        public double B { get; set; }

        public StepX(int K, double A, double B, double X, double F1_X) 
        {
            this.K = K;
            this.A = A;
            this.B = B;
            this.X = X;
            this.F1_X = F1_X;
        }
    }
}

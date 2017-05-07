using System.ComponentModel;

namespace PNL_Mono_Variável.Math
{
    class NewtonStep : Step
    {
        [DisplayName("x0")]
        public double PreviousX { get; set; }

        [DisplayName("x1")]
        public double X { get; set; }

        [DisplayName("|x1 - x0|")]
        public double Diff
        {
            get
            {
                return System.Math.Abs(X - PreviousX);
            }
        }

        public NewtonStep(int K, double PreviousX, double X) 
        {
            this.K = K;
            this.PreviousX = PreviousX;
            this.X = X;
        }
    }
}

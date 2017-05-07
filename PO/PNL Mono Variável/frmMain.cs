using System;
using PNL_Mono_Variável.Public;
using PNL_Mono_Variável.Math;
using PNL_Mono_Variável.Response;
using System.Windows.Forms;

namespace PNL_Mono_Variável
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new frmHelp().ShowDialog();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtFunction.Text == String.Empty)
                MessageBox.Show("Informe a função a ser analisada");
            else if (txtA.Text == String.Empty)
                MessageBox.Show("Informe o início do intervalo a ser analisado");
            else if (txtB.Text == String.Empty)
                MessageBox.Show("Informe o fim do intervalo a ser analisado");
            else if (txtEpsilon.Text == String.Empty)
                MessageBox.Show("Informe a tolerância ε");
            else
            {
                double a = double.Parse(txtA.Text.Replace(".", ","));
                double b = double.Parse(txtB.Text.Replace(".", ","));
                double tolerance = double.Parse(txtEpsilon.Text.Replace(".", ","));

                if (a > b)
                {
                    double temp = a;
                    a = b;
                    b = temp;
                }

                try
                {
                    Math.Response response = null;
                    if (rdbGoldenSection.Checked)
                    {
                        response = GoldenSection.eval(txtFunction.Text, a, b, tolerance);
                    }
                    else if (rdbFibonacciSearch.Checked)
                    {
                        response = FibonacciSearch.eval(txtFunction.Text, a, b, tolerance);
                    }
                    else if (rdbBisection.Checked)
                    {
                        response = Bisection.eval(txtFunction.Text, a, b, tolerance);
                    }

                    frmResponse frmResponse = new frmResponse();
                    frmResponse.Response = response;
                    frmResponse.ShowDialog();
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message);
                }
            }
        }
    }
}

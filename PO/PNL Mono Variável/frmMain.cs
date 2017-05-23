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
                double a, b, tolerance, delta;
                Expression expression = new Expression(txtA.Text.Replace(",", "."));
                if (!expression.checkSyntax())
                {
                    MessageBox.Show(expression.getErrorMessage());
                    return;
                }
                else
                {
                    a = expression.calculate();
                    expression = new Expression(txtB.Text.Replace(",", "."));
                    if (!expression.checkSyntax())
                    {
                        MessageBox.Show(expression.getErrorMessage());
                        return;
                    }
                    else
                    {
                        b = expression.calculate();
                        expression = new Expression(txtEpsilon.Text.Replace(",", "."));
                        if (!expression.checkSyntax())
                        {
                            MessageBox.Show(expression.getErrorMessage());
                            return;
                        }
                        else
                        {
                            tolerance = expression.calculate();
                        }
                    }
                }

                if (a > b)
                {
                    double temp = a;
                    a = b;
                    b = temp;
                }

                try
                {
                    IResponse response = null;
                    String function = txtFunction.Text;

                    //Busca Uniforme
                    if (rdbUniformSearch.Checked)
                    {
                        expression = new Expression(txtDelta.Text.Replace(",", "."));
                        if (!expression.checkSyntax())
                        {
                            MessageBox.Show(expression.getErrorMessage());
                            return;
                        }
                        else
                        {
                            delta = expression.calculate();
                            response = UniformSearch.eval(function, a, b, delta, tolerance);
                        }
                    }
                    //Busca dicotômica
                    else if (rdbDichotomicSearch.Checked)
                    {
                        expression = new Expression(txtDelta.Text.Replace(",", "."));
                        if (!expression.checkSyntax())
                        {
                            MessageBox.Show(expression.getErrorMessage());
                            return;
                        }
                        else
                        {
                            delta = expression.calculate();
                            response = DichotomicSearch.eval(function, a, b, delta, tolerance);
                        }
                    }
                    //Seção áurea
                    else if (rdbGoldenSection.Checked)
                    {
                        response = GoldenSection.eval(function, a, b, tolerance);
                    }
                    //Busca de Fibonacci
                    else if (rdbFibonacciSearch.Checked)
                    {
                        response = FibonacciSearch.eval(function, a, b, tolerance);
                    }
                    //Bisseção
                    else if (rdbBisection.Checked)
                    {
                        response = Bisection.eval(function, a, b, tolerance);
                    }
                    //Newton
                    else if (rdbNewton.Checked)
                    {
                        response = Newton.eval(function, a, b, tolerance);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um método.");
                        return;
                    }

                    if (response != null)
                        showResponse(response);
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message);
                }
            }
        }

        private void showResponse(IResponse response)
        {
            frmResponse frmResponse = new frmResponse();
            frmResponse.Response = response;
            frmResponse.ShowDialog();
        }

        private void rdbUniformSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtDelta.Enabled = rdbUniformSearch.Checked || rdbDichotomicSearch.Checked;
        }
    }
}

using PNL_Mono_Variável.Math;
using PNL_Multivariável.Math;
using PNL_Multivariável.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNL_Multivariável
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void grdX_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ((DataGridView) sender).Rows[e.Row.Index - 1].HeaderCell.Value = String.Format("{0}", e.Row.Index);
        }

        private void grdX_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (grdX.Columns[e.ColumnIndex].Name == "xi")
            {
                float a = 0.0f;
                string value = e.FormattedValue.ToString();
                if (value != String.Empty && parse(e.FormattedValue.ToString()) == null)
                {
                    grdX.Rows[e.RowIndex].ErrorText = "Valor inválido.";
                    e.Cancel = true;
                }
            }
        }

        private void grdX_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            grdX.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private Expression parse(String what)
        {
            Expression expression = new Expression(what.Replace(",", "."));
            if (!expression.checkSyntax())
            {
                MessageBox.Show(expression.getErrorMessage());
                return null;
            }

            return expression;
        }

        private void showResponse(Math.IResponse response)
        {
            frmResponse frm = new frmResponse()
            {
                Response = response
            };
            frm.ShowDialog();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtFunction.Text == String.Empty)
                MessageBox.Show("Informe a função a ser minimizada.");
            else if (txtEpsilon.Text == String.Empty)
                MessageBox.Show("Informe a tolerância");

            double epsilon;
            Expression epsilonExpression = parse(txtEpsilon.Text);
            if (epsilonExpression == null)
                return;
            epsilon = epsilonExpression.calculate();

            int count = grdX.RowCount, limit = count - 1, i = 0;
            Vector x = new Vector(limit);
            String functionExpression = txtFunction.Text.Replace(",", ".");
            Expression function = new Expression(functionExpression);
            foreach (DataGridViewRow row in grdX.Rows)
            {
                if (i != limit)
                {
                    object value = row.Cells[0].Value;
                    x[i] = value == null || value.ToString() == String.Empty ? 0 : parse(value.ToString()).calculate();
                    function.defineArgument("x" + (i + 1), 0);
                }
                i++;
            }

            if (!function.checkSyntax())
            {
                MessageBox.Show(function.getErrorMessage());
                return;
            }

            function = new Expression(functionExpression); //reset

            Math.IResponse response = null;

            //TODO implement
            if (rdbCoordinateDescent.Checked)
            {
                response = CoordinateDescent.eval(function, x, epsilon);
            }
            else if (rdbHookeAndJeeves.Checked)
            {
                response = HookeAndJeeves.eval(function, x, epsilon);
            }
            else if (rdbGradient.Checked)
            {

            }
            else if (rdbNewton.Checked)
            {

            }
            else if (rdbConjugateGradient.Checked)
            {

            }
            else if (rdbFletcherAndReeves.Checked)
            {

            }
            else if (rdbDavidonFletcherPowell.Checked)
            {

            }
            else
            {
                MessageBox.Show("Selecione um método.");
                return;
            }

            showResponse(response);

        }
    }
}

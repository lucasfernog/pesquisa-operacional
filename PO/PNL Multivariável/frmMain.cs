using PNL_Mono_Variável.Math;
using PNL_Mono_Variável.Response;
using PNL_Multivariável.Math;
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

        private void showResponse(IResponse response)
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

            Expression function = parse(txtFunction.Text);
            double epsilon;

            if (function == null)
                return;

            Expression epsilonExpression = parse(txtEpsilon.Text);
            if (epsilonExpression == null)
                return;
            epsilon = epsilonExpression.calculate();

            Vector<double> x = new Vector<double>();
            int count = grdX.RowCount, i = 0;
            foreach (DataGridViewRow row in grdX.Rows)
            {
                if (++i != count)
                {
                    object value = row.Cells[0].Value;
                    x.AddLast(value == null || value.ToString() == String.Empty ? 0 : parse(value.ToString()).calculate());
                }
            }

            IResponse response = null;

            //TODO implement
            if (rdbConjugateGradient.Checked)
            {

            }
            else if (rdbHookeAndJeeves.Checked)
            {

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

            //showResponse(response);

        }
    }
}

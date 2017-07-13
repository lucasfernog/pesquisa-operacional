using System;
using System.Windows.Forms;
using PNL_Multivariável.Math;
using System.Collections.Generic;

namespace PNL_Multivariável.Response
{
    public partial class frmResponse : Form
    {
        public IResponse Response { get; set; }

        public frmResponse()
        {
            InitializeComponent();
        }

        private void frmResponse_Load(object sender, EventArgs e)
        {
            txtX.Text = Response.X.ToString();
            txtFx.Text = Response.FunctionValue.ToString();

            pnlError.Visible = Response.error != string.Empty;
            lblError.Text = Response.error;

            if (Response.StepsCount == 0)
            {
                dgvSteps.Visible = false;
            }
            else
            {
                dgvSteps.DataSource = Response.StepsList;
                dgvSteps.AutoGenerateColumns = true;

                foreach (DataGridViewColumn column in dgvSteps.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (column.DataPropertyName == "k")
                    {
                        column.DisplayIndex = 0;
                        column.DefaultCellStyle.Format = "N0";
                    }
                    else
                    {
                        column.DefaultCellStyle.Format = "N4";
                    }
                }
            }
        }
    }
}

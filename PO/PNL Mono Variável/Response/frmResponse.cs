using System;
using System.Windows.Forms;
using PNL_Mono_Variável.Math;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Response
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

                    if (column.DataPropertyName == "K")
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

using System;
using System.Windows.Forms;
using PNL_Mono_Variável.Math;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Response
{
    public partial class frmResponse : Form
    {
        public Math.Response Response { get; set; }

        public frmResponse()
        {
            InitializeComponent();
        }

        private void frmResponse_Load(object sender, EventArgs e)
        {
            txtX.Text = Response.X.ToString();
            txtFx.Text = Response.FunctionValue.ToString();

            if (Response.Steps.Count == 0)
            {
                dgvSteps.Visible = false;
            }
            else if (Response.Steps[0] is StepAB)
            {
                List<StepAB> steps = new List<StepAB>();
                foreach (Step step in Response.Steps)
                    steps.Add((StepAB) step);

                dgvSteps.DataSource = steps;
            }
            else if (Response.Steps[0] is StepX)
            {
                List<StepX> steps = new List<StepX>();
                foreach (Step step in Response.Steps)
                    steps.Add((StepX) step);

                dgvSteps.DataSource = steps;
            }

            dgvSteps.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in dgvSteps.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

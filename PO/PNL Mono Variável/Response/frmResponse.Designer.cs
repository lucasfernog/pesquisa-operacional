namespace PNL_Mono_Variável.Response
{
    partial class frmResponse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.grpPoint.SuspendLayout();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPoint
            // 
            this.grpPoint.Controls.Add(this.lblFx);
            this.grpPoint.Controls.Add(this.txtFx);
            this.grpPoint.Controls.Add(this.txtX);
            this.grpPoint.Controls.Add(this.lblX);
            this.grpPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPoint.Location = new System.Drawing.Point(0, 0);
            this.grpPoint.Name = "grpPoint";
            this.grpPoint.Size = new System.Drawing.Size(426, 43);
            this.grpPoint.TabIndex = 0;
            this.grpPoint.TabStop = false;
            this.grpPoint.Text = "Ponto";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFx.Location = new System.Drawing.Point(276, 16);
            this.lblFx.Name = "lblFx";
            this.lblFx.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblFx.Size = new System.Drawing.Size(30, 19);
            this.lblFx.TabIndex = 35;
            this.lblFx.Text = "f(x) =";
            this.lblFx.UseCompatibleTextRendering = true;
            // 
            // txtFx
            // 
            this.txtFx.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFx.Location = new System.Drawing.Point(306, 16);
            this.txtFx.Name = "txtFx";
            this.txtFx.ReadOnly = true;
            this.txtFx.Size = new System.Drawing.Size(117, 20);
            this.txtFx.TabIndex = 34;
            // 
            // txtX
            // 
            this.txtX.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtX.Location = new System.Drawing.Point(22, 16);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(112, 20);
            this.txtX.TabIndex = 32;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblX.Location = new System.Drawing.Point(3, 16);
            this.lblX.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 31;
            this.lblX.Text = "x =";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.UseCompatibleTextRendering = true;
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.Location = new System.Drawing.Point(0, 43);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(426, 20);
            this.pnlError.TabIndex = 4;
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.AllowUserToDeleteRows = false;
            this.dgvSteps.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSteps.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSteps.Location = new System.Drawing.Point(0, 63);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSteps.Size = new System.Drawing.Size(426, 262);
            this.dgvSteps.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(426, 20);
            this.lblError.TabIndex = 40;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.UseCompatibleTextRendering = true;
            // 
            // frmResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 325);
            this.Controls.Add(this.dgvSteps);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.grpPoint);
            this.Name = "frmResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frmResponse_Load);
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            this.pnlError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoint;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvSteps;
    }
}
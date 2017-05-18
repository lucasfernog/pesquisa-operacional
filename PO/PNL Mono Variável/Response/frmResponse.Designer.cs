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
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.grpPoint.SuspendLayout();
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
            this.grpPoint.Size = new System.Drawing.Size(426, 50);
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
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.AllowUserToDeleteRows = false;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSteps.Location = new System.Drawing.Point(0, 50);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.ReadOnly = true;
            this.dgvSteps.Size = new System.Drawing.Size(426, 275);
            this.dgvSteps.TabIndex = 1;
            // 
            // frmResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 325);
            this.Controls.Add(this.dgvSteps);
            this.Controls.Add(this.grpPoint);
            this.Name = "frmResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frmResponse_Load);
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoint;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.DataGridView dgvSteps;
    }
}
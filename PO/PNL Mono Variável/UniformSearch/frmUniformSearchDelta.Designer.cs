namespace PNL_Mono_Variável.UniformSearch
{
    partial class frmUniformSearchDelta
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
            this.grpDelta = new System.Windows.Forms.GroupBox();
            this.lblDelta = new System.Windows.Forms.Label();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpDelta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDelta
            // 
            this.grpDelta.Controls.Add(this.lblDelta);
            this.grpDelta.Controls.Add(this.txtDelta);
            this.grpDelta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDelta.Location = new System.Drawing.Point(0, 0);
            this.grpDelta.Name = "grpDelta";
            this.grpDelta.Size = new System.Drawing.Size(224, 75);
            this.grpDelta.TabIndex = 20;
            this.grpDelta.TabStop = false;
            this.grpDelta.Text = "Delta";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(6, 20);
            this.lblDelta.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(22, 17);
            this.lblDelta.TabIndex = 32;
            this.lblDelta.Text = "Δ =";
            this.lblDelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelta.UseCompatibleTextRendering = true;
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(31, 19);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(187, 20);
            this.txtDelta.TabIndex = 31;
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalc.Location = new System.Drawing.Point(0, 52);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(224, 23);
            this.btnCalc.TabIndex = 21;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmUniformSearchDelta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 75);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpDelta);
            this.Name = "frmUniformSearchDelta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Uniforme";
            this.grpDelta.ResumeLayout(false);
            this.grpDelta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDelta;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Button btnCalc;
    }
}
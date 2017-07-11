namespace PNL_Multivariável
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEpsilon = new System.Windows.Forms.Label();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.grdX = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rdbCoordinateDescent = new System.Windows.Forms.RadioButton();
            this.rdbHookeAndJeeves = new System.Windows.Forms.RadioButton();
            this.rdbGradient = new System.Windows.Forms.RadioButton();
            this.rdbNewton = new System.Windows.Forms.RadioButton();
            this.rdbConjugateGradient = new System.Windows.Forms.RadioButton();
            this.rdbFletcherAndReeves = new System.Windows.Forms.RadioButton();
            this.rdbDavidonFletcherPowell = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEpsilon
            // 
            this.lblEpsilon.AutoSize = true;
            this.lblEpsilon.Location = new System.Drawing.Point(385, 12);
            this.lblEpsilon.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEpsilon.Name = "lblEpsilon";
            this.lblEpsilon.Size = new System.Drawing.Size(19, 17);
            this.lblEpsilon.TabIndex = 38;
            this.lblEpsilon.Text = "ε =";
            this.lblEpsilon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEpsilon.UseCompatibleTextRendering = true;
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(408, 12);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(73, 20);
            this.txtEpsilon.TabIndex = 37;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(39, 12);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(339, 20);
            this.txtFunction.TabIndex = 36;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(6, 12);
            this.lblFunction.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(30, 17);
            this.lblFunction.TabIndex = 35;
            this.lblFunction.Text = "f(x) =";
            this.lblFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFunction.UseCompatibleTextRendering = true;
            // 
            // grdX
            // 
            this.grdX.AllowUserToResizeColumns = false;
            this.grdX.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi});
            this.grdX.Location = new System.Drawing.Point(6, 66);
            this.grdX.Name = "grdX";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Format = "N6";
            dataGridViewCellStyle4.NullValue = null;
            this.grdX.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdX.Size = new System.Drawing.Size(133, 155);
            this.grdX.TabIndex = 39;
            this.grdX.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdX_CellEndEdit);
            this.grdX.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdX_CellValidating);
            this.grdX.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdX_UserAddedRow);
            // 
            // xi
            // 
            this.xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.xi.DefaultCellStyle = dataGridViewCellStyle2;
            this.xi.HeaderText = "x[i]";
            this.xi.Name = "xi";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(7, 40);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(46, 13);
            this.lblX.TabIndex = 40;
            this.lblX.Text = "X inicial:";
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalc.Location = new System.Drawing.Point(0, 239);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(490, 23);
            this.btnCalc.TabIndex = 41;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rdbCoordinateDescent
            // 
            this.rdbCoordinateDescent.AutoSize = true;
            this.rdbCoordinateDescent.Location = new System.Drawing.Point(145, 66);
            this.rdbCoordinateDescent.Name = "rdbCoordinateDescent";
            this.rdbCoordinateDescent.Size = new System.Drawing.Size(129, 17);
            this.rdbCoordinateDescent.TabIndex = 42;
            this.rdbCoordinateDescent.TabStop = true;
            this.rdbCoordinateDescent.Text = "Coordenadas Cíclicas";
            this.rdbCoordinateDescent.UseVisualStyleBackColor = true;
            // 
            // rdbHookeAndJeeves
            // 
            this.rdbHookeAndJeeves.AutoSize = true;
            this.rdbHookeAndJeeves.Location = new System.Drawing.Point(145, 89);
            this.rdbHookeAndJeeves.Name = "rdbHookeAndJeeves";
            this.rdbHookeAndJeeves.Size = new System.Drawing.Size(115, 17);
            this.rdbHookeAndJeeves.TabIndex = 43;
            this.rdbHookeAndJeeves.TabStop = true;
            this.rdbHookeAndJeeves.Text = "Hooke and Jeeves";
            this.rdbHookeAndJeeves.UseVisualStyleBackColor = true;
            // 
            // rdbGradient
            // 
            this.rdbGradient.AutoSize = true;
            this.rdbGradient.Location = new System.Drawing.Point(145, 112);
            this.rdbGradient.Name = "rdbGradient";
            this.rdbGradient.Size = new System.Drawing.Size(71, 17);
            this.rdbGradient.TabIndex = 44;
            this.rdbGradient.TabStop = true;
            this.rdbGradient.Text = "Gradiente";
            this.rdbGradient.UseVisualStyleBackColor = true;
            // 
            // rdbNewton
            // 
            this.rdbNewton.AutoSize = true;
            this.rdbNewton.Location = new System.Drawing.Point(145, 135);
            this.rdbNewton.Name = "rdbNewton";
            this.rdbNewton.Size = new System.Drawing.Size(62, 17);
            this.rdbNewton.TabIndex = 45;
            this.rdbNewton.TabStop = true;
            this.rdbNewton.Text = "Newton";
            this.rdbNewton.UseVisualStyleBackColor = true;
            // 
            // rdbConjugateGradient
            // 
            this.rdbConjugateGradient.AutoSize = true;
            this.rdbConjugateGradient.Location = new System.Drawing.Point(145, 158);
            this.rdbConjugateGradient.Name = "rdbConjugateGradient";
            this.rdbConjugateGradient.Size = new System.Drawing.Size(125, 17);
            this.rdbConjugateGradient.TabIndex = 46;
            this.rdbConjugateGradient.TabStop = true;
            this.rdbConjugateGradient.Text = "Gradiente Conjugado";
            this.rdbConjugateGradient.UseVisualStyleBackColor = true;
            // 
            // rdbFletcherAndReeves
            // 
            this.rdbFletcherAndReeves.AutoSize = true;
            this.rdbFletcherAndReeves.Location = new System.Drawing.Point(145, 181);
            this.rdbFletcherAndReeves.Name = "rdbFletcherAndReeves";
            this.rdbFletcherAndReeves.Size = new System.Drawing.Size(124, 17);
            this.rdbFletcherAndReeves.TabIndex = 47;
            this.rdbFletcherAndReeves.TabStop = true;
            this.rdbFletcherAndReeves.Text = "Fletcher and Reeves";
            this.rdbFletcherAndReeves.UseVisualStyleBackColor = true;
            // 
            // rdbDavidonFletcherPowell
            // 
            this.rdbDavidonFletcherPowell.AutoSize = true;
            this.rdbDavidonFletcherPowell.Location = new System.Drawing.Point(145, 204);
            this.rdbDavidonFletcherPowell.Name = "rdbDavidonFletcherPowell";
            this.rdbDavidonFletcherPowell.Size = new System.Drawing.Size(140, 17);
            this.rdbDavidonFletcherPowell.TabIndex = 48;
            this.rdbDavidonFletcherPowell.TabStop = true;
            this.rdbDavidonFletcherPowell.Text = "Davidon-Fletcher-Powell";
            this.rdbDavidonFletcherPowell.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.rdbDavidonFletcherPowell);
            this.Controls.Add(this.rdbFletcherAndReeves);
            this.Controls.Add(this.rdbConjugateGradient);
            this.Controls.Add(this.rdbNewton);
            this.Controls.Add(this.rdbGradient);
            this.Controls.Add(this.rdbHookeAndJeeves);
            this.Controls.Add(this.rdbCoordinateDescent);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.grdX);
            this.Controls.Add(this.lblEpsilon);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.txtEpsilon);
            this.Controls.Add(this.lblFunction);
            this.Name = "frmMain";
            this.Text = "Programação Não Linear: Multivariável Irrestrito";
            ((System.ComponentModel.ISupportInitialize)(this.grdX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEpsilon;
        private System.Windows.Forms.TextBox txtEpsilon;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.DataGridView grdX;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rdbCoordinateDescent;
        private System.Windows.Forms.RadioButton rdbHookeAndJeeves;
        private System.Windows.Forms.RadioButton rdbGradient;
        private System.Windows.Forms.RadioButton rdbNewton;
        private System.Windows.Forms.RadioButton rdbConjugateGradient;
        private System.Windows.Forms.RadioButton rdbFletcherAndReeves;
        private System.Windows.Forms.RadioButton rdbDavidonFletcherPowell;
    }
}


namespace PNL_Mono_Variável
{
    partial class frmMain
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
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.lblEpsilon = new System.Windows.Forms.Label();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpMethod = new System.Windows.Forms.GroupBox();
            this.rdbNewton = new System.Windows.Forms.RadioButton();
            this.rdbBisection = new System.Windows.Forms.RadioButton();
            this.rdbFibonacciSearch = new System.Windows.Forms.RadioButton();
            this.rdbGoldenSection = new System.Windows.Forms.RadioButton();
            this.rdbDichotomicSearch = new System.Windows.Forms.RadioButton();
            this.rdbUniformSearch = new System.Windows.Forms.RadioButton();
            this.grpFunction.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.lblEpsilon);
            this.grpFunction.Controls.Add(this.txtEpsilon);
            this.grpFunction.Controls.Add(this.lblB);
            this.grpFunction.Controls.Add(this.txtB);
            this.grpFunction.Controls.Add(this.lblA);
            this.grpFunction.Controls.Add(this.txtA);
            this.grpFunction.Controls.Add(this.txtFunction);
            this.grpFunction.Controls.Add(this.lblFunction);
            this.grpFunction.Controls.Add(this.btnHelp);
            this.grpFunction.Controls.Add(this.btnAbout);
            this.grpFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFunction.Location = new System.Drawing.Point(0, 0);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(653, 82);
            this.grpFunction.TabIndex = 19;
            this.grpFunction.TabStop = false;
            this.grpFunction.Text = "Função";
            // 
            // lblEpsilon
            // 
            this.lblEpsilon.AutoSize = true;
            this.lblEpsilon.Location = new System.Drawing.Point(569, 51);
            this.lblEpsilon.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEpsilon.Name = "lblEpsilon";
            this.lblEpsilon.Size = new System.Drawing.Size(19, 17);
            this.lblEpsilon.TabIndex = 36;
            this.lblEpsilon.Text = "ε =";
            this.lblEpsilon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEpsilon.UseCompatibleTextRendering = true;
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(595, 49);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(51, 20);
            this.txtEpsilon.TabIndex = 35;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(430, 49);
            this.lblB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 17);
            this.lblB.TabIndex = 34;
            this.lblB.Text = "b =";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB.UseCompatibleTextRendering = true;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(456, 47);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(102, 20);
            this.txtB.TabIndex = 33;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(300, 48);
            this.lblA.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 17);
            this.lblA.TabIndex = 32;
            this.lblA.Text = "a =";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA.UseCompatibleTextRendering = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(323, 48);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(102, 20);
            this.txtA.TabIndex = 31;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(39, 48);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(255, 20);
            this.txtFunction.TabIndex = 30;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(6, 48);
            this.lblFunction.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(30, 17);
            this.lblFunction.TabIndex = 29;
            this.lblFunction.Text = "f(x) =";
            this.lblFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFunction.UseCompatibleTextRendering = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(595, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 23);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(538, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(51, 23);
            this.btnAbout.TabIndex = 26;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCalc);
            this.grpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpButtons.Location = new System.Drawing.Point(0, 208);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(653, 100);
            this.grpButtons.TabIndex = 20;
            this.grpButtons.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalc.Location = new System.Drawing.Point(3, 16);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(647, 81);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpMethod
            // 
            this.grpMethod.Controls.Add(this.rdbNewton);
            this.grpMethod.Controls.Add(this.rdbBisection);
            this.grpMethod.Controls.Add(this.rdbFibonacciSearch);
            this.grpMethod.Controls.Add(this.rdbGoldenSection);
            this.grpMethod.Controls.Add(this.rdbDichotomicSearch);
            this.grpMethod.Controls.Add(this.rdbUniformSearch);
            this.grpMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMethod.Location = new System.Drawing.Point(0, 82);
            this.grpMethod.Name = "grpMethod";
            this.grpMethod.Size = new System.Drawing.Size(653, 126);
            this.grpMethod.TabIndex = 21;
            this.grpMethod.TabStop = false;
            this.grpMethod.Text = "Método";
            // 
            // rdbNewton
            // 
            this.rdbNewton.AutoSize = true;
            this.rdbNewton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbNewton.Location = new System.Drawing.Point(3, 101);
            this.rdbNewton.Name = "rdbNewton";
            this.rdbNewton.Size = new System.Drawing.Size(647, 17);
            this.rdbNewton.TabIndex = 31;
            this.rdbNewton.TabStop = true;
            this.rdbNewton.Text = "Newton";
            this.rdbNewton.UseVisualStyleBackColor = true;
            // 
            // rdbBisection
            // 
            this.rdbBisection.AutoSize = true;
            this.rdbBisection.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbBisection.Location = new System.Drawing.Point(3, 84);
            this.rdbBisection.Name = "rdbBisection";
            this.rdbBisection.Size = new System.Drawing.Size(647, 17);
            this.rdbBisection.TabIndex = 30;
            this.rdbBisection.TabStop = true;
            this.rdbBisection.Text = "Bisseção";
            this.rdbBisection.UseVisualStyleBackColor = true;
            // 
            // rdbFibonacciSearch
            // 
            this.rdbFibonacciSearch.AutoSize = true;
            this.rdbFibonacciSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbFibonacciSearch.Location = new System.Drawing.Point(3, 67);
            this.rdbFibonacciSearch.Name = "rdbFibonacciSearch";
            this.rdbFibonacciSearch.Size = new System.Drawing.Size(647, 17);
            this.rdbFibonacciSearch.TabIndex = 29;
            this.rdbFibonacciSearch.TabStop = true;
            this.rdbFibonacciSearch.Text = "Busca de Fibonacci";
            this.rdbFibonacciSearch.UseVisualStyleBackColor = true;
            // 
            // rdbGoldenSection
            // 
            this.rdbGoldenSection.AutoSize = true;
            this.rdbGoldenSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbGoldenSection.Location = new System.Drawing.Point(3, 50);
            this.rdbGoldenSection.Name = "rdbGoldenSection";
            this.rdbGoldenSection.Size = new System.Drawing.Size(647, 17);
            this.rdbGoldenSection.TabIndex = 28;
            this.rdbGoldenSection.TabStop = true;
            this.rdbGoldenSection.Text = "Seção Áurea";
            this.rdbGoldenSection.UseVisualStyleBackColor = true;
            // 
            // rdbDichotomicSearch
            // 
            this.rdbDichotomicSearch.AutoSize = true;
            this.rdbDichotomicSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbDichotomicSearch.Location = new System.Drawing.Point(3, 33);
            this.rdbDichotomicSearch.Name = "rdbDichotomicSearch";
            this.rdbDichotomicSearch.Size = new System.Drawing.Size(647, 17);
            this.rdbDichotomicSearch.TabIndex = 26;
            this.rdbDichotomicSearch.TabStop = true;
            this.rdbDichotomicSearch.Text = "Busca Dicotômica";
            this.rdbDichotomicSearch.UseVisualStyleBackColor = true;
            // 
            // rdbUniformSearch
            // 
            this.rdbUniformSearch.AutoSize = true;
            this.rdbUniformSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbUniformSearch.Location = new System.Drawing.Point(3, 16);
            this.rdbUniformSearch.Name = "rdbUniformSearch";
            this.rdbUniformSearch.Size = new System.Drawing.Size(647, 17);
            this.rdbUniformSearch.TabIndex = 27;
            this.rdbUniformSearch.TabStop = true;
            this.rdbUniformSearch.Text = "Busca Uniforme";
            this.rdbUniformSearch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 308);
            this.Controls.Add(this.grpMethod);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpFunction);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programação Não Linear Monovariável";
            this.grpFunction.ResumeLayout(false);
            this.grpFunction.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpMethod.ResumeLayout(false);
            this.grpMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpMethod;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.RadioButton rdbDichotomicSearch;
        private System.Windows.Forms.RadioButton rdbUniformSearch;
        private System.Windows.Forms.RadioButton rdbNewton;
        private System.Windows.Forms.RadioButton rdbBisection;
        private System.Windows.Forms.RadioButton rdbFibonacciSearch;
        private System.Windows.Forms.RadioButton rdbGoldenSection;
        private System.Windows.Forms.Label lblEpsilon;
        private System.Windows.Forms.TextBox txtEpsilon;
    }
}
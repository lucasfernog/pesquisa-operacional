namespace PNL_Mono_Variável.Public
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.grbSobre = new System.Windows.Forms.GroupBox();
            this.lblGithubEmerson = new System.Windows.Forms.LinkLabel();
            this.lblDescricaoProjeto = new System.Windows.Forms.Label();
            this.lblGithubJoao = new System.Windows.Forms.LinkLabel();
            this.lblGithubLucas = new System.Windows.Forms.LinkLabel();
            this.grbSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSobre
            // 
            this.grbSobre.Controls.Add(this.lblGithubLucas);
            this.grbSobre.Controls.Add(this.lblGithubJoao);
            this.grbSobre.Controls.Add(this.lblGithubEmerson);
            this.grbSobre.Controls.Add(this.lblDescricaoProjeto);
            this.grbSobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSobre.Location = new System.Drawing.Point(10, 10);
            this.grbSobre.Name = "grbSobre";
            this.grbSobre.Size = new System.Drawing.Size(515, 144);
            this.grbSobre.TabIndex = 15;
            this.grbSobre.TabStop = false;
            // 
            // lblGithubEmerson
            // 
            this.lblGithubEmerson.AutoSize = true;
            this.lblGithubEmerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithubEmerson.Location = new System.Drawing.Point(6, 64);
            this.lblGithubEmerson.Name = "lblGithubEmerson";
            this.lblGithubEmerson.Size = new System.Drawing.Size(122, 13);
            this.lblGithubEmerson.TabIndex = 14;
            this.lblGithubEmerson.TabStop = true;
            this.lblGithubEmerson.Text = "http://github.com/Eihen";
            // 
            // lblDescricaoProjeto
            // 
            this.lblDescricaoProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescricaoProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProjeto.Location = new System.Drawing.Point(3, 16);
            this.lblDescricaoProjeto.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDescricaoProjeto.Name = "lblDescricaoProjeto";
            this.lblDescricaoProjeto.Size = new System.Drawing.Size(509, 48);
            this.lblDescricaoProjeto.TabIndex = 12;
            this.lblDescricaoProjeto.Text = resources.GetString("lblDescricaoProjeto.Text");
            // 
            // lblGithubJoao
            // 
            this.lblGithubJoao.AutoSize = true;
            this.lblGithubJoao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithubJoao.Location = new System.Drawing.Point(6, 90);
            this.lblGithubJoao.Name = "lblGithubJoao";
            this.lblGithubJoao.Size = new System.Drawing.Size(164, 13);
            this.lblGithubJoao.TabIndex = 15;
            this.lblGithubJoao.TabStop = true;
            this.lblGithubJoao.Text = "http://github.com/Jotamucheroni";
            // 
            // lblGithubLucas
            // 
            this.lblGithubLucas.AutoSize = true;
            this.lblGithubLucas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithubLucas.Location = new System.Drawing.Point(6, 118);
            this.lblGithubLucas.Name = "lblGithubLucas";
            this.lblGithubLucas.Size = new System.Drawing.Size(150, 13);
            this.lblGithubLucas.TabIndex = 16;
            this.lblGithubLucas.TabStop = true;
            this.lblGithubLucas.Text = "http://github.com/lucasfernog";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 162);
            this.Controls.Add(this.grbSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Sobre";
            this.grbSobre.ResumeLayout(false);
            this.grbSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSobre;
        private System.Windows.Forms.Label lblDescricaoProjeto;
        private System.Windows.Forms.LinkLabel lblGithubEmerson;
        private System.Windows.Forms.LinkLabel lblGithubLucas;
        private System.Windows.Forms.LinkLabel lblGithubJoao;
    }
}
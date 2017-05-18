﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PNL_Mono_Variável.Math;

namespace PNL_Mono_Variável.UniformSearch
{
    public partial class frmUniformSearchDelta : Form
    {
        public event OnSaveEventHandler Save;

        public frmUniformSearchDelta()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtDelta.Text == string.Empty)
                MessageBox.Show("Preencha o valor para delta");
            else
            {
                Expression expression = new Expression(txtDelta.Text.Replace(",", "."));
                if (expression.checkSyntax())
                {
                    double delta = expression.calculate();
                    OnSaveEventArgs args = new OnSaveEventArgs();
                    args.Delta = delta;
                    OnSave(args);
                    Close();
                }
                else
                {
                    MessageBox.Show(expression.getErrorMessage());
                }    
            }
        }

        private void OnSave(OnSaveEventArgs args)
        {
            Save?.Invoke(this, args);
        }
    }

    public class OnSaveEventArgs : EventArgs
    {
        public double Delta { get; set; }
    }

    public delegate void OnSaveEventHandler(Object sender, OnSaveEventArgs e);
}

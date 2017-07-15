using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class Matrix
    {
        private double[,] values;
        public int m { get; set; }
        public int n { get; set; }

        public Matrix(int n) : this(n, n)
        {
        }

        public Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            values = new double[m, n];
        }

        public static Matrix operator *(Matrix v1, Matrix v2)
        {
            return multiply(v1, v2);
        }

        private static Matrix multiply(Matrix m1, Matrix m2)
        {
            int m = m1.values.GetLength(0), n = m1.values.GetLength(1);
            Matrix res = new Matrix(m, n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m1[i, j] = m1[i, j] * m2[i, j];
                }
            }

            return res;
        }

        public double this[int line, int column]   
        {
            get
            {
                return values[line, column];
            }

            set
            {
                values[line, column] = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    builder.Append(Utils.round(values[i, j]));
                    if (j != n - 1)
                        builder.Append(", ");
                }
                if (i != m - 1)
                    builder.Append("//");
            }

            return builder.ToString();
        }
    }
}

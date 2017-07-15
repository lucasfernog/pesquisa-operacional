using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class Vector : IEnumerable
    {
        double[] values;

        public Vector(int n)
        {
            values = new double[n];
        }

        public int Count
        {
            get
            {
                return values.Length;
            }
        }

        public double this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }

        public IEnumerator<double> GetEnumerator()
        {
            return ((IEnumerable<double>) values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }

        public Vector clone()
        {
            Vector clone = new Vector(Count);
            Array.Copy(values, clone.values, Count);
            return clone;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return sum(v1, v2);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return subtract(v1, v2);
        }

        public static Vector operator -(Vector v)
        {
            Vector res = new Vector(v.Count);
            for (int i = 0, n = v.Count; i < n; i++)
                res[i] = -v[i];
            return res;
        }

        public static Vector operator *(double m, Vector v)
        {
            return multiply(m, v);
        }

        public static double operator *(Vector v1, Vector v2)
        {
            return multiply(v1, v2);
        }

        public static Vector operator *(Vector v, Matrix m)
        {
            return multiply(v, m);
        }

        private static double multiply(Vector v1, Vector v2)
        {
            if (v1.Count != v2.Count)
                throw new InvalidOperationException("Não é possível realizar o produto escalar de vetores de dimensão diferentes.");
            double res = 0;

            for (int i = 0, n = v1.Count; i < n; i++)
            {
                res += v1[i] * v2[i];
            }

            return res;
        }

        private static Vector multiply(Vector v, Matrix matrix)
        {
            if (v.Count != matrix.n)
                throw new InvalidOperationException("Impossível realizar multiplicação (tamanho do vetor deve ser igual ao número de colunas da matriz).");
            
            Vector res = new Vector(v.Count);

            for (int i = 0, m = v.Count; i < m; i++)
            {
                res[i] = 0;
                for (int j = 0, n = matrix.n; j < m; j++)
                {
                    res[i] += matrix[i, j] * v[j];
                }
            }

            return res;
        }

        private static Vector sum(Vector v1, Vector v2)
        {
            Vector res = new Vector(v1.values.Length);

            int i = 0;
            foreach (double item in v1.values)
            {
                res[i] = (item + v2[i]);
                i++;
            }

            return res;
        }

        private static Vector subtract(Vector v1, Vector v2)
        {
            Vector res = new Vector(v1.values.Length);

            int i = 0;
            foreach (double item in v1.values)
            {
                res[i] = item - v2[i];
                i++;
            }

            return res;
        }

        private static Vector multiply(double m, Vector v)
        {
            Vector res = new Vector(v.values.Length);

            int i = 0;
            foreach (double item in v.values)
            {
                res[i] = m * item;
                i++;
            }

            return res;
        }

        public double distance(Vector other)
        {
            double sum = 0;

            int i = 0;
            foreach (double item in values)
            {
                sum += System.Math.Pow(other[i++] - item, 2);
            }

            return System.Math.Sqrt(sum);
        }

        public double norm()
        {
            double sum = 0;

            foreach (double item in values)
            {
                sum += System.Math.Pow(item, 2);
            }

            return System.Math.Sqrt(sum);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("(");

            int i = 0, n = values.Length;
            foreach (double item in values)
            {
                str.Append(Utils.round(item).ToString());
                i++;
                if (i != n)
                    str.Append(", ");
            }

            str.Append(")");
            return str.ToString();
        }
    }
}

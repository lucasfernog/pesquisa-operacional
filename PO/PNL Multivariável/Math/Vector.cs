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

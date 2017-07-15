using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math.MNC
{
    public class LinearSystem
    {
        public static Vector retrosubstitution(Matrix a, Vector v)
        {
            Vector x = new Vector(a.n);
            double s;

            for (var i = a.n - 1; i >= 0; i--)
            {
                s = 0;
                for (var j = a.n - 1; j > i; j--)
                    s += x[j] * a[i,j];
                x[i] = (v[i] - s) / a[i, i];
                if (Double.IsInfinity(x[i]) || Double.IsNaN(x[i]))
                {
                    throw new NotFiniteNumberException("Erro ao realizar retrosubstituição, número não finito atingido.", x[i]);
                }
            }
            return x;
        }

        public static Vector substitution(Matrix a, Vector v)
        {
            Vector x = new Vector(a.n);
            double s;

            for (int i = 0, n = a.n; i < n; i++)
            {
                s = 0;
                for (var j = 0; j < i; j++)
                    s += x[j] * a[i, j];
                x[i] = (v[i] - s) / a[i, i];
                if (Double.IsInfinity(x[i]) || Double.IsNaN(x[i]))
                {
                    throw new NotFiniteNumberException("Ocorreu um erro durante a substituição, número não finito atingido.", x[i]);
                }
            }
            return x;
        }

        public static Matrix identity(int o)
        {
            Matrix id = new Matrix(o);
            for (var i = 0; i < o; i++)
            {
                id[i, i] = 1;
            }
            return id;
        }

        public static Dictionary<String, Matrix> lu(Matrix a)
        {
            Matrix l = identity(a.n), u = new Matrix(a.n);
            double s;

            for (int i = 0, n = a.n; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    s = 0;
                    for (var k = 0; k < i; k++)
                        s += l[i, k] * u[k, j];
                    u[i, j] = a[i, j] - s;
                }
                for (var j = i + 1; j < n; j++)
                {
                    s = 0;
                    for (var k = 0; k < j; k++)
                        s += l[j, k] * u[k, i];
                    l[j, i] = (a[j, i] - s) / u[i, i];
                    if (Double.IsInfinity(l[j, i]) || Double.IsNaN(l[j, i]))
                        throw new NotFiniteNumberException("Erro ao triangular matriz com o método LU, número não finito atingido", l[j, i]);
                }
            }

            var dictionary = new Dictionary<string, Matrix>();
            dictionary["L"] = l;
            dictionary["U"] = u;
            return dictionary;
        }

        public static Vector solve(Matrix a, Vector b)
        {
            var r = lu(a);
            return retrosubstitution(r["U"], substitution(r["L"], b));
        }
    }
}

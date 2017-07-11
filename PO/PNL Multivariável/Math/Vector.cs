using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNL_Multivariável.Math
{
    public class Vector<T> : LinkedList<T>
    {
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (T item in this)
                str.Append(item.ToString());
            return str.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Vector<T>
    {
        public T X { get; set; }
        public T Y { get; set; }


        public Vector(T x, T y ) {
            X = x;
            Y = y;
        }

        public T GetX()
        {
            return X;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public delegate T Operation<T>(T x, T y);
    internal class Calculator<T>
    {
        private T x;
        private T y;

        public int X { get; set; }
        public int Y { get; set; }
        public Calculator(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T PerformOperation(Operation<T> operation)
        {
            return operation(x, y);
        }

    }
}

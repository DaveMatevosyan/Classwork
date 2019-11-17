using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] x = new int[2,2];
            //int[,] y = new int[2, 2];
            //var sum = x + y;
            Matrix aa;
            Matrix a = new Matrix();
            Matrix b = new Matrix();
            Matrix c = new Matrix(3,3);
            
            int el = a[1, 1];

            Matrix sum = a.Addition(b).Addition(c);
            Matrix sum1 = Matrix.Addition(a, b);
            Matrix sumOp = a + b;
            Matrix sum3 = a + b + c;
            a += b;
        }
    }
}

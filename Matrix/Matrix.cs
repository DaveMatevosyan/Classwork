using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix //: ArrayList
    {
        public int Rows { get; set; }
        public int Cols { get; set; }

        private int[,] content;        

        public int this[int i]
        {
            get => this.content[0, i];
            //{
            //    return this.content[0,i];
            //}
        }
        public int this[int i, int j] //=> this.content[i,j];
        {
            get
            {
                return this.content[i, j];
            }
        }

        public int this[int i, string j]
        {
            get
            {
                return 2;
            }
        }
        public Matrix()
        {
            this.content = new int[this.Rows, this.Cols];
        }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            this.content = new int[Rows, Cols];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Matrix Addition(Matrix a)
        {
            Matrix sum = new Matrix();
            //...
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Sum of two matrices</returns>
        public static Matrix Addition(Matrix a, Matrix b)
        {
            Matrix sum = new Matrix();
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    sum.content[i, j] = a[i, j] + b.content[i, j];
                }
            }
            return sum;
        }

        public Matrix Multiplication(Matrix a, Matrix b)
        {
            Matrix mult = new Matrix();
            //...
            return mult;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix sum = new Matrix();
            //...
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class ArrayProcessor
    {
        private double[] data;
        private int firstIndex;
        private int lastIndex;

        public int FirstIndex => this.firstIndex;
        public int LastIndex => this.lastIndex;
        public ArrayProcessor(double[] data, 
                                int firstIndex,
                                int lastIndex)
        {
            this.data = data;
            this.firstIndex = firstIndex;
            this.lastIndex = lastIndex;
        }

        public void Process()
        {
            
            for (int i = firstIndex; i < lastIndex; i++)
            {
                Thread.Sleep(1);
                data[i] = i;
            }
            

            /*
            Parallel.For(firstIndex, lastIndex, (index) =>
            {
                Thread.Sleep(1);
                data[index] = index;
            });
            

            Parallel.ForEach(data, d =>
            {
                Thread.Sleep(1);
                d = 1;
            });
            */
        }
    }
}

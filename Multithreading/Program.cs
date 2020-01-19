using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        private static object obj = new object();
        static int sum = 0;
        static void Main(string[] args)
        {
            int numberOfCores = Environment.ProcessorCount;
            Console.WriteLine($"ProcessorCount: {numberOfCores}\n");
            Console.WriteLine("[{0}] : {1}",
                        Thread.CurrentThread.ManagedThreadId,
                        Thread.CurrentThread.Name);
            double[] myData = new double[3030];
            int arrayLength = myData.Length - 1;
            ArrayProcessor array = new ArrayProcessor(myData, 0, arrayLength);
            Stopwatch st = new Stopwatch();
            st.Start();
           // array.Process();
            st.Stop();
            Console.WriteLine($"{st.ElapsedMilliseconds}ms");

            int chunckSize = arrayLength / numberOfCores;
            int leftIndexes = arrayLength % numberOfCores;

            ArrayProcessor[] arrayParts = new ArrayProcessor[numberOfCores];
            Thread[] threads = new Thread[numberOfCores];

            for (int i = 0; i < numberOfCores - 1; i++)
            {
                arrayParts[i] = new ArrayProcessor(myData, i * chunckSize, 
                                                    (i + 1) * chunckSize);
                threads[i] = new Thread(ChunckProcessing);
                threads[i].Name = $"thread[{i}]";
                threads[i].Start(arrayParts[i]);

                //Thread can be initialized also the following way
                //threads[i] = new Thread(arrayParts[i].Process);

                //lines 50-54 can be written here
                //if(i == numberOfCores -1)
                //{ 
                //    //start the last thread here.
                //}
            }
            int lastChunckIndex = numberOfCores - 1;
            arrayParts[lastChunckIndex] = new ArrayProcessor(myData,
                lastChunckIndex * chunckSize, (lastChunckIndex + 1) * chunckSize + leftIndexes);
            threads[lastChunckIndex] = new Thread(ChunckProcessing);
            threads[lastChunckIndex].Start(arrayParts[lastChunckIndex]);

            Console.WriteLine(myData[lastChunckIndex]);

            //TODO Add statement to wait all threads to finish before the main thread exits.
            
            //int sum = 0;
            //int count = 10;
            //for (int i = 0; i < count; i++)
            //{
            //    Thread thr = new Thread(Calculate);
            //    thr.Name = $"thread[{i}]";
            //    thr.Start(i);
            //    thr.Join();
            //}
            //Console.WriteLine($"Sum: {sum}");

            //Console.WriteLine("[{0}] : {1}", 
            //Thread.CurrentThread.ManagedThreadId,
            //Thread.CurrentThread.Name );

            //Thread thread = new Thread(MyFunc);
            ////thread.IsBackground = false;
            //thread.Name = "My thread";
            //thread.Start();

            Console.WriteLine("Main exit");
            Console.ReadLine();
        }

        private static void ChunckProcessing(object param)
        {
            Console.WriteLine("[{0}] : {1}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Name);
            Stopwatch sp = new Stopwatch();
            sp.Start();
            
            ArrayProcessor chunck = (ArrayProcessor)param;
            Console.WriteLine($"[{chunck.FirstIndex} - {chunck.LastIndex}]");

            chunck.Process();
            sp.Stop();
            Console.WriteLine($"Each thread : {sp.ElapsedMilliseconds} ms");
        }

        private static void Calculate(object param)
        {
            //Interlocked.Increment(ref sum);
            lock (obj)
            {
                sum += 1;
                Console.WriteLine("[{0}] : {1}, sum: {2}",
                    Thread.CurrentThread.ManagedThreadId,
                    Thread.CurrentThread.Name, sum);
            }
        }

        private static void MyFunc()
        {
            Console.WriteLine("Started [{0}] : {1}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Completed [{0}] : {1}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Name);
            
        }

    }
}

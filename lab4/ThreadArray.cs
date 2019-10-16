using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab4
{
   public class ThreadArray
    {
        private int cores,threads,arrLength;
        private Thread[] Threads;
        private int[] array;
        private int arrInthread;
        private int threadIncore;
        Random r = new Random();
        public ThreadArray(int cores,int threads,int arrLength)
        {
            this.cores = cores;
            this.threads = threads;
            this.arrLength = arrLength;
            Threads = new Thread[threads];
            array = new int[arrLength];
            arrInthread = arrLength / threads;  //100
            threadIncore = threads / cores;    //250

        }

        public void Run()
        {

        }

        private void ThreadInitialization()
        {
            for (int i = 0; i < Threads.Length; i++)
            {

            }
        }

        private void Set(object i)
        {
            int j = (int)i;
            array[j] = r.Next(1, 100);
        }




    }
}

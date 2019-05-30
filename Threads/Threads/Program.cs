using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {

        static object objA = new object();
        static object objB = new object();

        static void Main(string[] args)
        {
            Thread[] firstThreadPool = new Thread[3];

            firstThreadPool[0] = new Thread(() => 

            {
                //Thread.Sleep(1);
                Console.WriteLine("1");                
            });
            firstThreadPool[1] = new Thread(() =>
            {
                //Thread.Sleep(10);
                Console.WriteLine("2");                
            });
            firstThreadPool[2] = new Thread(() =>
            {
                //Thread.Sleep(0);
                Console.WriteLine("3");                
            });

            firstThreadPool[0].Priority = ThreadPriority.Lowest;
            firstThreadPool[1].Priority = ThreadPriority.Lowest;
            firstThreadPool[2].Priority = ThreadPriority.Highest;


            foreach (var t in firstThreadPool)
            {
                t.Start();
            }


            #region Deadlock
            //var thread1 = new Thread(MethodA);
            //var thread2 = new Thread(MethodB);

            //thread1.Start(); thread2.Start(); 
            #endregion
            

            Console.Read();
        }

        static void MethodA()
        {
            lock(objB){
                Thread.Sleep(1000);
                lock (objA)
                {

                }
            }
        }
        static void MethodB()
        {
            lock (objA)
            {
                lock (objB)
                {

                }
            }
        }
    }
}

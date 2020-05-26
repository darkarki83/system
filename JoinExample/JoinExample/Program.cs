using System;
using System.Threading;

namespace JoinExample
{
    public class MyThread1
    {
        // В терминах Windows API — это функция потока.
        // В данном случае — вариант с входным параметром.
        // Вместо LPVOID из Windows API в .NET используется object.
        public void Run()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(40);
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            }
            Console.WriteLine($"{Thread.CurrentThread.Name}: Goodbye!");
        }
    }
    public class MyThread2
    {
        // В терминах Windows API — это функция потока.
        // В данном случае — вариант с входным параметром.
        // Вместо LPVOID из Windows API в .NET используется object.
        public void Run(object start)
        {
            for (int i = (int)start; i <= 20; i++)
            {
                Thread.Sleep(40);
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            }
            Console.WriteLine($"{Thread.CurrentThread.Name}: Goodbye!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            //Thread MyArray = new MyThread1();
            //MyThread2[] MyArrayPar= new MyThread2[3];


            
            var One = new Thread(new ThreadStart(new MyThread1().Run));
            One.Name = "Thread 1";
            var Sec = new Thread(new ThreadStart(new MyThread1().Run));
            Sec.Name = "Thread 2";
            var OnePar = new Thread(new ParameterizedThreadStart(new MyThread2().Run));
            OnePar.Name = "ThreadPar 1";
            var SecPar = new Thread(new ParameterizedThreadStart(new MyThread2().Run));
            SecPar.Name = "ThreadPar 2";

            One.Start();
            Sec.Start();
            OnePar.Start(5);
            SecPar.Start(15);
            One.Join();
            Sec.Join();
            OnePar.Join();
            SecPar.Join();


            Console.WriteLine("Bay bay");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simafor.Model
{
    public interface IModelSimafor
    {
        List<NewThread> MyThreads { get; set; }
        List<NewThread> WaitThreads { get; set; }
        void CreateThread();
        void NewDoubleClick(int select);
    }


    public class NewThread
    {
        private Semaphore semaphore;
        public int NumberName { get; set; }

        public Thread Thread { get; }

        public NewThread(int number, Semaphore s)
        {
            semaphore = s;
            NumberName = number;
            Thread = new Thread(new ThreadStart(Run));
            Thread.Name = $"Thread {NumberName.ToString()}";
            Thread.Start();
        }
        // Точка входа в поток (функция потока)
        void Run()
        {
            semaphore.WaitOne();
            // Получаем мьютекс (если он занят, то будем ждать, пока не освободиться)
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.Name} => {i + 1}");
                Thread.Sleep(100);
            }
            semaphore.Release();
        }
    }
}

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
        bool SimFull { get; set; }
        int CountWork { get; set; }
        int ThreadNum { get; set; }
        void CreateThread();
        void NewDoubleClick(int select);
    }


    public class NewThread
    {
        private Semaphore semaphore;
        public int NumberName { get; set; }
        public int I { get; set; }
        public Thread Thread { get; }
        public NewThread(int number, Semaphore s)
        {
            semaphore = s;
            NumberName = number;
            Thread = new Thread(new ThreadStart(Run));
            Thread.Name = $"Thread {NumberName.ToString()}";
        }
        // Точка входа в поток (функция потока)
        public void Run()
        {
            semaphore.WaitOne();
            // Получаем мьютекс (если он занят, то будем ждать, пока не освободиться)
            for (I = 0; I < 10000; I++)
            {
                Thread.Sleep(1000);
            }
            semaphore.Release();
        }
    }
}

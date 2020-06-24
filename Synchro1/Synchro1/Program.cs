using System;
using System.Threading;

namespace Synchro1
{
    class Resources
    {
        // Собственно, общие данные для потоков.
        // Учитывая static, по сути, это глобальная переменная,
        // т.е., как раз то, доступ чему нуждается в синхронизации.
        public static int Honey { get; set; } = 0;

        // Мьютекс для синхронизации потоков
        public static Mutex Mutex { get; } = new Mutex();
    }

    class ThreadBee
    {
        private Random random = new Random();

        public Thread Thread { get; }

        public ThreadBee(string name)
        {
            Thread = new Thread(Run);
            Thread.Name = name;
            Thread.Start();
        }

        // Точка входа в поток (функция потока)
        void Run()
        {
            while (true)
            {
                int time = random.Next(1, 6) * 1000;
                Thread.Sleep(time);

                Console.WriteLine($"{Thread.Name} ожидает мьютекс");
                Resources.Mutex.WaitOne();
                Console.WriteLine($"{Thread.Name} получает мьютекс");
                Resources.Honey++;
                Console.WriteLine($"{Thread.Name} освобождает мьютекс");
                Resources.Mutex.ReleaseMutex();
            }
        }
    }

    class ThreadBeer
    {
        public Thread Thread { get; }

        public ThreadBeer(string name)
        {
            Thread = new Thread(Run);
            Thread.Name = name;
            Thread.Start();
        }

        // Точка входа в поток (функция потока)
        void Run()
        {
            while (true)
            {
                Thread.Sleep(10000);

                Console.WriteLine($"{Thread.Name} ожидает мьютекс");
                Resources.Mutex.WaitOne();
                Console.WriteLine($"{Thread.Name} получает мьютекс");
                Resources.Honey -= 15;
                Console.WriteLine($"{Thread.Name} освобождает мьютекс");
                Resources.Mutex.ReleaseMutex();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                var ThreadBee = new ThreadBee(i.ToString());
            }

            // Стартуем инкрементирующий поток
            // (перед стартом декрементирующего потока делаем паузу в 1 мс; этого
            // достаточно, чтобы инкрементирующий поток успел захватить мьютекс первым)
            Thread.Sleep(1000);

            
            var ThreadBeer = new ThreadBeer("Beer Eat");

            while (true)
            {
                Resources.Mutex.WaitOne();
                if (Resources.Honey < 0)
                    Console.WriteLine("Beer is Dead");
                else
                    Console.WriteLine($"Beer is Live. I have Honey = {Resources.Honey}");
                Resources.Mutex.ReleaseMutex();
                Thread.Sleep(10000);
            }
        }
    }
}

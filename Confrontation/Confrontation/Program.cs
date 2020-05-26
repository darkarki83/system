using System;
using System.Threading;

namespace Confrontation
{
    public class Resources
    {
        // Собственно, общие данные для потоков.
        // Учитывая static, по сути, это глобальная переменная,
        // т.е., как раз то, доступ чему нуждается в синхронизации.
        public static int TeamALive { get; set; } = 100;
        public static int TeamBLive { get; set; } = 100;

        // Мьютекс для синхронизации потоков
        public static Mutex MutexA { get; } = new Mutex(false, "29C33C81-1C77-4537-9C61-3B0A8A7D60C4");
        public static Mutex MutexB { get; } = new Mutex(false, "8031FFE1-503A-42BC-B2D2-D44F4E6E156E");
    }

    public class ThreadTeamA
    {
        public Thread Thread { get; }
        Random random = new Random();

        public ThreadTeamA(string name)
        {
            Thread = new Thread(Run);
            Thread.Name = name;
            Thread.Start();
        }

        // Точка входа в поток (функция потока)
        void Run()
        {
            int heal = 0;
            int damage = 0;
            // Собственно, работа с глобальными данными
            do
            {
                Thread.Sleep(500);
                Resources.MutexA.WaitOne();
                if (Resources.TeamALive < 0)
                    break;
                heal = random.Next(1, 11);
                Console.WriteLine($"Heal Team A = {heal}");
                Console.WriteLine($"Team A Live = {Resources.TeamALive}");
                Resources.TeamALive += heal;

                Resources.MutexA.ReleaseMutex();

                Resources.MutexB.WaitOne();
                damage = random.Next(1, 20);
                Console.WriteLine($"Damage To Team B = {damage}");
                Resources.TeamBLive -= damage;
                Resources.MutexB.ReleaseMutex();
            } while (Resources.TeamBLive >= 0);

            Resources.MutexA.WaitOne();
            if (Resources.TeamALive > 0)
                Console.WriteLine($"Team B Dead");
            Resources.MutexA.ReleaseMutex();

        }
    }

    public class ThreadTeamB
    {
        public Thread Thread { get; }
        Random random = new Random();

        public ThreadTeamB(string name)
        {
            Thread = new Thread(Run);
            Thread.Name = name;
            Thread.Start();
        }

        // Точка входа в поток (функция потока)
        void Run()
        {
            int heal = 0;
            int damage = 0;
            // Собственно, работа с глобальными данными
            do
            {
                Thread.Sleep(500);
                Resources.MutexB.WaitOne();
                heal = random.Next(1, 11);
                Console.WriteLine($"Heal Team B = {heal}");
                if(Resources.TeamBLive < 0)
                    break;
                Resources.TeamBLive += heal;
                Console.WriteLine($"Team B Live = {Resources.TeamBLive}");
                Resources.MutexB.ReleaseMutex();

                Resources.MutexA.WaitOne();
                damage = random.Next(1, 20);
                Console.WriteLine($"Damage To Team A = {damage}");
                Resources.TeamALive -= damage;
                Resources.MutexA.ReleaseMutex();
            } while (Resources.TeamALive >= 0);

            Resources.MutexB.WaitOne();
            if (Resources.TeamBLive > 0)
                Console.WriteLine($"Team A Dead");
            Resources.MutexB.ReleaseMutex();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var ThreadTeamA = new ThreadTeamA("Team A");
            var ThreadTeamB = new ThreadTeamB("Team B");
            //Console.ReadKey(true);
        }
    }
}

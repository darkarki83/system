using System;
using System.Threading;

namespace Balloons
{

    class Resources
    {
        public static void WriteChar(int _x, int _y, char _symbol)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_symbol);
        }
    }

    class ThreadBallons
    {
        private Random random = new Random();
        private char _symbol;
        private static object pothisionLock = new object();
        public Thread Thread { get; }
        public int Hight { get; set; }
        public int Width { get; set; }


        public ThreadBallons(char symbol)
        {
            _symbol = symbol;
            Thread = new Thread(Run);
            Thread.Start();
        }

        // Точка входа в поток (функция потока)
        void Run()
        {
            Hight = random.Next(1, 31);
            Width = random.Next(1, 81);
            do
            {
                if(Hight < 20)
                {
                    lock (pothisionLock)
                    {
                        Resources.WriteChar(Width, Hight, _symbol);
                    }
                }
                Thread.Sleep(350);

                lock (pothisionLock)
                {
                    Resources.WriteChar(Width, Hight, ' ');
                }
                Hight = random.Next(1, 31);
                Width = random.Next(1, 81);
            } while (Hight < 20);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var ThreadBallons = new ThreadBallons('B');
            }
            
            while(true)
            { }
        }
    }
}

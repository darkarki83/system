using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Matrix1
{
    public class Thread1
    {
        public void Run(object w)
        {
            Random rand = new Random();
            while (true)
            {
                for (int i = 0; i < 30; i++)
                {
                    ConsoleLib.WriteChar((int)w, i, ' ');
                }
                int h = rand.Next(1, 25);
                int l = rand.Next(1, 29 - h);

                for (int i = h; i < l + h; i++)
                {
                    char c = ConsoleLib.CRand();
                    if (i == h)
                        ConsoleLib.SetColor(ConsoleColor.White, ConsoleColor.Black);
                    else if (i == h + 1)
                        ConsoleLib.SetColor(ConsoleColor.Green, ConsoleColor.Black);
                    else if (i == h + 2)
                        ConsoleLib.SetColor(ConsoleColor.DarkGreen, ConsoleColor.Black);

                    ConsoleLib.WriteChar((int)w, i, ConsoleLib.CRand());
                    Thread.Sleep(100);
                }

            }
        }
    }
}

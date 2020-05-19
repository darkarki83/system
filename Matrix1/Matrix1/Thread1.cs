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

            List<char> vs = new List<char>();
            int l = rand.Next(1, 20);
            for (int i = 0; i < l; i++)
            {
                vs.Add(ConsoleLib.CRand());
            }
            while (true)
            {
                int count = 0;
                for (int i = 0; i < 29 + vs.Count; i++)
                {
                    if (i >= vs.Count)
                    {
                        for (int k = 0; k < vs.Count; k++)
                        {
                            if (k + count < 29)
                            {
                                if (i - 1 == k + count)
                                    ConsoleLib.SetColor(ConsoleColor.White, ConsoleColor.Black);
                                else if (i - 2 == k + count)
                                    ConsoleLib.SetColor(ConsoleColor.Green, ConsoleColor.Black);
                                else
                                    ConsoleLib.SetColor(ConsoleColor.DarkGreen, ConsoleColor.Black);
                                ConsoleLib.WriteChar((int)w, count + k, vs[k]);
                            }
                        }
                        count++;
                    }
                    else
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (k == i - 1)
                                ConsoleLib.SetColor(ConsoleColor.White, ConsoleColor.Black);
                            else if (k == i - 2)
                                ConsoleLib.SetColor(ConsoleColor.Green, ConsoleColor.Black);
                            else
                                ConsoleLib.SetColor(ConsoleColor.DarkGreen, ConsoleColor.Black);

                            ConsoleLib.WriteChar((int)w, k, vs[vs.Count - 1 + k - i]);
                        }
                    }
                    Thread.Sleep(100);
                    for (int q = 0; q < 29 ; q++)
                    {
                        ConsoleLib.WriteChar((int)w, q, ' ');
                    }
                }
            }
        }
    }
}

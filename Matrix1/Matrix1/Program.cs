using System;
using System.Collections.Generic;
using System.Threading;

namespace Matrix1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int j;
            List<int> Ww = new List<int>();
            while(Ww.Count <= 20)
            {
                int num = rand.Next(1, 100);
                if(Ww.Count != 0)
                {
                    j = 0;
                    for (; j < Ww.Count; j++)
                    {
                        if(Ww[j] == num)
                        {
                            break;
                        }
                    }
                    if(j == Ww.Count)
                    {
                        Ww.Add(num);
                    }
                }
                else
                {
                    Ww.Add(num);
                }
            }

            for (int i = 0; i < Ww.Count; i++)
            {
                var backgroundThread1 = new Thread(new ParameterizedThreadStart(new Thread1().Run));
                backgroundThread1.Name = "Background Thread #1";
                backgroundThread1.IsBackground = true;
                backgroundThread1.Start(Ww[i]);
            }

            while(true)
            { }
        }
    }
}

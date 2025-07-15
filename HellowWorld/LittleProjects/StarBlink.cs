using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HellowWorld.LittleProjects
{
    public class StarBlink
    {
        public StarBlink(int n)
        {
            StartStarBlink(n);
        }

        public static void StartStarBlink(int n)
        {
            int Cnt = 10;
            int i = 0;
            for (i = 0; i < Cnt; i++)
            {
                if (i % 2 == 0)
                {
                    StartFunct(n);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    StartFunct2(n);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                //Thread.Sleep(50000);
            }
        }
        static void StartFunct(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((n - 1) / 2 == j || (n - 1) / 2 == i)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n");
                Console.Write("\n");
            }
        }
        static void StartFunct2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || (i + j + 1) == n)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n");
                Console.Write("\n");
            }
        }
    }
}

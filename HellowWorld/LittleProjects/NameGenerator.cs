using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HellowWorld.LittleProjects
{
    public class NameGenerator
    {
        public NameGenerator()
        {
            GetTheWordGen();
        }

        public void GetTheWordGen()
        {
            while (true)
            {
                Console.WriteLine("Enter the Name U want to blink:");
                string name = Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();

                if (!string.IsNullOrEmpty(name))
                {
                    foreach (char ch in name)
                    {
                        switch (Char.ToUpper(ch))
                        {
                            case 'A': printA(); break;
                            case 'B': printB(); break;
                            case 'C': printC(); break;
                            case 'D': printD(); break;
                            case 'E': printE(); break;
                            case 'F': printF(); break;
                            case 'G': printG(); break;
                            case 'H': printH(); break;
                            case 'I': printI(); break;
                            case 'J': printJ(); break;
                            case 'K': printK(); break;
                            case 'L': printL(); break;
                            case 'M': printM(); break;
                            case 'N': printN(); break;
                            case 'O': printO(); break;
                            case 'P': printP(); break;
                            case 'Q': printQ(); break;
                            case 'R': printR(); break;
                            case 'S': printS(); break;
                            case 'T': printT(); break;
                            case 'U': printU(); break;
                            case 'V': printV(); break;
                            case 'W': printW(); break;
                            case 'X': printX(); break;
                            case 'Y': printY(); break;
                            case 'Z': printZ(); break;
                            default:
                                printAll();
                                break;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }

            
        }

        void printAll()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("  *  ");
                }
                Console.Write("\n");
                Console.Write("\n");
            }
        }

        void printA()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j == 0 || j == n - 1) && i != 0 || i == 0 && j > 0 && j < n - 1 || i == n / 2)
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
        void printB()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || (i == 0 || i == n - 1 || i == n / 2) && j < n - 1 || j == n - 1 && i != 0 && i != n / 2 && i != n - 1)
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
        void printC()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0)
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
        void printD()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || (i == 0 || i == n - 1) && j < n - 1 || j == n - 1 && i != 0 && i != n - 1)
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
        void printE()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == n - 1 || i == n / 2)
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
        void printF()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == n / 2)
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
        void printG()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || (i == n / 2 && j >= n / 2) || (j == n - 1 && i >= n / 2))
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
        void printH()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == (n - 1) / 2)
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
        void printI()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == (n - 1) / 2)
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
        void printJ()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == n / 2 || (i == n - 1 && j <= n / 2) || (j == 0 && i >= n - 2))
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
        void printK()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 1 || (i==j && i+j > 3)||((i+j)==4 && i!= 4))
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
        void printL()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == n - 1)
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
        void printM()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || (i + j < n && i == j) || (i + j == (n - 1) && i < ((n - 1) / 2)))
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
        void printN()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == j)
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
        void printO()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == 0 || i == n - 1) && j > 0 && j < n - 1 ||
                        (j == 0 || j == n - 1) && i > 0 && i < n - 1)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printP()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 ||
                        (i == 0 || i == n / 2) && j < n - 1 ||
                        j == n - 1 && i > 0 && i < n / 2)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printQ()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == 0 || i == n - 2) && j > 0 && j < n - 1 ||
                        (j == 0 || j == n - 1) && i > 0 && i < n - 2 ||
                        (i == j && i >= n / 2))
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printR()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == 0 || j == 0 || i == (n - 1) / 2) || (j == n - 1 && i + j < n + 1) || (i == j && i + j > n))
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
        void printS() 
        {
            int n = 5;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==0 || i== n-1 || i== (n-1)/2 || (i < (n - 1) / 2 && j == 0) || (j == (n - 1) && i > (n - 1) / 2))
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
        void printT()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == (n - 1) / 2)
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
        void printU()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j == 0 && i != n - 1) ||
                        (j == n - 1 && i != n - 1) ||
                        (i == n - 1 && j > 0 && j < n - 1))
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printV()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (j == i || j == 2 * n - 2 - i)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printW()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (j == 0 || j == 2 * n - 2 ||
                        (i == j - n + 1 && j >= n - 1 && j <= n + i - 1))
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printX()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - 1 - i)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
        void printY()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j < n && i == j) || (i + j == (n - 1) && i < ((n - 1) / 2)) || ( j==(n-1)/2) && i > (n - 1) / 2)
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
        void printZ()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == n - 1 - i)
                    {
                        Console.Write("  *  ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.Write("\n\n");
            }
        }
    }
}

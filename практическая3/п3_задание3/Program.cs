using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п3_задание3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] v = new int[11, 11];
            int[,] g = new int[11, 11];
            Random random = new Random();
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == v.GetLength(0) - 1 || j == v.GetLength(1) - 1)
                    {
                        continue;
                    }
                    v[i, j] = random.Next(0, 2);
                    Console.Write($"{v[i, j]} ");
                }
                Console.WriteLine();
            }
            bool live = true;
            int age = 1;
            while (live)
            {
                Console.WriteLine($"Поколение номер {age}");
                for (int i = 0; i < v.GetLength(0); i++)
                {
                    for (int j = 0; j < v.GetLength(1); j++)
                    {
                        if (i == 0 || j == 0 || i == v.GetLength(0) - 1 || j == v.GetLength(1) - 1)
                        {
                            continue;
                        }
                        if (i - 1 >= 0 && i + 1 < v.GetLength(0) && j - 1 >= 0 && j + 1 < v.GetLength(1))
                        {
                            if (v[i, j + 1] + v[i, j - 1] + v[i + 1, j] + v[i - 1, j] + v[i + 1, j + 1] + v[i - 1, j + 1] + v[i - 1, j - 1] + v[i + 1, j - 1] > 3)
                            {
                                g[i, j] = 0;
                            }
                            else if (v[i, j + 1] + v[i, j - 1] + v[i + 1, j] + v[i - 1, j] + v[i + 1, j + 1] + v[i - 1, j + 1] + v[i - 1, j - 1] + v[i + 1, j - 1] < 3)
                            {
                                g[i, j] = 0;
                            }
                            else
                            {
                                g[i, j] = 1;
                            }
                        }
                        Console.Write($"{g[i, j]} ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < v.GetLength(0); i++)
                {
                    for (int j = 0; j < v.GetLength(1); j++)
                    {
                        v[i, j] = g[i, j];
                    }
                }

                age += 1;

                string a = Console.ReadLine();
                if (a == "exit")
                    live = false;
            }
        }
    }
}



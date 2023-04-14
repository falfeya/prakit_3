using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п3_задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int r = 2; 
        int c = 3; 
        int[,] matrixA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] matrixB = new int[2, 3] { { 7, 8, 9 }, { 10, 11, 12 } };
        int[,] matrixC = new int[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
            Console.WriteLine("Результат сложения матриц A и B:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                    Console.Write($"{matrixC[i,j]}\t");
            }
            Console.WriteLine();
            }
            Console.ReadKey();
        }
}
}
    

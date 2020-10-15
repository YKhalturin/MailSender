using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
    public static class Matrix
    {
        private const int _dim = 100;
        public static Task<int[,]> A => FillMatrix(_dim, _dim);
        public static Task<int[,]> B => FillMatrix(_dim, _dim);

        private static async Task<int[,]> FillMatrix(int i, int j)
        {
            Thread.Sleep(100);
            var a = new int[i, j];
            Random r = new Random();
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(1, 10);
                }
            }
            return a;
        }

        public static async Task<int[,]> Multiplication(int[,] a, int[,] b)
        {
            //var tasks = new List<Task>();
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];

            Task task = Task.Run(async () =>
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Task task1 = Task.Run(async () =>
                    {
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            Task task2 = Task.Run(() =>
                            {
                                for (int k = 0; k < b.GetLength(0); k++)
                                {
                                    r[i, j] += a[i, k] * b[k, j];
                                    Console.WriteLine($"r[{i},{j}] += {a[i,k]} * {b[k,j]}. TaskId:{Task.CurrentId}");
                                }
                            });
                            await Task.WhenAll(task2).ConfigureAwait(false);
                            Console.WriteLine($"r[{i},{j}] = {r[i, j]}. TaskId:{Task.CurrentId}");
                        }
                    });
                    Task.WaitAll(task1);
                }
            });
            
            Task.WaitAll(task);
            Console.WriteLine($"Завершение всех потоков");
            return r;
        }

        public static async Task Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

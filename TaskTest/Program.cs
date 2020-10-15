using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Матрица А");
            Matrix.Print(await Matrix.A);
            Console.WriteLine($"A. TaskId:{Task.CurrentId}");
            Console.WriteLine("Матрица B");
            Matrix.Print(await Matrix.B);
            Console.WriteLine($"B. TaskId:{Task.CurrentId}");
            Console.WriteLine("Матрица C рассчитывается...");
            var result = await Matrix.Multiplication(await Matrix.A, await Matrix.B);
            Matrix.Print(result);

            Console.WriteLine("Перемножение матрицы завершено");
            Console.ReadKey();
        }
    }
}

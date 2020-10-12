using System;

namespace ThreadTest
{
    partial class ThreadTest
    {
        public static void Task2()
        {
            Console.Write("Введите не отрицательное число: ");
            var number = Convert.ToInt32(Console.ReadLine());
            TreadsLauncher.LaunchThreadsToCalculateProductOfNumber(number);

            // как сделать, чтобы дожидаться окончания потоков и после этого выводит результат
            Console.WriteLine($"Факториал {number}! = {Program.Factorial}");
            Console.ReadLine();
        }
    }
}
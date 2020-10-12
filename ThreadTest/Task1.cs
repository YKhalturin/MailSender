using System;

namespace ThreadTest
{

    partial class ThreadTest
    {
        public static void Task1()
        {
            Console.Write("Введите положительное число: ");
            var number = Convert.ToInt32(Console.ReadLine());
            TreadsLauncher.LaunchThreadsToCalculateSum(number);
            
            // как сделать, чтобы дожидаться окончания потоков и после этого выводит результат
            Console.WriteLine($"Сумма чисел от 1 до {number} = {Program.TotalAmount}");
            Console.ReadLine();
        }
    }

}
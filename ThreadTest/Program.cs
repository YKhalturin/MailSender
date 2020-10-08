using System;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        public static long TotalAmount = 0;
        public static long Factorial = 1;

        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - Вычисляем сумму неотрицательных числел до N. Многопоточно");
                Console.WriteLine("2 - Вычисляем факториал до N. Многопоточно");
                Console.WriteLine("0 - Выход");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 4);
            return m;
        }

        static void Main(string[] args)
        {
            int menu;
            do
            {
                menu = Menu();
                switch (menu)
                {
                    case 1:
                        ThreadTest.Task1();
                        break;
                    case 2:
                        ThreadTest.Task2();
                        break;
                    default:
                        Console.WriteLine("Bye!");
                        break;
                }
            }
            while (menu != 0);
        }
    }
}

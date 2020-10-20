using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Test
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
                Console.WriteLine(@"1 - Есть ли проблемы в следующем коде? 
                                    int i = 1;
                                    object obj = i;
                                    ++i;
                                    Console.WriteLine(i);
                                    Console.WriteLine(obj);
                                    Console.WriteLine((short)obj);");
                Console.WriteLine(@"2 - Каков результат вывода следующего кода?
                                    private enum SomeEnum
                                    {
                                        First = 4,
                                        Second,
                                        Third = 7
                                    }
                                    static void Main(string[] args)
                                    {
                                        Console.WriteLine((int)SomeEnum.Second);
                                    }");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("--------------------------------------");
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
                        Lesson8Test.Task2();
                        break;
                    case 2:
                        Lesson8Test.Task4();
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

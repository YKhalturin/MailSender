using System;

namespace Lesson8Test
{
    partial class Lesson8Test
    {

        public static void Task2()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            try
            {
                Console.WriteLine((short)obj);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"Произошла ошибка приведения типов: {e.Message}");
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}
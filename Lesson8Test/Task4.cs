using System;

namespace Lesson8Test
{
    partial class Lesson8Test
    {
        private enum SomeEnum
        {
            First = 4,
            Second,
            Third = 7
        }

        public static void Task4()
        {
            Console.WriteLine($"Second = {(int)SomeEnum.Second}");
            Console.WriteLine("--------------------------------------");
        }

    }
}
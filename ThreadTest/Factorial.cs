using System;

namespace ThreadTest
{
    public class Factorial
    {
        private int x;
        private int y;
        object locker = new object();
        public Factorial(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void ProductOfNumbers(object state)
        {
            int proiz = x;
            for (int i = x + 1; i <= y; i++)
            {
                proiz *= i;
            }
            lock (locker)
            {
                Program.Factorial *= proiz;
                Console.WriteLine($"Прмежуточное произведение в потоке =  {Program.Factorial}.");
            }
        }
    }
}
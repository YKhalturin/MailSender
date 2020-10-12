using System;

namespace ThreadTest
{
    public class PositiveNumbers
    {
        private int x;
        private int y;
        static object locker = new object();
        public PositiveNumbers(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Sum(object state)
        {
            int sum = x;
            for (int i = x + 1; i <= y; i++)
            {
                sum += i;
            }
            lock (locker)
            {
                Program.TotalAmount += sum;
                Console.WriteLine($"Прмежуточная сумма в потоке =  {Program.TotalAmount}.");
            }
        }
    }
}
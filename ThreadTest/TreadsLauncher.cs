using System;
using System.Threading;

namespace ThreadTest
{
    public class TreadsLauncher
    {
        static object locker = new object();
        private static int _amountOfNumbersForSingleThreads = 5;
        public static void LaunchThreadsToCalculateSum(int number)
        {
            PositiveNumbers positiveNumbers;
            if (number < _amountOfNumbersForSingleThreads)
            {
                positiveNumbers = new PositiveNumbers(1, number);
                ThreadPool.QueueUserWorkItem(new WaitCallback(positiveNumbers.Sum));
            }
            else
            {
                for (int i = 1; i <= number; i += _amountOfNumbersForSingleThreads)
                {
                    if (number - i < _amountOfNumbersForSingleThreads) positiveNumbers = new PositiveNumbers(i, number);
                    else
                    {
                        positiveNumbers = new PositiveNumbers(i, i + 4);
                    }
                    ThreadPool.QueueUserWorkItem(new WaitCallback(positiveNumbers.Sum));
                }
            }
        }

        public static void LaunchThreadsToCalculateProductOfNumber(int number)
        {
            Factorial factorial;
            if (number < _amountOfNumbersForSingleThreads)
            {
                factorial = new Factorial(1, number);
                ThreadPool.QueueUserWorkItem(new WaitCallback(factorial.ProductOfNumbers));
            }
            else
            {
                for (int i = 1; i <= number; i += _amountOfNumbersForSingleThreads)
                {
                    if (number - i < _amountOfNumbersForSingleThreads) factorial = new Factorial(i, number);
                    else
                    {
                        factorial = new Factorial(i, i + 4);
                    }
                    ThreadPool.QueueUserWorkItem(new WaitCallback(factorial.ProductOfNumbers));
                }
            }
        }
    }
}
using System;

namespace HomeworkAssignmentLibrary
{
    class FibonacciNumbers
    {
        public long FibonacciNumbersByCycle(long n)
        {
            if (n < 0)
                throw new ArgumentException("n должно быть положительное");
            long feb0 = 0;
            long feb1 = 1;
            long feb = 0;
            if (n == 0)
                return feb0;
            if (n == 1)
                return feb1;
            for (long i = 2; i <= n; i++)
            {
                feb = feb1 + feb0;
                feb0 = feb1;
                feb1 = feb;
            }
            return feb;
        }
        public long FibonacciNumbersByRecursion(long n)
        {
            if (n < 0)
                throw new ArgumentException("n должно быть положительное");
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Recursion(0, 1, n);
        }
        static long Recursion(long feb0, long feb1, long n)
        {
            long feb;
            if (n > 2)
            {
                feb = Recursion(feb1, feb0 + feb1, --n);
            }
            else
            {
                feb = feb0 + feb1;
            }
            return feb;
        }
    }
}

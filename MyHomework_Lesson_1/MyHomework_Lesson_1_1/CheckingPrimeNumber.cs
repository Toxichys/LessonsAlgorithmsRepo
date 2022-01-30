using System;

namespace MyHomework_Lesson_1_1
{
    class CheckingPrimeNumber
    {
     public bool CheckingPrimeNumberMethod(long number)
    {
            long d = 0;
            long i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                Console.WriteLine($"Число {number} - не простое");
            }
            else
            {
                Console.WriteLine($"Число {number} - простое");
            }
            return d == 0;
        }
    }
}

using System;

namespace MyHomework_Lesson_1_1
{
    class Program
    {
        public class TestTaskOne
        {
            public long number { get; set; }
            public bool Expected { get; set; }
        }

        static void TestCheckingPrimeNumber(TestTaskOne testTaskOne)
        {
            CheckingPrimeNumber checkingPrimeNumber = new CheckingPrimeNumber();
            bool result = checkingPrimeNumber.CheckingPrimeNumberMethod(testTaskOne.number);
            if (result == testTaskOne.Expected)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }
 
        static void Main(string[] args)
        {
            TestTaskOne testTaskOne1 = new TestTaskOne()
            {
                number = 6,
                Expected = false,
            };

            TestTaskOne testTaskOne2 = new TestTaskOne()
            {
                number = 7,
                Expected = true,
            };

            TestCheckingPrimeNumber(testTaskOne1);
            TestCheckingPrimeNumber(testTaskOne2);
        }
    }
}

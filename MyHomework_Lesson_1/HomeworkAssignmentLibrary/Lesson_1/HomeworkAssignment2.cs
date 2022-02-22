using System;
using InterfaceHomeworkAssignmentLibrary;

namespace HomeworkAssignmentLibrary.Lesson_1
{
    public class HomeworkAssignment2 : IHomeworkAssignments
    {
        public string HomeworkID { get => "1_2"; }
        public string HomeworkName { get => "Домашнее задание 2 урок 1"; }
        private class TestTaskTwo
        {
            public long n { get; set; }
            public long Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        private static void TestFibonacciNumbers(TestTaskTwo testTaskTwo, int i)
        {
            try
            {
                long actual;
                FibonacciNumbers fibonacciNumbers = new FibonacciNumbers();
                switch (i)
                {
                    case 0:
                        actual = fibonacciNumbers.FibonacciNumbersByCycle(testTaskTwo.n);
                        break;
                    case 1:
                        actual = fibonacciNumbers.FibonacciNumbersByRecursion(testTaskTwo.n);
                        break;
                    default:
                        Console.WriteLine("INVALID TEST");
                        return;
                }
                if (actual == testTaskTwo.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testTaskTwo.ExpectedException != null)
                {
                    if (testTaskTwo.ExpectedException.Message == ex.Message)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }

        }
        public void HomeworkTest()
        {
            TestTaskTwo testTaskTwo1 = new TestTaskTwo()
            {
                n = 6,
                Expected = 8,
                ExpectedException = null
            };
            TestTaskTwo testTaskTwo2 = new TestTaskTwo()
            {
                n = -6,
                Expected = 10,
                ExpectedException = new ArgumentException("n должно быть положительное")
            };
            TestTaskTwo testTaskTwo3 = new TestTaskTwo()
            {
                n = 70,
                Expected = 190392490709135,
                ExpectedException = null
            };
            Console.WriteLine("Тест функции Фибоначчи реализованное циклом");
            TestFibonacciNumbers(testTaskTwo1, 0);
            TestFibonacciNumbers(testTaskTwo2, 0);
            TestFibonacciNumbers(testTaskTwo3, 0);
            Console.WriteLine("Тест функции Фибоначчи реализованное рекурсией");
            TestFibonacciNumbers(testTaskTwo1, 1);
            TestFibonacciNumbers(testTaskTwo2, 1);
            TestFibonacciNumbers(testTaskTwo3, 1);
        }
    }
}

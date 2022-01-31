﻿using System;

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
        public class TestTaskTwo
        {
            public long n { get; set; }
            public long Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static void TestFibonacciNumbers(TestTaskTwo testTaskTwo, int i)
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
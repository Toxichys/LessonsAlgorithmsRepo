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
        static void WriteMainMenu()
        {
            Console.WriteLine("Основное меню");
            Console.WriteLine("Для выхода введите 0");
            Console.WriteLine("Для вывода 1 задания 1 урока введите 1");
            Console.WriteLine("Для вывода 2 задания 1 урока введите 2");
            Console.WriteLine("Для вывода 1 задания 2 урока введите 3");
        }
        static void MakeSelection(int a)
        {
            switch (a)
            {
                case 1:
                    TestLesson1_1();
                    break;
                case 2:
                    TestLesson1_2();
                    break;
                case 3:
                    TestLesson2_1();
                    break;
            }
        }
        static void TestLesson1_1()
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
        static void TestLesson1_2()
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
        static void TestLesson2_1()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddNode(10);
            myLinkedList.AddNode(20);
            myLinkedList.AddNode(30);
            myLinkedList.AddNode(40);
            myLinkedList.AddNode(50);
            Console.WriteLine("Список после добавления элементов в конец");
            myLinkedList.PrintList();
            Node afterNode = myLinkedList.FindNode(40);
            myLinkedList.AddNodeAfter(afterNode, 45);
            Console.WriteLine("Список после добавления элемента после определенного элемента");
            myLinkedList.PrintList();
            myLinkedList.RemoveNode(afterNode);
            Console.WriteLine("Список после удаления элемента");
            myLinkedList.PrintList();
            myLinkedList.RemoveNode(2);
            Console.WriteLine("Список после удаления элемента по номеру");
            myLinkedList.PrintList();
        }
        static void Main(string[] args)
        {
            int a;
            do
            {
                WriteMainMenu();
                a = Int32.Parse(Console.ReadLine());
                MakeSelection(a);
            } while (a != 0);
        }
    }
}

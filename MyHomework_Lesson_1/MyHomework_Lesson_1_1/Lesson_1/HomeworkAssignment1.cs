using System;

namespace MyHomework_Lesson_1_1.Lesson_1
{
    public class HomeworkAssignment1 : IHomeworkAssignments
    {
        public string HomeworkID { get => "1_1"; }
        public string HomeworkName { get => "Домашнее задание 1 урок 1"; }
        private class TestTaskOne
        {
            public long number { get; set; }
            public bool Expected { get; set; }
        }
        private static void TestCheckingPrimeNumber(TestTaskOne testTaskOne)
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
        public void HomeworkTest()
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
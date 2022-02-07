using System;
using System.Diagnostics;

namespace MyHomework_Lesson_1_1.Lesson_3
{
    public class HomeworkAssignment4 : IHomeworkAssignments
    {
        public string HomeworkID { get => "3_1"; }
        public string HomeworkName { get => "Домашнее задание 1 урок 3"; }
        private static void GetPointClassDoubleArray(int count)
        {
            Random random = new Random();
            PointClassDouble[] pointClassDoubles = new PointClassDouble[count];
            for (int i = 0; i < count; i++)
                pointClassDoubles[i] = new PointClassDouble() {X = random.NextDouble(), Y = random.NextDouble()};
        }
        private static void GetPointStructDoubleArray(int count)
        {
            Random random = new Random();
            PointStructDouble[] pointStructDoubles = new PointStructDouble[count];
            for (int i = 0; i < count; i++)
                pointStructDoubles[i] = new PointStructDouble() { X = random.NextDouble(), Y = random.NextDouble() };
        }
        private static void PrintHead()
        {
            Console.WriteLine("Количество точек | PointStructDouble | PointClassDouble | Ratio");
        }
        private static void PrintLine(ResultStopwatch resultStopwatch)
        {
            Console.WriteLine($"{resultStopwatch.Count}           |" +
                $" {resultStopwatch.ElapsedStruct}  |" +
                $" {resultStopwatch.ElapsedClass} |" +
                $" {ResultStopwatch.Ratio(resultStopwatch.ElapsedMillisecondsStruct,resultStopwatch.ElapsedMillisecondsClass)}");
        }
        public void HomeworkTest()
        {
            /*Создаем 2 типа:
            * структура PointStructDouble с полями типа double (Double)
            * класс PointClassDouble с полями типа double (Double)
            Создаем метод, возвращающий расстояние между парой точек каждого типа.
            Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями.
            Проводим замеры длительности выполнения методов на массивах разного размера.
            Вывод может иметь вид (соответственно x, y - время выполнения, Ratio - отношение времени):
            Количество точек | PointStructDouble | PointClassDouble | Ratio
            100000 | x1 | y1| y1/x1
            200000 | x2 | y2 | y2/x2
            */
            PrintHead();
            ResultStopwatch resultStopwatch = new ResultStopwatch();
            for (int i = 1; i <= 2; i++)
            {
                resultStopwatch.Count = 100000 * i;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                GetPointClassDoubleArray(resultStopwatch.Count);
                stopwatch.Stop();
                resultStopwatch.ElapsedClass = stopwatch.Elapsed;
                resultStopwatch.ElapsedMillisecondsClass = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                stopwatch.Start();
                GetPointStructDoubleArray(resultStopwatch.Count);
                stopwatch.Stop();
                resultStopwatch.ElapsedStruct = stopwatch.Elapsed;
                resultStopwatch.ElapsedMillisecondsStruct = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                PrintLine(resultStopwatch);
            }
        }
        private class ResultStopwatch
        {
            public int Count { get; set; }
            public TimeSpan ElapsedClass { get; set; }
            public TimeSpan ElapsedStruct { get; set; }
            public long ElapsedMillisecondsClass { get; set; }
            public long ElapsedMillisecondsStruct { get; set; }
            public static double Ratio(long x, long y)
            {
                return (double)y / (double)x;
            }
        }
    }
}

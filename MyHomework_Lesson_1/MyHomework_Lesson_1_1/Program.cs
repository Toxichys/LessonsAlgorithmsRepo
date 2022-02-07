using System;
using MyHomework_Lesson_1_1.Lesson_1;
using MyHomework_Lesson_1_1.Lesson_2;
using MyHomework_Lesson_1_1.Lesson_3;

namespace MyHomework_Lesson_1_1
{
    class Program
    {
        static void WriteMainMenu(IHomeworkAssignments[] iHomeworkAssignments)
        {
            Console.WriteLine("Основное меню");
            Console.WriteLine("Для выхода введите 0");
            for (int i = 0; i < iHomeworkAssignments.Length; i++)
            {
                Console.WriteLine($"Для вывода \"{iHomeworkAssignments[i].HomeworkName}\" введите {iHomeworkAssignments[i].HomeworkID}");
            }
        }
        static void MakeSelection(string a, IHomeworkAssignments[] iHomeworkAssignments)
        {
            for (int i = 0; i < iHomeworkAssignments.Length; i++)
            {
                if (iHomeworkAssignments[i].HomeworkID == a)
                    iHomeworkAssignments[i].HomeworkTest();
            }
        }
        static IHomeworkAssignments[] GetArrayHomeworkAssignments()
        {
            IHomeworkAssignments[] iHomeworkAssignments = new IHomeworkAssignments[4];
            iHomeworkAssignments[0] = new HomeworkAssignment1();
            iHomeworkAssignments[1] = new HomeworkAssignment2();
            iHomeworkAssignments[2] = new HomeworkAssignment3();
            iHomeworkAssignments[3] = new HomeworkAssignment4();
            return iHomeworkAssignments;
        }
        static void Main(string[] args)
        {
            IHomeworkAssignments[] iHomeworkAssignments = GetArrayHomeworkAssignments();
            string a;
            do
            {
                WriteMainMenu(iHomeworkAssignments);
                a = Console.ReadLine();
                MakeSelection(a, iHomeworkAssignments);
            } while (a != "0");
        }
    }
}

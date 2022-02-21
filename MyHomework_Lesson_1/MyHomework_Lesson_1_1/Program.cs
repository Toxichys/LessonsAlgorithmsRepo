using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using InterfaceHomeworkAssignmentLibrary;

namespace MyHomework_Lesson_1_1
{
    class Program
    {
        static void WriteMainMenu(List<IHomeworkAssignments> iHomeworkAssignments)
        {
            Console.WriteLine("Основное меню");
            Console.WriteLine("Для выхода введите 0");
            foreach (IHomeworkAssignments iHomeworkAssignment in iHomeworkAssignments)
                Console.WriteLine($"Для вывода \"{iHomeworkAssignment.HomeworkName}\" введите {iHomeworkAssignment.HomeworkID}");
        }
        static void MakeSelection(string a, List<IHomeworkAssignments> iHomeworkAssignments)
        {
            foreach (IHomeworkAssignments iHomeworkAssignment in iHomeworkAssignments)
                if (iHomeworkAssignment.HomeworkID == a)
                    iHomeworkAssignment.HomeworkTest();
        }

        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load(File.ReadAllBytes("HomeworkAssignmentLibrary.dll"));
            Type t = asm.GetType("HomeworkAssignmentLibrary.HomeworkAssignmentLibrary");
            Object instance = Activator.CreateInstance(t);
            MethodInfo method = t.GetMethod("GetListHomeworkAssignmentsFromLibrary", BindingFlags.Instance | BindingFlags.Public);
            List<IHomeworkAssignments> iHomeworkAssignments = (List<IHomeworkAssignments>)method.Invoke(instance, null);
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

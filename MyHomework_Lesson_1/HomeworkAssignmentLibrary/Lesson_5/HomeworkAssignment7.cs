using System;
using HomeworkAssignmentLibrary.Lesson_4;
using InterfaceHomeworkAssignmentLibrary;

namespace HomeworkAssignmentLibrary.Lesson_5
{
    class HomeworkAssignment7 : IHomeworkAssignments
    {
        public string HomeworkID { get => "5_2"; }

        public string HomeworkName { get => "Домашнее задание 2 урок 5 (поиска в дереве - поиск в глубину)"; }

        public void HomeworkTest()
        {
            Tree tree = new Tree();
            Console.WriteLine("Дерево:");
            Tree.FillTree(tree);
            tree.PrintTree();
            Console.WriteLine("Введите значение дерева для поиска:");
            int findValue;
            int.TryParse(Console.ReadLine(), out findValue);
            TreeNode findNode = tree.GetNodeByValueMethodDFS(findValue);
            if (findNode != null)
                Console.WriteLine($"\nЗначение {findValue} найдено!");
            else
                Console.WriteLine($"\nЗначение {findValue} не найдено!");
        }
    }
}

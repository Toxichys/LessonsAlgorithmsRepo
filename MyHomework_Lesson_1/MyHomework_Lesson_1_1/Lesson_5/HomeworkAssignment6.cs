using MyHomework_Lesson_1_1.Lesson_4;
using System;

namespace MyHomework_Lesson_1_1.Lesson_5
{
    class HomeworkAssignment6 : IHomeworkAssignments
    {
        public string HomeworkID { get => "5_1"; }

        public string HomeworkName { get => "Домашнее задание 1 урок 5 (поиска в дереве - поиск в ширину)"; }

        public void HomeworkTest()
        {
            Tree tree = new Tree();
            Console.WriteLine("Дерево:");
            Tree.TestTree(tree);
            tree.PrintTree();
            Console.WriteLine("Введите значение дерева для поиска:");
            int findValue;
            int.TryParse(Console.ReadLine(), out findValue);
            TreeNode findNode = tree.GetNodeByValueMethodBFS(findValue);
            if (findNode != null)
                Console.WriteLine($"\nЗначение {findValue} найдено!");
            else
                Console.WriteLine($"\nЗначение {findValue} не найдено!");
        }
    }
}

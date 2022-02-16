using System;

namespace MyHomework_Lesson_1_1.Lesson_4
{
    public class HomeworkAssignment5 : IHomeworkAssignments
    {
        public string HomeworkID { get => "4_1"; }
        public string HomeworkName { get => "Домашнее задание 1 урок 4"; }
        public void HomeworkTest()
        {
            /*Реализуйте класс двоичного дерева поиска
             * с операциями вставки, удаления, поиска.
             * Также напишите метод вывода в консоль дерева,
             * чтобы увидеть, насколько корректно работает ваша реализация.
            */
            Tree tree = new Tree();
            Console.WriteLine("Дерево:");
            Tree.TestTree(tree);
            tree.PrintTree();
            tree.RemoveItem(27);
            Console.WriteLine("Дерево после удаления элмента:");
            tree.PrintTree();
        }
    }
}

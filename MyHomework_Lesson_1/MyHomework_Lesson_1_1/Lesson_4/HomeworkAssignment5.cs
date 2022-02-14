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
            tree.AddItem(50);
            tree.AddItem(30);
            tree.AddItem(70);
            tree.AddItem(25);
            tree.AddItem(45);
            tree.AddItem(55);
            tree.AddItem(75);
            tree.AddItem(20);
            tree.AddItem(27);
            tree.AddItem(40);
            tree.AddItem(51);
            tree.AddItem(60);
            tree.AddItem(68);
            tree.AddItem(80);
            tree.AddItem(10);
            tree.AddItem(18);
            tree.AddItem(74);
            tree.AddItem(90);
            tree.AddItem(1);
            tree.AddItem(15);
            tree.AddItem(73);
            tree.AddItem(85);
            Console.WriteLine("Дерево:");
            tree.PrintTree();
            tree.RemoveItem(27);
            Console.WriteLine("Дерево после удаления элмента:");
            tree.PrintTree();
        }
    }
}

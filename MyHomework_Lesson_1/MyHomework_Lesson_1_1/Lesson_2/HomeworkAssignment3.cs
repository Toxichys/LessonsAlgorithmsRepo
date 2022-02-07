using System;

namespace MyHomework_Lesson_1_1.Lesson_2
{
    public class HomeworkAssignment3 : IHomeworkAssignments
    {
        public string HomeworkID { get => "2_1"; }
        public string HomeworkName { get => "Домашнее задание 1 урок 2"; }
        public void HomeworkTest()
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
    }
}

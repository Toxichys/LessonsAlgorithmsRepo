using System;

namespace MyHomework_Lesson_1_1
{
    public class MyLinkedList : ILinkedList
    {
        public Node FirstNode { get; set; }
        public Node LastNode { get; set; }
        public void AddNode(int value)
        {
            Node newNode = new Node(value);
            if (FirstNode == null)
                FirstNode = newNode;
            else
            {
                LastNode.NextNode = newNode;
                newNode.PrevNode = LastNode;
            }
            LastNode = newNode;
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node(value);
            if (node.NextNode == null)
                LastNode = newNode;
            else
            {
                Node afterNode = node.NextNode;
                afterNode.PrevNode = newNode;
                newNode.NextNode = afterNode;
            }
            node.NextNode = newNode;
            newNode.PrevNode = node;
        }

        public Node FindNode(int searchValue)
        {
            Node findNode = FirstNode;
            while (findNode != null)
            {
                if (findNode.Value == searchValue)
                    return findNode;
                findNode = findNode.NextNode;
            }
            return FirstNode;
        }

        public int GetCount()
        {
            int currentCount = 0;
            Node currentNode = FirstNode;
            while (currentNode != null)
            {
                currentCount++;
            }
            return currentCount;
        }

        public void RemoveNode(int index)
        {
            if (index == 0)
            {
                if (FirstNode.NextNode == null)
                {
                    FirstNode = null;
                    LastNode = null;
                }
                else
                {
                    Node newFirstNode = FirstNode.NextNode;
                    FirstNode.NextNode = null;
                    newFirstNode.PrevNode = null;
                    FirstNode = newFirstNode;
                }
            }
            else
            {
                int currentIndex = 0;
                Node currentNode = FirstNode;
                while (currentNode != null)
                {
                    if (currentIndex == index - 1)
                    {
                        RemoveNode(currentNode);
                        break;
                    }
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
            }
        }

        public void RemoveNode(Node node)
        {
            if (node.PrevNode == null)
                FirstNode = node.NextNode;
            if (node.NextNode == null)
                LastNode = node.PrevNode;
            Node nextNode = node.NextNode;
            Node prevNode = node.PrevNode;
            nextNode.PrevNode = prevNode;
            prevNode.NextNode = nextNode;
        }
        public void PrintList()
        {
            Node currentNode = FirstNode;
            while (currentNode != null)
            {
                Console.Write($"{currentNode.Value}\t");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine();
        }
    }
}
using System;

namespace MyHomework_Lesson_1_1.Lesson_4
{
    public class Tree : ITree
    {
        private TreeNode rootNode;
        public TreeNode GetRoot()
        {
            return rootNode;
        }
        public void AddItem(int value)
        {
            TreeNode tmp = rootNode;
            if (tmp == null)
            {
                tmp = new TreeNode(value, tmp);
                rootNode = tmp;
                return;
            }
            while (tmp != null)
            {
                if (value > tmp.Value)
                {
                    if (tmp.RightChild != null)
                    {
                        tmp = tmp.RightChild;
                        continue;
                    }
                    else
                    {
                        tmp.RightChild = new TreeNode(value, tmp);
                        return;
                    }
                }
                else
                {
                    if (tmp.LeftChild != null)
                    {
                        tmp = tmp.LeftChild;
                        continue;
                    }
                    else
                    {
                        tmp.LeftChild = new TreeNode(value, tmp);
                        return;
                    }
                }
            }
        }
        public void RemoveItem(int value)
        {
            TreeNode nodeByValue = GetNodeByValue(value);
            if (nodeByValue == null)
                Console.WriteLine($"Удаление не возможно. Элемент со значением {value} не найден.");
            else if (nodeByValue.LeftChild != null && nodeByValue.RightChild != null)
                Console.WriteLine($"Удаление не возможно. У элемент со значением {value} существует два потомка.");
            else if (nodeByValue.LeftChild == null && nodeByValue.RightChild == null)
            {
                if (nodeByValue.Parent == null)
                {
                    rootNode = null;
                    return;
                }
                if (nodeByValue == nodeByValue.Parent.LeftChild)
                    nodeByValue.Parent.LeftChild = null;
                else
                    nodeByValue.Parent.RightChild = null;
            }
            else
            {
                TreeNode nodeMove;
                if (nodeByValue.LeftChild != null)
                    nodeMove = nodeByValue.LeftChild;
                else
                    nodeMove = nodeByValue.RightChild;
                nodeMove.Parent = nodeMove.Parent.Parent;
                if (nodeMove.Parent == null)
                {
                    rootNode = nodeMove;
                    return;
                }
                if (nodeByValue.LeftChild != null)
                    nodeMove.Parent.LeftChild = nodeMove;
                else
                    nodeMove.Parent.RightChild = nodeMove;
            }
        }
        public TreeNode GetNodeByValue(int value)
        {
            TreeNode tmp = rootNode;
            if (tmp != null)
            {
                while (tmp != null)
                {
                    if (value == tmp.Value)
                    {
                        return tmp;
                    }
                    else if (value > tmp.Value)
                    {
                        tmp = tmp.RightChild;
                    }
                    else
                    {
                        tmp = tmp.LeftChild;
                    }
                }
            }
            return tmp;
        }
        public void PrintTree()
        {
            NodeInfo[] arrayNodeInfo = TreeHelper.GetTreeInLine(this);
            (int width, int height) = Console.GetCursorPosition();
            int maxDepth = arrayNodeInfo[arrayNodeInfo.Length - 1].Depth;
            int centre = (int)Math.Pow(2, maxDepth);
            if (Console.BufferWidth < centre * 2 + 1)
                Console.BufferWidth = centre * 2 + 1;
            int widthPos = 0;
            for (int i = 0; i < arrayNodeInfo.Length; i++)
            {
                int heightPos = height + arrayNodeInfo[i].Depth * 2;
                if (arrayNodeInfo[i].Depth == 0)
                    widthPos = centre;
                else
                {
                    int widthSize = centre / (int)Math.Pow(2, arrayNodeInfo[i].Depth);
                    if (arrayNodeInfo[i].Node == arrayNodeInfo[i].Node.Parent.LeftChild)
                        widthPos = arrayNodeInfo[i].Parent.pos - widthSize;
                    else
                        widthPos = arrayNodeInfo[i].Parent.pos + widthSize;
                    //красота
                    if (arrayNodeInfo[i].Parent.pos >= widthPos)
                        Printbeauty("┌", "┘", widthPos, arrayNodeInfo[i].Parent.pos, heightPos - 1);
                    else
                        Printbeauty("└", "┐", arrayNodeInfo[i].Parent.pos + 1, widthPos, heightPos - 1);
                }
                Console.SetCursorPosition(widthPos, heightPos);
                Console.WriteLine($"{arrayNodeInfo[i].Node.Value}");
                arrayNodeInfo[i].pos = widthPos;
            }
        }
        public void Printbeauty(string start, string end, int widthPos1, int widthPos2, int heightPos)
        {
            Console.SetCursorPosition(widthPos1, heightPos);
            Console.Write(start);
            while (Console.CursorLeft < widthPos2) Console.Write("─");
            Console.Write(end);
        }
    }
}

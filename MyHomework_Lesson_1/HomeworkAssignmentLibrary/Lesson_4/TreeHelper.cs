using System.Collections.Generic;

namespace HomeworkAssignmentLibrary.Lesson_4
{
    public static class TreeHelper
    {
        public static NodeInfo[] GetTreeInLine(ITree tree)
        {
            Queue<NodeInfo> bufer = new Queue<NodeInfo>();
            List<NodeInfo> returnArray = new List<NodeInfo>();
            NodeInfo root = new NodeInfo() { Node = tree.GetRoot() };
            bufer.Enqueue(root);

            while (bufer.Count != 0)
            {
                NodeInfo element = bufer.Dequeue();
                returnArray.Add(element);

                int depth = element.Depth + 1;

                if (element.Node.LeftChild != null)
                {
                    NodeInfo left = new NodeInfo()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                        Parent = element,
                    };
                    bufer.Enqueue(left);
                }
                if (element.Node.RightChild != null)
                {
                    NodeInfo right = new NodeInfo()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                        Parent = element,
                    };
                    bufer.Enqueue(right);
                }
            }

            return returnArray.ToArray();
        }
    }
    public class NodeInfo
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }
        public NodeInfo Parent { get; set; }
        public int pos { get; set; }
    }
}

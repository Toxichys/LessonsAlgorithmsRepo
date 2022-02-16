namespace MyHomework_Lesson_1_1.Lesson_4
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode Parent { get; set; }
        public TreeNode(int value, TreeNode parent)
        {
            Value = value;
            Parent = parent;
        }
    }
}

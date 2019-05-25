namespace HuffmanVisualizer
{
    class ParentNode : Node
    {
        public Node Left { get; }      // bit: 0

        public Node Right { get; }     // bit: 1
        
        public int Weight { get; }

        public ParentNode(ParentNode left, int weight, ParentNode right) 
        {
            Left = left;
            Weight = weight;
            Right = right;
        }
    }
}

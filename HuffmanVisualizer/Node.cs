namespace HuffmanVisualizer
{
    class Node
    {
        public Node Left { get; }      // bit: 0
        public byte Character { get; } // 0-255 (ANSI Character set)
        public Node Right { get; }     // bit: 1
        public int Weight { get; }     // Weight for nodes, Frequency for leaf-nodes

        public Node(char character, int frequency)
        {
            // Converts any Character that is not ANSI (>255) to '?' (63)
            if (character > 255)
                Character = (byte)'?';
            else
                Character = (byte)character;

            Weight = frequency;
        }

        public Node(Node left, int weight, Node right)
        {
            Left = left;
            Weight = weight;
            Right = right;
        }

        /// <summary>
        /// Recursively calls <seealso cref="Node.Right"></seealso> or <seealso cref="Node.Left"></seealso>
        /// of the calling <seealso cref="Node"></seealso> depending of the first character from <param name="path">description</param>. 
        /// First char from <seealso cref="path">path</seealso> is removed each call. 
        /// </summary>
        /// <param name="path">The path to take, 0 is <seealso cref="Node.Right"></seealso>, 1 is <seealso cref="Node.Left"></seealso>.</param>
        /// <returns>
        /// If path is empty Character is returned.
        /// </returns>
        public char GetCharacterFrom(string path)
        {
            if (string.IsNullOrEmpty(path))
                return (char)Character;

            if (path[0] == 0)
                return Left.GetCharacterFrom(path.Substring(1));
            else
                return Right.GetCharacterFrom(path.Substring(1));
        }
    }
}

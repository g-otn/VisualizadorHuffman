using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanVisualizer
{
    class Node
    {
        public char GetCharacterFromPath(string path)
        {
            if (this is Leaf)
                return (char)((Leaf)this).Character;

            if (path[0] == '0')
                return ((ParentNode)this).Left.GetCharacterFromPath(path.Substring(1)); // 0
            else
                return ((ParentNode)this).Right.GetCharacterFromPath(path.Substring(1)); // 1
        }
    }
}

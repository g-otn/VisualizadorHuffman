using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanVisualizer
{
    class Leaf : Node
    {
        /// <summary>
        /// The ANSI value of the <see cref="ParentNode"/> 
        /// </summary>
        public byte Character { get; } // 0-255 (ANSI Character set)
        public int Frequency { get; }

        public Leaf(char character, int frequency)
        {
            // Converts any Character that is not ANSI (>255) to '?' (63)
            if (character > 255)
                Character = (byte)'?';
            else
                Character = (byte)character;

            Frequency = frequency;
        }
    }
}

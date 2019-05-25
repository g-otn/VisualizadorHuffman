using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanVisualizer
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVisualizer());

            // Console Test
            Leaf leaf = new Leaf('a', 2);
            Leaf leaf2 = new Leaf('b', 3);
            ParentNode parentNode = new ParentNode(leaf, leaf.Frequency + leaf2.Frequency, leaf2);
            Console.WriteLine(leaf.Frequency);
            Console.WriteLine(parentNode.Weight);
            Console.WriteLine(parentNode.GetCharacterFromPath("1"));
            Console.WriteLine(parentNode.GetCharacterFromPath("0"));
        }
    }
}

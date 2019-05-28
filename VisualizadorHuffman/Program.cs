using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorHuffman
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVisualizador());

            // Debug no Console
            Folha a = new Folha('a', 1);
            Folha b = new Folha('b', 2);
            Folha c = new Folha('c', 3);
            NoPai p1 = new NoPai(a, b);
            NoPai p2 = new NoPai(p1, c);
            Console.WriteLine("Leaf f: a: " + a.Frequencia + " b: " + b.Frequencia + " c: " + c.Frequencia);
            Console.WriteLine("PNode w: p1: " + p1.Peso + " p2: " + p2.Peso);
            Console.WriteLine("p1 path 0: " + p1.GetCaractereDoCaminho("0") + "\n");
            Console.WriteLine("p1 path 1: " + p1.GetCaractereDoCaminho("1") + "\n");
            Console.WriteLine("p2 path 01: " + p2.GetCaractereDoCaminho("01") + "\n");
            Console.WriteLine("p2 path 00: " + p2.GetCaractereDoCaminho("00") + "\n");
            Console.WriteLine("p2 path 1: " + p2.GetCaractereDoCaminho("1") + "\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorHuffman
{
    class No
    {
        /// <summary>
        /// A soma dos pesos dos <see cref="No"/>s filhos.
        /// </summary>
        public int Peso { get; set; }

        /// <summary>
        /// Cria um <see cref="No"/> com um peso.
        /// </summary>
        /// <param name="peso">A soma dos pesos dos <see cref="No"/>s filhos.</param>
        public No(int peso)
        {
            Peso = peso;
        }
    }
}

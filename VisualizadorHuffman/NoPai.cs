using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorHuffman
{
    class NoPai
    {
        /// <summary>
        /// A soma das frequências e/ou pesos dos <see cref="NoPai"/>s e/ou <see cref="Folha"/>s filho(a)s.
        /// </summary>
        public int Peso { get; set; }

        /// <summary>
        /// Cria um <see cref="NoPai"/> com um peso.
        /// </summary>
        /// <param name="peso">A soma das frequências e/ou pesos dos <see cref="NoPai"/>s e/ou <see cref="Folha"/>s filho(a)s.</param>
        public NoPai(int peso)
        {
            Peso = peso;
        }
    }
}

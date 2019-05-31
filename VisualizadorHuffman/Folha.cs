using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorHuffman
{
    class Folha : No
    {
        /// <summary>
        /// O caractere guardado na <see cref="Folha"/> da árvore.
        /// </summary>
        public char Caractere { get; set; }

        /// <summary>
        /// A frequência que o caractere aparece no texto.
        /// </summary>
        public int Frequencia { get; set; }

        /// <summary>
        /// Cria uma Folha que contém um caractere e sua frequência.
        /// </summary>
        /// <param name="caractere">O caractere que a Folha da árvore armazena.</param>
        /// <param name="frequencia">A frequencia do caractere da Folha</param>
        public Folha(char caractere, int frequencia)
        {
            Caractere = caractere;
            Frequencia = frequencia;
        }
    }
}

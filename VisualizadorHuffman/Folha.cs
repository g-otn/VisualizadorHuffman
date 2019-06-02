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
        /// O caractere guardado em uma <see cref="Folha"/> da árvore.
        /// </summary>
        public char Caractere { get; set; }

        /// <summary>
        /// Cria uma Folha que contém um caractere e seu frequência.
        /// </summary>
        /// <param name="caractere">O caractere que a Folha da árvore armazena.</param>
        /// <param name="frequencia">A frequencia do caractere da Folha</param>
        public Folha(char caractere, int frequencia) : base(frequencia)
        {
            Caractere = caractere;
            Peso = frequencia;
        }
    }
}

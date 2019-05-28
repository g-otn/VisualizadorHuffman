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
        /// O valor ANSI do caractere.
        /// </summary>
        public byte Caractere { get; set; } // 0-255 (Intervalo dos caracteres ANSI)

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
            // Converte qualquer caractere que não é ANSI (>255) para 63 ('?')
            if (caractere > 255)
                Caractere = (byte)'?';
            else
                Caractere = (byte)caractere;

            Frequencia = frequencia;
        }
    }
}

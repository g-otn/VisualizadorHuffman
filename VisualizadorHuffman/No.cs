using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorHuffman
{
    class No
    {
        public char GetCaractereDoCaminho(string caminho)
        {
            Console.WriteLine("\tGetCaractereDoCaminho(" + caminho + "):\t" + this);
            // Retorna o Character da Folha se o path estiver vazio (alcançou um fim da árvore)
            if (this is Folha)
                if (!string.IsNullOrEmpty(caminho))
                    throw new Exception($"O caminho não terminou (caminho: \"{caminho}\") mas uma Folha foi encontrada em vez de um NóPai.");
                else
                    return (char)((Folha)this).Caractere;

            // Chama o Nó filho e passa o restante do caminho
            if (string.IsNullOrEmpty(caminho))
                throw new Exception($"O caminho terminou mas um NóPai foi encontrado em vez de uma Folha.");
            else if (caminho[0] == '0')
                return ((NoPai)this).Esquerdo.GetCaractereDoCaminho(caminho.Substring(1));
            else // caminho[0] == '1'
                return ((NoPai)this).Direito.GetCaractereDoCaminho(caminho.Substring(1));
        }
    }
}

namespace VisualizadorHuffman
{
    class NoPai : No
    {
        public No Esquerdo { get; }      // bit: 0

        public No Direito { get; }     // bit: 1
        
        public int Peso { get; }

        public NoPai(No esquerdo, No direito) 
        {
            // Armazena a soma da frequência/peso dos Nós filhos
            if (esquerdo is Folha)
                Peso = ((Folha)esquerdo).Frequencia;
            else
                Peso = ((NoPai)esquerdo).Peso;

            if (direito is Folha)
                Peso += ((Folha)direito).Frequencia;
            else
                Peso += ((NoPai)direito).Peso;

            // Stores child Nodes
            Esquerdo = esquerdo;
            Direito = direito;
        }
    }
}

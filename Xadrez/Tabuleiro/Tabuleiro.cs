namespace tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] Pecas { get; set; }
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}

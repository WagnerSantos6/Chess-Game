

namespace Tabuleiro
{
    internal class Tabuleiros
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiros(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}



namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiros tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiros tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0; 
        }
    }
}

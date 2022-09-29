

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiros tab { get; protected set; }

        public Peca(Tabuleiros tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0; 
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}

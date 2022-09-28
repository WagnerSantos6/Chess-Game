using Tabuleiro;

namespace Xadrez
{
    class Torre : Peca

    {
        public Torre(Tabuleiros tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
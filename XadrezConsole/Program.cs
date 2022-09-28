using System;

using Tabuleiro;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tab = new Tabuleiros(8, 8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}

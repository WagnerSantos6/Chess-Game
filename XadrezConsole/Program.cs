using System;
using Tabuleiro;
using Xadrez;

namespace XadrezConsole
{
     class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('f', 4);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}

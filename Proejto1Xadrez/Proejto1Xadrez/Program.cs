using System;
using tabuleiro;
using xadrez;
namespace Proejto1Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);
            }
            catch (TabuleiroException e) { Console.WriteLine(e.Message); }
        }
    }
}

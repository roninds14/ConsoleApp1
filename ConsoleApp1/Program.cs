using System;
using tabuleiro;
using Xadrez;
using Enums;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez peca = new PosicaoXadrez('b', 1);

                Console.WriteLine(peca);
                Console.WriteLine(peca.toPosicao());

                Console.WriteLine();
            }
            catch (TabuleiroExcepitoon e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        } 
    }
}

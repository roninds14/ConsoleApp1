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
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca( new Torre(tab, Cor.Preta ), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 1));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 2));

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();

        } 
    }
}

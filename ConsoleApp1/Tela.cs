using System;
using tabuleiro;
using Enums;
using Xadrez;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)                
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] possicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    Console.BackgroundColor = possicoesPossiveis[i, j] ? fundoAlterado : fundoOriginal;
                    imprimirPeca(tab.peca(i, j));
                }
                Console.BackgroundColor = fundoOriginal;
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");            
        }

        public static void imprimirPartida( PartidaDeXadrez partida)
        {
            Tela.imprimirTabuleiro(partida.tab);
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("VÔCE ESTÁ EM XEQUE");

            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine();
            Console.WriteLine("Pecas capturadas: ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas:");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto) Console.Write(x);
            Console.Write("]");
        }

        public static void imprimirPeca( Peca p)
        {
            if (p == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (p.cor == Cor.Branca)
                    Console.Write(p);
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(p);
                    Console.ForegroundColor = aux;
                }
            }

        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();

            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez( coluna, linha );
        }
    }
}

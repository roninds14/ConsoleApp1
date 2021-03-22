﻿using System;
using tabuleiro;
using Enums;
using Xadrez;

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
                    if( tab.peca( i, j ) == null )
                        Console.Write( "- ");
                    else
                    {
                        imprimirPeca(tab.peca(i, j));                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca( Peca p)
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

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();

            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez( coluna, linha );
        }
    }
}

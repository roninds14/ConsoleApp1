using System;
using ConsoleApp1.Tabuleiro;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine(p);

            Console.ReadLine();
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using xadrez_console.tabuleiro;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Digite a posicao da linha");
        int psL = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a posicao da coluna");
        int psC = int.Parse(Console.ReadLine());

        Posicao ps = new Posicao(psL, psC);

        Console.WriteLine("Posicoes: l = "+  ps.linha + ", c = " + ps.coluna);
    }
}
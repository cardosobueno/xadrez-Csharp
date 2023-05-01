using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

class Program
{
    static void Main(string[] args)
    {
        
        Tabuleiro tab = new Tabuleiro(8,8);

        tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
        tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(5, 5));

        Tela.imprimirTabuleiro(tab);


    }
}
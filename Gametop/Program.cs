using System;
using Gametop.lib;

namespace Gametop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA
                                (
                                new Jogador1 () 
                                ,new Jogador3 () 
                                
                                );
            jogo.IniciarJogo();
        }
    }

    
    
}

using Game.Lib;
using GameTOP;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador2(),
                new Jogador1("Ronaldo")
            );

            jogo.IniciarJogo();
        }
    }
}

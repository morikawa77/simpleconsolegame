using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuJogo
{
    public class Jogador2
    {

        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public Jogador2(int x, int y)
        {
            //PosicaoX = x;
            //PosicaoY = y;
            //Console.SetCursorPosition(PosicaoX, PosicaoY);
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Write(" ");
            Exibir(x, y);
        }
        public void Exibir(int x, int y)
        {
            PosicaoX = x;
            PosicaoY = y;
            Console.SetCursorPosition(PosicaoX, PosicaoY);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
        }

        public void Apagar(int x, int y, ConsoleColor cor)
        {
            PosicaoX = x;
            PosicaoY = y;
            Console.SetCursorPosition(PosicaoX, PosicaoY);
            Console.BackgroundColor = cor;
            Console.Write(" ");
        }

        internal void Apagar(int posicaoX, int posicaoY)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuJogo
{
    public class Jogador
    {
        //Propriedades
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }

        //Metodos
        //Metodo construtor
        public Jogador(int x, int y)
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
            Console.BackgroundColor = ConsoleColor.White;
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

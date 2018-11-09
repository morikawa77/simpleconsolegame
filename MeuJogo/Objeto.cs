using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuJogo
{
    class Objeto
    {

        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }

        //Metodos
        //Metodo construtor
        public Objeto(int x, int y)
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
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" ");
        }
        
    }

}

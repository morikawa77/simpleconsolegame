using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MeuJogo
{
    class Program
    {
        //Cria jogador
        //O jogador vai ser static para manter o valor de X e Y na memoria conforme a execução do programa
        //get = pega
        //set = guarda
        static Jogador Player1 { get; set; }
        static Jogador2 Player2 { get; set;}

        static Objeto Player3 { get; set; }

        
        
        //Main = Cenario ou tabuleiro (gameplay)

        static void Main(string[] args)
        {
            //Inicializa o Jogo
            Console.Title = "Inferno na Terra";
            Console.BackgroundColor = ConsoleColor.Red;
            //Para atualizar as configurações utiliza -> Console.Clear();
            Console.Clear();

            //Coloca o jogador no jogo
            //Instancia o objeto jogador
            //Player1 = new Jogador(10, 5);
            //Console.ReadKey();
            //Player1.Apagar(10, 5, ConsoleColor.Blue);
            //Console.ReadKey();
            //Player1.Exibir(2, 2)
            //Console.ReadKey();
            
            Player1 = new Jogador(2, 1);
            Player2 = new Jogador2(118,28);
            Player3 = new  Objeto (58,14);
            ConsoleKeyInfo tecla; 
            while ((tecla = Console.ReadKey(true)).Key != ConsoleKey.Spacebar)
            {
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        MovimentarJogador(Player1, 0, -1);
                        break;
                    case ConsoleKey.RightArrow:
                        MovimentarJogador(Player1, 1, 0);
                        break;
                    case ConsoleKey.DownArrow:
                        MovimentarJogador(Player1, 0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        MovimentarJogador(Player1, -1, 0);
                        break;
                    case ConsoleKey.W:
                        MovimentarJogador2(Player2, 0, -1);
                        break;
                    case ConsoleKey.D:
                        MovimentarJogador2(Player2, 1, 0);
                        break;
                    case ConsoleKey.S:
                        MovimentarJogador2(Player2, 0, 1);
                        break;
                    case ConsoleKey.A:
                        MovimentarJogador2(Player2, -1, 0);
                        break;
                        
                }
                bool vencer2 = ColisaoObjeto2(Player2, Player3);
                if (vencer2)
                {


                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n                                                       Jogador 2.Você Venceu!!!                                              \n\n\n\n\n\n\n\n\n\n\n");
                    

                }
                bool vencer = ColisaoObjeto(Player1, Player3);
                if (vencer)
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n                                                       Jogador 1.Você Venceu!!!                                              \n\n\n\n\n\n\n\n\n\n\n");

                }
                bool Colidiu = Colisaojogadorinimigo(Player1, Player2);
                if (Colidiu)
                {
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n                                                        Game Over                                                \n\n\n\n\n\n\n\n\n\n\n");
                    

                }

            }

        }
        
 

        static void MovimentarJogador2(Jogador2 jogador2, int x, int y)
        {
            int posicaoX = jogador2.PosicaoX + x;
            int posicaoy = jogador2.PosicaoY + y;
            bool colisao = ColidirJogadorTela(posicaoX, posicaoy);
            if (colisao == false)
            {
                //Apaga o jogador da tela
                Player2.Apagar(jogador2.PosicaoX, jogador2.PosicaoY, ConsoleColor.Black);
                //inicia  o jogador da nova 
                Player2 = new Jogador2(posicaoX, posicaoy);


            }


        }

        //Metodos do cenario (mecanica do gameplay)
        static void MovimentarJogador(Jogador jogador, int x, int y)
        {
            //Pega a posiçao atual do jogador + a posiçao nova 
            int posicaoX = jogador.PosicaoX + x;
            int posicaoy = jogador.PosicaoY + y;
            bool colisao = ColidirJogadorTela(posicaoX, posicaoy);
            if(colisao == false )
            {
                //Apaga o jogador da tela
                Player1.Apagar(jogador.PosicaoX, jogador.PosicaoY, ConsoleColor.White);
                //inicia  o jogador da nova 
                Player1 = new Jogador(posicaoX, posicaoy);

            }
            //bool colx = ColidirJogadorTela(posicaoX, posicaoy);
            //bool coly = ColidirJogadorTela(posicaoX, posicaoy);
            //if (colx && coly)
            //{
            //    Console.Beep();
            //    Console.BackgroundColor = ConsoleColor.DarkRed;
            //    Console.Clear();
            //    Console.Write("\n\n\n\n\n\n Game Over \n\n\n\n");

            //}



        }

        static bool ColidirJogadorTela(int jogadorPosicaoX, int jogadorPosicaoY)
        {
            int telaPosiçaoX = Console.WindowWidth;
            int telaPosiçaoY = Console.WindowHeight;

            //Verificaçao da colisao da posiçao do jogador com tela 

            if(jogadorPosicaoX >= telaPosiçaoX || jogadorPosicaoX < 0)
            {
                return true;

            }
            if (jogadorPosicaoY >= telaPosiçaoY || jogadorPosicaoY < 0)
            {
                return true;

            }

            return false;

        }
        static bool ColidirJogadorTela2(int jogador2PosicaoX, int jogador2PosicaoY)
        {
            int telaPosiçaoX = Console.WindowWidth;
            int telaPosiçaoY = Console.WindowHeight;

            //Verificaçao da colisao da posiçao do jogador com tela 

            if (jogador2PosicaoX >= telaPosiçaoX || jogador2PosicaoX < 0)
            {
                return true; 

            }
            if (jogador2PosicaoY >= telaPosiçaoY || jogador2PosicaoY < 0)
            {
                return true;

            }

            return false;

        }
        static bool Colisaojogadorinimigo( Jogador jogador1, Jogador2 jogador2)
        {


            if (Player1.PosicaoX == Player2.PosicaoX)
            {
                return true;
            }

            return false;
        }
        static bool ColisaojogadorinimigoY(Jogador jogador1, Jogador2 jogador2)
        { 
            if (Player1.PosicaoY == Player2.PosicaoY)
            {
                return true;
            }
            return false;
        }
        static bool ColisaoObjeto(Jogador jogador1, Objeto jogador3)
        {
            if (Player1.PosicaoX == Player3.PosicaoX)
            {
                return true;
            }
            return false;
        }
        static bool ColisaoObjetoY(Jogador jogador1, Objeto jogador3)
        { 
            if (Player1.PosicaoY == Player3.PosicaoY)
            {
                return true;
            }
            return false;
        }
       static bool ColisaoObjeto2(Jogador2 jogador2, Objeto jogador3)
       {
            if (Player2.PosicaoX == Player3.PosicaoX)
            {
                return true;
            }
            return false;
       }
        static bool ColisaoObjeto2Y(Jogador2 jogador2, Objeto jogador3)
        {
            if (Player2.PosicaoY == Player3.PosicaoY)
            {
                return true;
            }
            return false;
        }


        

        


    }
}

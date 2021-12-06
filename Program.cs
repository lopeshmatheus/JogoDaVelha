using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogo = true;
            string jogador = "X";
            string[,] space = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" }, };
            string vencedor = "Jogador " + jogador + " Venceu a partida! ";
            string vencedor2 = $"Jogador {jogador} Venceu a partida";
            while (jogo)
            {
                




                string jogoDaVelha =
                    @$"
┌──────┬─────┬──────┐
│      │     │      │
│  {space[0, 0]}   │  {space[0, 1]}  │  {space[0, 2]}   │
│      │     │      │
├──────┼─────┼──────┤
│      │     │      │
│  {space[1, 0]}   │  {space[1, 1]}  │  {space[1, 2]}   │
│      │     │      │
├──────┼─────┼──────┤
│      │     │      │
│  {space[2, 0]}   │  {space[2, 1]}  │  {space[2, 2]}   │
│      │     │      │
└──────┴─────┴──────┘";

                string escolha = $"Escolha do jogador {jogador}";


                Console.WriteLine(jogoDaVelha);
                Console.WriteLine(escolha);

                if (jogador == "X")
                {
                    string input = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (input == space[i,j])
                            {
                                space[i, j] = jogador;
                            }
                        }
                    }
                    jogador = "O";
                }
                else
                {
                    string input = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (input == space[i, j])
                            {
                                space[i, j] = jogador;
                            }
                        }
                    }
                    jogador = "X";
                }

                Console.Clear();
                //confere se as linhas sao iguais
                for (int i = 0; i < 3; i++)
                {
                    if (space[i, 0] == space[i, 0 + 1] & space[i, 0] == space[i, 0 + 2])
                    {
                        jogador = space[i, 0];
                        Console.WriteLine(vencedor);
                        jogo = false;
                    }
                }
                // confere se as colunas sao iguais
                for (int j = 0; j < 3; j++)
                {
                    if (space[0, j] == space[0 + 1, j] & space[0, j] == space[0 + 2, j])
                    {
                        jogador = space[0, j];
                        Console.WriteLine(vencedor);
                        jogo = false;
                    }
                }
                // confere se a diagonal principal é igual
                if (space[0, 0] == space[1, 1] & space[0, 0] == space[2, 2])
                {
                    jogador = space[0,0];
                    Console.WriteLine(vencedor2);
                    jogo = false;
                }
                if (space[2, 0] == space[1, 1] & space[2, 0] == space[0, 2])
                {
                    jogador = space[1, 1];
                    Console.WriteLine(vencedor2);
                    jogo = false;
                }





            }



        }
    }
}



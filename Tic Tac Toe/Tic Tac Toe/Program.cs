using System;
using System.Threading;

namespace Tic_Tac_Toe
{
    class Program
    {
        static char[] spaces= new char[] {'1','2','3','4','5','6','7','8','9'};
        static int flag;
        static int choices;
        static int player = 1;

        static void DrawBoard()
        {
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   |   {2}   ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   |   {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   |   {2}   ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("      |      |      ");
        }
        //Win Loss Condition
        static int checkwin()
        {
            if(spaces[0] == spaces[1] &&
               spaces[1] == spaces[2] ||
               spaces[3] == spaces[4] &&
               spaces[4] == spaces[5] ||
               spaces[6] == spaces[7] &&
               spaces[7] == spaces[8] || //rows
               spaces[0] == spaces[3] &&
               spaces[3] == spaces[6] ||
               spaces[1] == spaces[4] &&
               spaces[4] == spaces[7] ||
               spaces[2] == spaces[5] &&
               spaces[5] == spaces[8] || //columns
               spaces[0] == spaces[4] &&
               spaces[4] == spaces[8] ||
               spaces[2] == spaces[4] &&
               spaces[4] == spaces[6])
            {
                return 1;
            }
            else if(spaces[0] != '1' &&
                    spaces[1] != '2' &&
                    spaces[2] != '3' &&
                    spaces[3] != '4' &&
                    spaces[4] != '5' &&
                    spaces[5] != '6' &&
                    spaces[6] != '7' &&
                    spaces[7] != '8' &&
                    spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void Drawx(int pos)
        {
            spaces[pos] = 'X';
        }

        static void Drawo(int pos)
        {
            spaces[pos] = 'O';
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 : X and Player 2 : O" + "\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2's turn");
                }
                else
                {
                    Console.WriteLine("Player 1's turn");
                }

                Console.WriteLine("\n");
                DrawBoard();
                choices = int.Parse(Console.ReadLine()) - 1;

                if (spaces[choices] != 'X' && spaces[choices] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        Drawo(choices);
                    }
                    else
                    {
                        Drawx(choices);
                    }
                    player++;
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1} \n", choices, spaces[choices]);
                    Console.WriteLine("Please wait 2 second board is reloading again....");
                    Thread.Sleep(2000);
                }
                flag = checkwin();

            } while(flag != 1 && flag != -1);

            Console.Clear();
            DrawBoard();
            if(flag == 1)
            {
                Console.WriteLine("Player {0} is won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Game Tie");
            }
            Console.ReadLine();
        }
    }
}

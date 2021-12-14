using System;
using System.Collections.Generic;
using System.Text;

namespace Jensen_Inlämning_1
{
    public class Game
    {
        public string player_1;
        public string player_2;
        public Board board = new Board();
        string[] players = new string[2];
        int currentPlayerIndex = 0;
        public Game()
        {
            //AskForPlayerName();
            //StartGame();
        }

        public void AskForPlayerName()
        {
            players[0] = Helpers.Ask("Name of the player 1 :");
            players[1] = Helpers.Ask("Name of the player 2 :");
        }
        public void StartGame()
        {
            Console.Clear();
            //board.PlacePiece('X', 1, 1);
            //board.PlacePiece('0', 2, 2);
            board.Render();

            char color = currentPlayerIndex == 0 ? 'X' : 'O';
            if (board.checkForWinner(color))
            {
                Console.WriteLine("Congratulation " + players[currentPlayerIndex] + " You won");

                Console.WriteLine("Are you going to play exit if so write Yes or Y");
                
                if(Console.ReadLine()=="Yes"|| Console.ReadLine() == "Y")
                {
                    return;
                }
                //return;
            }
            int position;
            do
            {
                position = Helpers.AskForNumber(
                    "Your turn [" + color + "] " +
                    players[currentPlayerIndex] + " !",
                    1, 9
                   );
            } while (board.PlacePiece(color, position)!=true);

           
            if (board.CheckForTie())
            {
                Console.WriteLine("Game is Draw. Try for the next time");
                Console.WriteLine("Are you going to play exit if so write Yes or Y");

                if (Console.ReadLine() == "Yes" || Console.ReadLine() == "Y")
                {
                    return;
                }
                //return;
            }

            currentPlayerIndex = currentPlayerIndex == 0 ? 1 : 0;

            StartGame();
        }
    }
}

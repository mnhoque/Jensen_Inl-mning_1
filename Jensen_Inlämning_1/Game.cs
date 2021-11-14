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
            AskForPlayerName();
            StartGame();
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

            int position = Helpers.AskForNumber("Your turn " + players[currentPlayerIndex]+" !",1,9);
            Console.ReadLine();
            currentPlayerIndex = currentPlayerIndex == 0 ? 1 : 0;
            StartGame();
        }
    }
}

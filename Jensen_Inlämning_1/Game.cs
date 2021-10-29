using System;
using System.Collections.Generic;
using System.Text;

namespace Jensen_Inlämning_1
{
    public class Game
    {
        public string player_1;
        public string player_2;

        public Game()
        {
            AskForPlayerName();
        }

        public void AskForPlayerName()
        {
            player_1 = Helpers.Ask("Name of the player 1 :");
            player_2 = Helpers.Ask("Name of the player 2 :");
        }
    }
}

using System;

namespace Jensen_Inlämning_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many players you want to play");
            int playernumber = int.Parse(Console.ReadLine());

            while (playernumber > 2)
            {
                Console.WriteLine("You are not allowed more than 2 players");
                Console.WriteLine("How many players you want to play");
                playernumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("How many games you want to play");
            int NumberOfGames = int.Parse(Console.ReadLine());
            Game game = new Game();
            
            game.AskForPlayerName();
           
            //game.StartGame();




            int Gamecount = 0;
            while (Gamecount <= NumberOfGames)
            {
                game.StartGame();
                Gamecount++;
                Console.WriteLine(Gamecount + " is done");
                if (Gamecount < NumberOfGames)
                {
                    Console.WriteLine("Next round is started");
                }
                else
                {
                    break;
                }
                

            }



        }
    }
}

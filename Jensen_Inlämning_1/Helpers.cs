using System;
using System.Collections.Generic;
using System.Text;

namespace Jensen_Inlämning_1
{
    public class Helpers
    {
        public static string Ask(string question)
        {
            string answer = "";
            while (answer == "")
            {
                //Console.WriteLine();
                Console.WriteLine("\n"+question);
                answer = Console.ReadLine();
            }
            return answer;
        }
        public static int AskForNumber(string question,int min,int max)
        {
            int answer = min - 1;
            while(answer < min || answer > max)
            {
                Console.WriteLine("\n"+question);
                bool okParse = int.TryParse(Console.ReadLine(), out answer);

                if (!okParse)
                {
                    answer = min - 1;
                }
            }

            return answer;
        }
    }
}

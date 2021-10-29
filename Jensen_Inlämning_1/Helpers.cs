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
    }
}

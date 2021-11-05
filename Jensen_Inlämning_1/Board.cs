using System;
using System.Collections.Generic;
using System.Text;

namespace Jensen_Inlämning_1
{
    public class Board
    {
        char[,] matrix = {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        

        public void PlacePiece(char color,int row, int column)
        {
            matrix[row, column] = color;
        }

        public void Render()
        {
            Console.WriteLine("----------------");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("| "+matrix[row,column]+" ");
                }
                //Console.WriteLine("|\n----------------");
                Console.WriteLine("|");
                
                Console.WriteLine("----------------");
            }
            
        }
    }
}

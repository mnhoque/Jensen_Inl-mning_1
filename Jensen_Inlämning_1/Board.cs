using System;
using System.Collections.Generic;
using System.Text;

namespace Jensen_Inlämning_1
{
    public class Board
    {
        char[,] matrix = {
            {' ',' ',' ' },
            {' ',' ',' ' },
            {' ',' ',' ' }
        };
        

        public bool PlacePiece(char color,int position)
        {
            position--;
            int row = position / 3;
            int column = position % 3;
            
            if(matrix[row,column] =='X' || matrix[row, column] == 'O')
            {
                return false;
            }
            matrix[row, column] = color;
            return true;
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

        public bool checkForWinner(char color)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (row==0 && matrix[row,column]==color &&
                        matrix[row+1,column]==color && matrix[row + 2, column] == color)
                    {
                        return true;
                    }
                    if (column == 0 && matrix[row, column] == color &&
                        matrix[row, column+1] == color && matrix[row, column+2] == color)
                    {
                        return true;
                    }
                    if (row ==0 && column == 0 && matrix[row, column] == color &&
                        matrix[row+1, column + 1] == color && matrix[row+2, column + 2] == color)
                    {
                        return true;
                    }
                    //if (matrix[row, column+2] == color &&
                    //    matrix[row + 1, column + 1] == color && matrix[row + 2, column] == color)
                    //{
                    //    return true;
                    //}
                    if (row == 0 && column == 2 && matrix[row, column] == color &&
                        matrix[row + 1, column - 1] == color && matrix[row + 2, column - 2] == color)
                    {
                        return true;
                    }
                }
                
            }
            
            return false;
        }

        public bool CheckBoardIsFull()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if(matrix[row,column]!='X' && matrix[row, column] != 'O')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
         public bool CheckForTie()
        {
            if((CheckBoardIsFull()==true) && 
                (checkForWinner('X')==false) &&
                (checkForWinner('O') == false)){
                return true;
            }
            return false;
        }
    }
}

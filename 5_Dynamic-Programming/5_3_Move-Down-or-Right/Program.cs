using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_3_Move_Down_or_Right
{
    class Program
    {
        //Given a matrix of N by M cells filled with positive integers. 
        //find the path from top left to bottom right with a highest sum of cells by moving only down or right.
        //EXAMPLE INPUT:
        // 4 # number of cols
        // 4 # number of rows
        // 1 3 2 1
        // 5 3 2 1
        // 1 7 3 1
        // 1 3 1 1
        static void Main()
        {
            int cols = Convert.ToInt32(Console.ReadLine());
            int rows = Convert.ToInt32(Console.ReadLine());
            List<int[]> matrix = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                matrix.Add(row);
            }

            Stack<int[]> result = new Stack<int[]>();
            int[] currentCell = new[] { rows - 1, cols - 1 };
            //adding the right-down most cell
            result.Push(currentCell);
            bool allowLeft = true;
            bool allowTop = true;

            while (true)
            {
                if (currentCell[0] == 0 && currentCell[1] > 0)
                {
                    allowTop = false;
                }
                else if (currentCell[0] > 0 && currentCell[1] == 0)
                {
                    allowLeft = false;
                }
                else if (currentCell[0] == 0 && currentCell[1] == 0)
                {
                    break;
                }
                int[] currentLeftCell = null;
                int[] currentTopCell = null;
       
                if (allowLeft && allowTop)
                {
                    currentLeftCell = new[] { currentCell[0], currentCell[1] - 1 };
                    currentTopCell = new[] { currentCell[0] - 1, currentCell[1] };
                    //if the left cell is bigger or equal then the current
                    if (matrix[currentCell[0]][currentCell[1] - 1] >= matrix[currentCell[0] - 1][currentCell[1]])
                    {
                        currentCell = currentLeftCell;
                    }
                    else
                    {
                        currentCell = currentTopCell;
                    }
                }
                else if(allowTop && !allowLeft)
                {
                    currentTopCell = new[] { currentCell[0] - 1, currentCell[1] };
                    currentCell = currentTopCell;
                }
                else if(allowLeft && !allowTop)
                {
                    currentLeftCell = new[] { currentCell[0], currentCell[1] - 1 };
                    currentCell = currentLeftCell;
                }
                result.Push(currentCell);
            }
            while (result.Any())
            {
                Console.WriteLine(string.Join(",",result.Pop()));
            }
        }
    }
}

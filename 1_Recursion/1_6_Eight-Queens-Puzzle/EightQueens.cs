using System;
using System.Collections.Generic;

public class EightQueens
{
    private const int Size = 8;
    static int solutionsFound = 0;
    //creating two dimensional 8x8 boolean array 
    static bool[,] chessboard = new bool[Size, Size];

    static new HashSet<int> attackedRows = new HashSet<int>();
    static new HashSet<int> attackedColumns = new HashSet<int>();
    static new HashSet<int> attackedLeftDiagonals = new HashSet<int>();
    static new HashSet<int> attackedRightDiagonals = new HashSet<int>();

    //The Columns are 8, numbered from 0 to 7.
    //The left diagonals are 15, numbered from -7 to 7. Formula to calculate the left diagonal number by row and column: leftDiag = col - row.
    //The right diagonals are 15, numbered from 0 to 14 by the formula: rightDiag = col + row.

    public static void PutQueens(int row)
    {
        if (row == 8)
        {
            Console.WriteLine(solutionsFound + 1);
            PrintSolution();
        }
        else
        {
            for (int col = 0; col < Size; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkAllAttackedPositions(row, col);
                    PutQueens(row + 1);
                    UnmarkAllAttackedPositions(row, col);
                }
            }
        }
    }

    static bool CanPlaceQueen(int row, int col)
    {
        var positionsOccupied = attackedRows.Contains(row) ||
                                attackedColumns.Contains(col) ||
                                attackedLeftDiagonals.Contains(col - row) ||
                                attackedRightDiagonals.Contains(row + col);

        return !positionsOccupied;
    }

    static void MarkAllAttackedPositions(int row, int col)
    {
        attackedRows.Add(row);
        attackedColumns.Add(col);
        attackedLeftDiagonals.Add(col - row);
        attackedRightDiagonals.Add(row + col);
        chessboard[row, col] = true;
    }

    static void UnmarkAllAttackedPositions(int row, int col)
    {
        attackedRows.Remove(row);
        attackedColumns.Remove(col);
        attackedLeftDiagonals.Remove(col - row);
        attackedRightDiagonals.Remove(row + col);
        chessboard[row, col] = false;
    }

    static void PrintSolution()
    {
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                char mark = chessboard[row, col] ? '*' : '-';
                Console.Write(mark);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        solutionsFound++;
        
    }
}

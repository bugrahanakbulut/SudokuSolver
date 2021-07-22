using System;
using System.Text;

namespace SudokuSolver
{
    public class SudokuSolver
    {
        private int[][] _puzzle;

        private int _size => _puzzle.Length;
        
        public SudokuSolver(int[][] puzzle)
        {
            _puzzle = puzzle;

            SolvePuzzle(0, 0);

            PrintPuzzle();
        }

        private bool SolvePuzzle(int row, int col)
        {
            if (row >= _size || col >= _size)
            {
                return true;
            }

            if (_puzzle[row][col] != 0)
            {
                int[] nextPos = GetNextPos(row, col);
                
                return SolvePuzzle(nextPos[0], nextPos[1]);
            }

            for (int i = 1; i < 10; i++)
            {
                if (CanPlace(i, row, col))
                {
                    _puzzle[row][col] = i;

                    int[] nextPos = GetNextPos(row, col);

                    if (SolvePuzzle(nextPos[0], nextPos[1]))
                    {
                        return true;
                    }

                    _puzzle[row][col] = 0;
                }
            }

            return false;
        }

        private int[] GetNextPos(int row, int col)
        {
            int[] newPos;

            newPos = (col == 8) ? new[] {row + 1, 0} : new[] {row, col + 1};

            return newPos;
        }
        
        private bool CanPlace(int val, int row, int col)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_puzzle[row][i] == val || _puzzle[i][col] == val)
                {
                    return false;
                }
            }

            int sRow = (row / 3) * 3; 
            int sCol = (col / 3) * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_puzzle[sRow + i][sCol + j] == val)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void PrintPuzzle()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    stringBuilder.Append(_puzzle[i][j] + " ");
                }

                stringBuilder.Append("\n");
            }
            
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
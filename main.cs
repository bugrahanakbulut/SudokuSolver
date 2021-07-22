namespace SudokuSolver
{
    internal class main
    {
        public static void Main(string[] args)
        {

            int[][] puzzle = new[]
            {
                new [] { 0, 6, 0, 1, 0, 4, 0, 5, 0},
                new [] { 0, 0, 8, 3, 0, 5, 6, 0, 0},
                new [] { 2, 0, 0, 0, 0, 0, 0, 0, 1},
                new [] { 8, 0, 0, 4, 0, 7, 0, 0, 6},
                new [] { 0, 0, 6, 0, 0, 0, 3, 0, 0},
                new [] { 7, 0, 0, 9, 0, 1, 0, 0, 4},
                new [] { 5, 0, 0, 0, 0, 0, 0, 0, 2},
                new [] { 0, 0, 7, 2, 0, 6, 9, 0, 0},
                new [] { 0, 4, 0, 5, 0, 8, 0, 7, 0}
            };

            // solution works for only 9x9 by puzzles
            
            SudokuSolver solver = new SudokuSolver(puzzle);
        }
    }
}
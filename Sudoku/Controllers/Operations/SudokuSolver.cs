public class SudokuSolver
{

    public SudokuStruct Solve(SudokuStruct sudo)
    {
        bool inserted = false;
        while (!sudo.IsSolved())
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (sudo.sudoku[i][j] == 0)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            inserted = sudo.TryInsert(x, i, j);
                        }
                    }
                }
            }
            if(!inserted){
                break;
            }
            inserted = false;
        }
        return sudo;
    }
}
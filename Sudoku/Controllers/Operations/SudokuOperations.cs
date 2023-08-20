public static class SudokuOperations
{
    public static bool IsSolved(this SudokuStruct sudo)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudo.sudoku[i][j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool TryInsert(this SudokuStruct sudo, int number, int x, int y)
    {
        HashSet<int> alreadyExisting = new HashSet<int>();
        for (int i = 0; i < 9; i++)
        {
            if (sudo.sudoku[x][i] == number)
            {
                return false;
            }
            else if (sudo.sudoku[x][i] != 0)
            {
                alreadyExisting.Add(sudo.sudoku[x][i]);
            }
            if (sudo.sudoku[i][y] == number)
            {
                return false;
            }
            else if (sudo.sudoku[i][y] != 0)
            {
                alreadyExisting.Add(sudo.sudoku[i][y]);
            }
        }

        int start = x < 3 ? 0 : x < 6 ? 3 : 6;
        int end = y < 3 ? 0 : y < 6 ? 3 : 6;
        for (int i = start; i < start + 3; i++)
        {
            for (int j = end; j < end + 3; j++)
            {
                if (sudo.sudoku[i][j] == number)
                {
                    return false;
                }
                else if (sudo.sudoku[i][j] != 0)
                {
                    alreadyExisting.Add(sudo.sudoku[i][j]);
                }
            }
        }

        if(alreadyExisting.Count == 8){
            sudo.sudoku[x][y] = number;
            return true;
        }

        return false;
    }
}
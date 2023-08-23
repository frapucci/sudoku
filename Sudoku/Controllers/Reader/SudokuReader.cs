public class SudokuReader : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ResultStatusWrapper Read(string s)
    {
        string[] stringInLine = s.Split('\n');
        if (stringInLine.Length != 9)
        {
            Console.WriteLine("Sudoku not correct");
            return new ResultStatusWrapper("KO", "Length not right");
        }

        int[][] sudo = new int[9][];
        for (int i = 0; i < 10; i++)
        {
            string[] row = stringInLine[i].Split(" ");
            for (int j = 0; j < 10; j++)
            {
                if (!Int32.TryParse(row[j], out sudo[i][j]))
                {
                    Console.WriteLine("Input not correct");
                    return new ResultStatusWrapper("KO", "Input not correct");
                }
            }
        }

        SudokuStruct.Instance.sudoku = sudo;
        return new ResultStatusWrapper("OK");
    }

}

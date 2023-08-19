public sealed class SudokuStruct{
    public int[,] sudoku;
    
    #region Singleton
    private static SudokuStruct instance = null;
    public static SudokuStruct Instance {
        get {
            if (instance == null) {
                instance = new SudokuStruct();
            }
            return instance;
        }
    }
    #endregion

    private SudokuStruct() {
        sudoku = new int[9,9];
    }



}
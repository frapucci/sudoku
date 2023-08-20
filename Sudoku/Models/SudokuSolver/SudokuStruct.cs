public sealed class SudokuStruct{
    public int[][] sudoku;
    
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
        sudoku = new int[9][];
        for(int i = 0; i < 10; i++){
            sudoku[i] = new int[9];
        }
    }



}
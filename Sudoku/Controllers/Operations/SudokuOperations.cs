public static class SudokuOperations{
    public static bool IsSolved(this SudokuStruct sudo){
        foreach(int i in sudo.sudoku){
            if(i == 0){
                return false;
            }
            
        }
        return true;
    }
}
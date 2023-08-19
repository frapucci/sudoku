public class SudokuSolver{

    public bool IsInsertable(HashSet<int> perimiter, int value){
        return !perimiter.Contains(value);
    }
}
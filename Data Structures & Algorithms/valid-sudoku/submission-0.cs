
public class Solution {
    public bool IsValidSudoku(char[][] board) {

        foreach (var row in board)
        {
            HashSet<int> bag = new HashSet<int>();  
            foreach (var i in row)
            {
                if (bag.Contains(i)) return false;
                if (i == '.') continue;
                bag.Add(i);
            }
        }

        for (int i = 0; i < 9; i++)
        {
            HashSet<int> bag = new HashSet<int>();  
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine($"{i}, {j}, {board[i][j]}");
                if (bag.Contains(board[j][i])) return false;
                if (board[j][i] == '.') continue;
                bag.Add(board[j][i]);
            }
        }
        
        for (int square = 0; square < 9; square++) {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.Contains(board[row][col])) return false;
                    seen.Add(board[row][col]);
                }
            }
        }
        
        
        return true;
    }
    
}

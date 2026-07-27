public class Solution {
public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            HashSet<int> bag1 = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                if (bag1.Contains(board[i][j])) return false;
                if (board[i][j] != '.') bag1.Add(board[i][j]);
            }
        }
        
        for (int i = 0; i < 9; i++)
        {
            HashSet<int> bag2 = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                if (bag2.Contains(board[j][i])) return false;
                if (board[j][i] != '.') bag2.Add(board[j][i]);
            }
        }

        for (int square = 0; square < 9; square++)
        {
            HashSet<char> bag3 = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    
                    if (bag3.Contains(board[row][col])) return false;
                    if (board[row][col] != '.') bag3.Add(board[row][col]);
                    //  if (board[row][col] == '.') continue;
                    // if (bag3.Contains(board[row][col])) return false;
                    // bag3.Add(board[row][col]);
                }

            }
        }
        return true;
        }
        
    }
    



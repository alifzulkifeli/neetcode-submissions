class Solution {
    public boolean isValidSudoku(char[][] board) {
         for (int i = 0; i < board.length; i++) {
            HashSet<Character> bag = new HashSet<>();
            for (int j = 0; j < board.length; j++) {
                if (bag.contains(board[i][j]))return false;
                if(board[i][j] != '.') bag.add(board[i][j]);
            }
        }

        for (int i = 0; i < board.length; i++) {
            HashSet<Character> bag = new HashSet<>();
            for (int j = 0; j < board.length; j++) {
                if (bag.contains(board[j][i]))return false;
                if(board[j][i] != '.') bag.add(board[j][i]);
            }
        }

        for (int square = 0; square < 9; square++) {
            Set<Character> seen = new HashSet<>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.contains(board[row][col])) return false;
                    seen.add(board[row][col]);
                }
            }
        }
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9
        // 1 2 3 4 5 6 7 8 9

        return true;
    }
}

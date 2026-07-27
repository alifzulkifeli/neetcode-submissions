class Solution {
public static boolean isValidSudoku(char[][] board) {
        HashMap<Integer, HashSet<Character>> row = new HashMap<>();
        HashMap<Integer, HashSet<Character>> col = new HashMap<>();
        HashMap<String, HashSet<Character>> square = new HashMap<>();

       for (int i = 0; i < 9; i++){
           for (int k = 0; k < 9; k++){
                if (board[i][k] == '.') continue;
                String square_key = (i/3) + "," + (k/3);

                if (row.computeIfAbsent(i,key -> new HashSet<>()).contains(board[i][k]) ||
                        col.computeIfAbsent(k,key -> new HashSet<>()).contains(board[i][k]) ||
                        square.computeIfAbsent(square_key,key -> new HashSet<>()).contains(board[i][k])
                ){
                    return false;
               }

               row.get(i).add(board[i][k]);
               col.get(k).add(board[i][k]);
               square.get(square_key).add(board[i][k]);
           }
       }
       return true;
    }
}

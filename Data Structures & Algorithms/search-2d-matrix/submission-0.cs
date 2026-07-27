public class Solution {
 public bool SearchMatrix(int[][] matrix, int target) {
        foreach (var mat in matrix)
        {
            if (target >= mat[0] && target <= mat[^1])
            {
                int L = 0;
                int R =  mat.Length -1;

                while (L <= R)
                {
                    int mid = (L + R) / 2;

                    if (target > mat[mid])
                    {
                        L = mid + 1;
                    }
                    else if( target < mat[mid])
                    {
                        R = mid - 1;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

        }
        return false;
    }
}

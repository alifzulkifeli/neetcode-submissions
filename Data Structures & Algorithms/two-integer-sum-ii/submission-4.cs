public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int L =0;
        int R= numbers.Length-1;

        while (L < R)
        {
            if(numbers[L] +  numbers[R] == target) return new int[]{ L +1  , R + 1 };
            else if (numbers[L] + numbers[R] > target) R--;
            else L++;
        }
        return new int[2];
    }
}
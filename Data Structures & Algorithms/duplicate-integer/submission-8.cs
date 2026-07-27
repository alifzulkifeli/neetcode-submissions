public class Solution {
 public bool hasDuplicate(int[] nums)
 {
    if (nums.Length < 2) return false;
     nums = nums.Order().ToArray();

     Console.WriteLine(string.Join(" ", nums));

     int prev = nums[0];
     for (int i = 1; i < nums.Length; i++)
     {
         if (nums[i] == prev)
         {
             return true;
         }
         prev = nums[i];
     }

     return false;
 }
}

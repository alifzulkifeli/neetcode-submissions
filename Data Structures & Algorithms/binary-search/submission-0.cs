
public class Solution {
    public int Search(int[] nums, int target) {
     int L = 0;
     int R = nums.Length - 1;

     while (L <= R)
     {
         int mid = (L + R) / 2;

         if (target < nums[mid])
         {
             R = mid - 1;
         }
         else if( target > nums[mid])
         {
             L = mid + 1;
         }
         else
         {
             return mid;
         }
     }

     return -1;
    }
}

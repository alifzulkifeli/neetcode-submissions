public class Solution {
    public int[] TwoSum(int[] nums, int target)
   {
       HashSet<int> msh = new HashSet<int>();
       int[] ans = new int[2];

       for (int i = 0; i < nums.Length; i++)
       {
           if (msh.Contains(target - nums[i]))
           {
               Console.WriteLine(target- nums[i]);
               ans[1] = i;
               ans[0] = Array.IndexOf(nums, target - nums[i]);
           }
           msh.Add(nums[i]);
       }

       return ans;
   }
}

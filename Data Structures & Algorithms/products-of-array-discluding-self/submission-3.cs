public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] a = new int[nums.Length];
        int[] b = new int[nums.Length];
        int[] ans = new int[nums.Length];
        
        a[0] = nums[0];
        b[nums.Length-1] = nums[nums.Length-1];

        for (int i = 1; i < nums.Length; i++)
        {
            a[i] = nums[i] *  a[i - 1];
            b[nums.Length-1-i] = nums[nums.Length-i-1] *  b[nums.Length-i];
        }

        ans[0] = b[1];
        ans[ans.Length-1] = a[ans.Length-2];

        for (int i = 1; i < ans.Length-1; i++)
        {
            ans[i] = a[i-1] *  b[i+1];
        }
        
        return ans;
    }
}

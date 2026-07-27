public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] arr1 = new int[nums.Length];
        int[] arr2 = new int[nums.Length];
        int[] ans = new int[nums.Length];
        
        arr1[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            arr1[i] = nums[i] * arr1[i - 1];
        }

        arr2[^1] = nums[^1];
        for (int j = arr2.Length -2; j >= 0; j--)
        {
            arr2[j] = nums[j] * arr2[j + 1];
            Console.WriteLine(j);
        }

        ans[0] = arr2[1];
        ans[^1] = arr1[^2];
        
        for (int k = 1; k <= nums.Length - 2; k++)
        {
            ans[k] = arr1[k - 1] * arr2[k+1];
        }


        Console.WriteLine(string.Join(" ", arr1));
        Console.WriteLine(string.Join(" ", arr2));
        Console.WriteLine(string.Join(" ", ans));
        
        return ans;
    }
}
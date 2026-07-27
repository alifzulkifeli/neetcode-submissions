public class Solution {
 public int[] TwoSum(int[] nums, int target) {
        // target - n -> to bag
        Dictionary<int, int> bag = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int cur = target - nums[i];
            if (bag.TryGetValue(nums[i], out var value))
            {
                return new[] { value, i };
            }
            else
            {
                bag.Add(cur, i);
            }
        }

        return new int[2];
    }   
}

public class Solution {
       public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> bag  = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (bag.ContainsKey(target - nums[i])) return new int[] {  bag[target - nums[i]] ,i};
            else
            {
                bag.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}

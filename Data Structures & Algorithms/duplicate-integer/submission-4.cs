public class Solution {
    public bool hasDuplicate(int[] nums) {


    if (nums.Length == 2 && nums[0] == nums[1]) return true;


    Array.Sort(nums);
    for (int i = 1; i < nums.Length -1; i++)
    {
        if(nums[i] == nums[i-1] || nums[i] == nums[i+1])return true;
    }
        return false;

    }
}

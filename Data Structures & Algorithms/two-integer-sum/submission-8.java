class Solution {
    public static int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> keeper = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            if (keeper.containsKey(target - nums[i])) return new int[]{keeper.get(target - nums[i]),i};
            keeper.put(nums[i], i);
        }

        return new int[]{};
    }
}

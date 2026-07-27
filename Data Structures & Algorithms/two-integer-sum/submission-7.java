class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> bag = new HashMap<>();

        bag.put(nums[0],0);

        for (int i = 1 ; i < nums.length; i++){
            if (bag.containsKey(target - nums[i])){
                return new int[]{bag.get(target-nums[i]), i};
            } else {
                bag.put(nums[i], i);
            }
        }

        return new int[]{};
    }
}

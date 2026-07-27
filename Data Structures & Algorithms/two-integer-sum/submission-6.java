class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> viewed = new HashMap<>();

        for (int i = 0; i < nums.length; i++){
            //get curent value and wanted value
            int current = nums[i];
            int wanted = target - current;

            //check if wanted value exist in viewed
            if (viewed.containsKey(wanted)){
                return new int[]{viewed.get(wanted), i};
            }
            viewed.put(current, i);
        }
        return new int[]{};
    }
}

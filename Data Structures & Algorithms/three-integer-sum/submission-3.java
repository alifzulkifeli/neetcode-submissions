class Solution {
    public static List<List<Integer>> threeSum(int[] nums) {

        Arrays.sort(nums);
        ArrayList<List<Integer>> res = new ArrayList<>();

        for (int i = 0; i < nums.length-1; i++) {
            // if (nums[i] == nums[i+1]) continue;

            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int l = i+1;
            int r = nums.length-1;

            while(l<r){
                if (nums[i] + nums[l] + nums[r] == 0) {
                    res.add(List.of(nums[i],nums[l],nums[r]));
                    l++;
                    r--;   

                        while (l < r && nums[l] == nums[l-1]) {
                            l++;
                        }

                        while (l < r && nums[r] == nums[r+1]) {
                            r--;
                        }
                }
                
                else if (nums[i] + nums[l] + nums[r] < 0 ) {
                    l++;
                }
                else if (nums[i] + nums[l] + nums[r] > 0 ) {
                    r--;
                }
            }
        }
        return res;
    }
}

class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
           List<List<Integer>> ans = new ArrayList<>();
        int[] newNums = Arrays.stream(nums).sorted().toArray();
        int processed = 99999;

        for (int i = 0; i < newNums.length; i++) {
            if (processed == newNums[i])continue;
            processed = newNums[i];

            int left = i +1 ;
            int right = newNums.length -1;
            while (left < right){
                if ((newNums[left] + newNums[right]) > -processed){
                    right--;
                } else if ((newNums[left] + newNums[right]) < -processed) {
                    left++;
                } else {
                    ans.add(new ArrayList<>(Arrays.asList(processed, newNums[left], newNums[right])));
                    left++;
                    right--;
                    while (left < right && newNums[left] == newNums[left-1]){
                        left++;
                    }
                }
            }
        }

        return ans;
    }
}

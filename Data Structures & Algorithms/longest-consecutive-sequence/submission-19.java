class Solution {
    public int longestConsecutive(int[] nums) {
        Set<Integer> set = Arrays.stream(nums).boxed().collect(Collectors.toSet());
        int res = 0;

        for (int n: nums){
            if (!set.contains(n-1)){
                int length = 0;
                while(set.contains(n + length)){
                    length++;
                }
                res = Math.max(length, res);
            }
        }

        return res;
    }
}

class Solution {
public static int longestConsecutive(int[] nums) {
        HashSet<Integer> bag = new HashSet<>();

        for (int n : nums) {
            bag.add(n);
        }

        int max = 0;
        for (Integer head : bag) {
            if (bag.contains(head-1)) {
                continue;
            }
            int longest = 0;
            while (bag.contains(head+longest)) {
                longest++;
            }
            max = Math.max(longest, max);
        }
        return max;
    }
}

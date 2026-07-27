class Solution {
public static int longestConsecutive(int[] nums) {
        HashSet<Integer> bag = new HashSet<>();
        // ArrayList<Integer> header = new ArrayList<>();

        for (Integer n : nums) {
            bag.add(n);
        }

        // for (Integer n : nums) {
        //     if (!bag.contains(n-1)) header.add(n);
        // }


        int max = 0;
        for (Integer head : bag) {

            if (bag.contains(head-1)) {
                continue;
            }
            int longest = 0;
            while (bag.contains(head+longest)) {
                System.out.println(head+longest);
                longest++;
            }
            max = Math.max(longest, max);
        }


        return max;
    }
}

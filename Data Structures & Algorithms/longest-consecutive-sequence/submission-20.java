class Solution {
public static int longestConsecutive(int[] nums) {
        HashSet<Integer> bag = new HashSet<>();
        ArrayList<Integer> header = new ArrayList<>();

        for (Integer n : nums) {
            bag.add(n);
        }

        for (Integer n : nums) {
            if (!bag.contains(n-1)) header.add(n);
        }


        int max = 0;
        for (Integer head : header) {

            int i = 0;
            int longest = 0;
            while (bag.contains(head+i)) {
                System.out.println(head+i);
                longest++;
                i++;
                max = Math.max(longest, max);
            }
        }


        return max;
    }
}

class Solution {
   public static int[] topKFrequent(int[] nums, int k) {

        HashMap<Integer, Integer> freq = new HashMap<>();
        ArrayList<Integer>[] middle = new ArrayList[nums.length + 1];

        for (int i : nums) {
            freq.put(i, freq.getOrDefault(i,0)+1);
        }

        for (Integer freqKey : freq.keySet()) {
            if (middle[freq.get(freqKey)] == null) {
                middle[freq.get(freqKey)] = new ArrayList<>();
            }
            middle[freq.get(freqKey)].add(freqKey);
        }

        int[] ans = new int[k];
        for (int i = middle.length-1; i > 0; i--) {
            if (middle[i] == null || k < 1 ) continue;
            for (int mid : middle[i]) {
                ans[k-1] = mid;
                k--;
            }
            System.out.println(i);
        }



        return ans;
    }
}

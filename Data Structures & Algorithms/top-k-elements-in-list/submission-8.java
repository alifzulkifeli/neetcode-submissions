class Solution {
   public static int[] topKFrequent(int[] nums, int k) {
        HashMap<Integer, Integer> holder = new HashMap<>();
        ArrayList<Integer>[] ans = new ArrayList[nums.length+1];

        for (Integer num : nums) {
            holder.put(num, holder.getOrDefault(num, 0)+1);
        }

        for (int i : holder.keySet()) {
            // key = number, value = freq
            int freq = holder.get(i);

            if (ans[freq] == null) {
                ans[freq] = new ArrayList<>();
            }
            ans[freq].add(i);
        }

        int[] res = new int[k]; 
        int index = 0;
        for (int i = ans.length-1; i >= 0; i--) {
            if (ans[i] == null) {
                continue;
            }

            for (int x : ans[i]) {
                if (index < k ) {
                    System.out.println(x);
                    res[index] = x;
                    index++;
                }

            }
            System.out.println(ans[i]);
        }

        return res;
    }
}

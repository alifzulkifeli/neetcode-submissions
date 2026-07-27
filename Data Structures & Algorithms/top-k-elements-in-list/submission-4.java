class Solution {
    public int[] topKFrequent(int[] nums, int k) {
         //1. Create count Hashmap to get number of count for each digit
        HashMap<Integer, Integer> count = new HashMap<>();
        for (int n: nums){
            count.putIfAbsent(n, 0);
            count.put(n ,count.get(n) + 1);
        }

        //2. use entrySet to convert to Arraylist 2D and add value
        ArrayList<List<Integer>> res = new ArrayList<>();
        count.forEach((key,value) -> {
            List<Integer> pair = new ArrayList<>();
            pair.add(key);
            pair.add(value);
            res.add(pair);
        });

        //3. Sort
        res.sort((a,b) -> b.get(1).compareTo(a.get(1)));
        System.out.println(res);


        //4. return value based on k
        int[] ans = new int[k];
        for (int i = 0; i < k; i++) {
            ans[i] = res.get(i).get(0);
        }
        return ans;
    }
}

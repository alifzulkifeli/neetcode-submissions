class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
      HashMap<String, List<String>> bag = new HashMap<>();


        for (String str : strs){
            int[] holderStr = new int[26];
             for (char s: str.toCharArray()){
                 holderStr[s-'a']++;
             }
             String key = Arrays.stream(holderStr).mapToObj(String::valueOf).collect(Collectors.joining(","));
             if (bag.containsKey(key)){
                 List<String> or = bag.get(key);
                 or.add(str);
                 bag.put(key, or);
             } else {
                 bag.put(key, new ArrayList<>(Arrays.asList(str)));
             }
        }

        System.out.println(bag);

        List<List<String>> ans = new ArrayList<>();

        for (List<String> b: bag.values()){
            ans.add(b);
        }
        return ans;
    }
}

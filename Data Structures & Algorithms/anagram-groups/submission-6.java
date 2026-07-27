class Solution {
public static List<List<String>> groupAnagrams(String[] strs) {
        
        HashMap<String, List<String>> ans = new HashMap<>();
        
        for (String str : strs) {
            int[] zeroOne = new int[26];
            for (char c : str.toCharArray()) {
                zeroOne[c - 'a']++;
            }

            StringBuilder builer = new StringBuilder();

            for (int zer : zeroOne) {
                builer.append(zer + "#");
            }

            String builded = builer.toString();
            System.out.println(builded);


            ans.computeIfAbsent(builded, k -> new ArrayList<>()).add(str);
        }
        return new ArrayList<>(ans.values());
    }
}

class Solution {
    public static List<List<String>> groupAnagrams(String[] strs) {
			HashMap<String, ArrayList<String>> holder = new HashMap<>();
			for (String str : strs) {
				int[] builder = new int[26];
				for (char c : str.toCharArray()) {
					builder[c - 'a']++;
				}
				String created = Arrays.toString(builder);
				holder.computeIfAbsent(created, k -> new ArrayList<>()).add(str);
			}
			return new ArrayList<>(holder.values());
    }
}

class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) return false;
        
        List<Character> list1 = s.chars().mapToObj(c -> (char) c).sorted().toList();
        List<Character> list2 = t.chars().mapToObj(c -> (char) c).sorted().toList();
        for (int i = 0; i < list1.size(); i++) {
            if (list1.get(i) != list2.get(i)) return false;
        }
        return true;
    }
}

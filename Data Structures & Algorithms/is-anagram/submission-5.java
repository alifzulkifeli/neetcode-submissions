class Solution {
    public boolean isAnagram(String s, String t) {

        if (s.length() != t.length()) return false;
        
        int[] box = new int[26];
        for (int i = 0; i < s.length(); i++){
            box[s.charAt(i) - 'a']++;
            box[t.charAt(i) - 'a']--;
        }

        for (int v:box){
            if (v >0) return false;
        }
        return true;
    }
}

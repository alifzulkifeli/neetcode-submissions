class Solution {
    public static boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) return  false;
        int[] holder = new int[26];

        char[] s_array = s.toCharArray();
        char[] t_array = t.toCharArray();

        for(int i = 0; i < s.length(); i++){
            holder[s_array[i] - 'a']++;
            holder[t_array[i] - 'a']--;
        }

        for(int h: holder){
            if (h !=0) return false;
        }
        return true;
    }
}

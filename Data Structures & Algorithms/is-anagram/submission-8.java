class Solution {
    public boolean isAnagram(String s, String t) {
        int[] holder = new int[26];

        for (char s_: s.toCharArray()){
            int diff = Character.getNumericValue(s_) - Character.getNumericValue('a');
            holder[diff]++;
        }

        for (char t_ : t.toCharArray()){
            int diff = Character.getNumericValue(t_) - Character.getNumericValue('a');
            holder[diff]--;
        }

        for (int h : holder){
            if (h != 0) return false;
        }

        return  true;
    }
}

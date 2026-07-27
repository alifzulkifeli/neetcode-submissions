public class Solution {
    public bool IsAnagram(string s, string t) {
                 if (s.Length != t.Length) return false;

         int[] holder = new int[26];
         for (int i = 0; i < s.Length; i++)
         {
             holder[s[i] - 'a']++;
             holder[t[i] - 'a']--;
         }

         foreach(int h in holder)
         {
             if (h > 0) return false;
         }
         return true;
    }
}

public class Solution {
 public List<List<string>> GroupAnagrams(string[] strs)
 {

     List<List<string>> ans = new List<List<string>>();
     HashSet<string> set = new HashSet<string>();
     List<string> pos = new List<string>();

     for (int i = 0; i < strs.Length; i++)
     {
         char[] myChar = strs[i].ToCharArray();
         Array.Sort(myChar);
         string currentString = string.Join("", myChar);

         if (set.Contains(currentString))
         {
             ans[pos.IndexOf(currentString)].Add(strs[i]);
         } else
         {
             set.Add(currentString);
             pos.Add(currentString);
             ans.Add(new List<string> { strs[i] });
         }
     }

     return ans;

 }
}

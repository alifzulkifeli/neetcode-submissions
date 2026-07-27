public class Solution {
   public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> ans = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] count = new int[26];
            foreach (var c in str)
            {
                count[c - 'a']++;
            }

            string cur = string.Join("-", count);
            
            if (ans.ContainsKey(cur))
            {
                ans[cur].Add(str);
                Console.WriteLine(string.Join("", ans[cur]));
            }
            else
            {
                ans.Add(cur, new List<string> { str });
            }
        }

        Console.WriteLine(string.Join(" ", ans));
        
        return ans.Values.ToList();
    }
}

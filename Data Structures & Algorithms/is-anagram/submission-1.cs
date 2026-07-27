
public class Solution {
    public bool IsAnagram(string s, string t)
    {

        if (s.Length != t.Length) return false;
        
        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            dictS[s[i]] = dictS.GetValueOrDefault(s[i]) + 1;
            dictT[t[i]] = dictT.GetValueOrDefault(t[i]) + 1;
        }

        foreach (var key in dictS.Keys)
        {
            if (!dictT.ContainsKey(key) || (dictS[key] != dictT[key])) return false;
        }
        
        return true;
    }
}

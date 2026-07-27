public class Solution {

public string Encode(IList<string> strs)
    {
        StringBuilder s =  new StringBuilder();
        foreach (var str in strs)
        {
            s.Append( str.Length.ToString()+ "#"+str);
        }
        
        return s.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> ans = new List<string>();
        int i = 0;
        int cur = 0;
        while (i < s.Length)
        {
            

            if (s[i] == '#')
            {
                if (Int32.TryParse(s.Substring(cur,i-cur ),  out int len))
                {
                    
                    Console.WriteLine(s.Substring(i+1, len));
                    ans.Add(s.Substring(i+1, len));
                    i = i + len +1;
                    cur = i;
                }
            }
            else
            {
                i++;
            }
        }
        
     
        return ans;
    }
}

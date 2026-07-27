
public class Solution {
    public bool IsValid(string s)
    {
        if (s.Length < 2 ) return false;

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        
        
        for (int i = 0; i < s.Length; i++){

            if (map.ContainsValue(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count > 0 && stack.Peek() == map[s[i]])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            
        }
        
         return stack.Count > 0 ? false : true;
    }
}

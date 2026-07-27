public class Solution {
    public bool IsPalindrome(string s)
    {
        char[] cleaned = (s.Where(char.IsLetterOrDigit).ToArray());

        Console.WriteLine(cleaned);
        int L = 0, R = cleaned.Length-1;
        while (L < R)
        {
            if (char.ToLower(cleaned[L]) != char.ToLower(cleaned[R]))return false;
            L++;
            R--;
        }
        
        
        return true;
    }
}
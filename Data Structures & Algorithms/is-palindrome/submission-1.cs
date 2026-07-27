public class Solution {
    public bool IsPalindrome(string s)
    {
        char[] chars = s.Where(s => char.IsLetterOrDigit(s)).ToArray();

        int L = 0, R = chars.Length - 1;
        while (L < R)
        {
            Console.WriteLine($"the {chars[L]} and {chars[R]} ");
            if (char.ToLower(chars[L]) != char.ToLower(chars[R])) return false;
            L++;
            R--;
        }
        
        return true;
    }
}

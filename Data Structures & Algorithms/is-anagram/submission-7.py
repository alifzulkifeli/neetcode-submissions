class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): return False

        marr = [0] * 26
        
        for i in range(len(s)):
            marr[ord(s[i]) - ord('a')] += 1
            marr[ord(t[i]) - ord('a')] -= 1

        for n in marr:
            if n != 0: return False
        return True
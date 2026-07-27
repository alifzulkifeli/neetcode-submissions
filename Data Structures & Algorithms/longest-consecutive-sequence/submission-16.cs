public class Solution {public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int ans = 0;
        int cur = 0;
        HashSet<int> bag = new HashSet<int>(nums.OrderBy(a=>a).ToArray());
        Console.WriteLine(bag.Count);

        foreach (var n in bag)
        {
            Console.WriteLine((n +1));
            if (!bag.Contains(n +1))
            {
                if (cur > ans) ans = cur;
                cur = 0;
            }
            else
            {
                cur++;
            }
        }

        Console.WriteLine(cur);
        Console.WriteLine(ans);
        return ans + 1;
    }
}

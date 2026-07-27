public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        HashSet<int> set = new HashSet<int>(nums);
        int[] sorted = set.OrderByDescending(a => -a).ToArray();

        Console.WriteLine(string.Join(",", sorted));

        int a = 0;
        int b = 0;
        for (int i = 0; i < sorted.Length; i++)
        {
            if (set.Contains(sorted[i] + 1))
            {
                a++;
            }
            else
            {
                if (b < a)
                {
                    b = a;
                }
                a = 0;
                
            }

        }


        Console.WriteLine(b + 1);
        return b + 1;
    }
}

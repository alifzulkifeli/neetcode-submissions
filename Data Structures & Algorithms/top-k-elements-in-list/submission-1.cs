public class Solution {
    
    Dictionary<int, int> frequent = new Dictionary<int, int>();
    public int[] TopKFrequent(int[] nums, int k) {
        foreach (var n in nums)
        {
            if (frequent.ContainsKey(n))
            {
                frequent[n]++;
            }
            else
            {
                frequent.Add(n,1);
            }
        }

        List<int[]> arr = frequent.
            Select(e => new int[] { e.Value, e.Key })
            .OrderByDescending(a => a[0])
            .ToList();

        int[] ans = new int[k];
        for (int i = 0; i < k; i++)
        {
            ans[i] = arr[i][1];
        }
        
        return ans;
    }
}

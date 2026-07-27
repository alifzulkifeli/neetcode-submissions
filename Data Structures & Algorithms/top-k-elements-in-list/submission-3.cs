public class Solution {
 public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> bag = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            bag[n] = bag.GetValueOrDefault(n)+1;
        }
        
        List<int[]> ans = bag 
            .Select(e => new int[]{e.Value, e.Key})
            .OrderByDescending(a => a[0])
            .ToList();
        
        int[] res = new int[k];

        for (int i = 0; i < k; i++)
        {
            res[i] = ans[i][1];
        }
        
        return res;
    }   
}

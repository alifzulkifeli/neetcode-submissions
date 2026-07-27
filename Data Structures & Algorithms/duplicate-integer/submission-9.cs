public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> bag =  new HashSet<int>();

        foreach (var n in nums)
        {
            if (bag.Contains(n)) return true;
            bag.Add(n);
        }
        return false;
    }
}

public class Solution {
        public bool hasDuplicate(int[] nums)
        {
            HashSet<int> bag = new HashSet<int>();

            foreach (int n in nums)
            {
                if (bag.Contains(n)) return true;
                else bag.Add(n);
            }
            return false;
        }
}
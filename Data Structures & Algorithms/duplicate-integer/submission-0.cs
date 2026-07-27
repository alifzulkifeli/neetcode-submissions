    public class Solution
    {
        public bool hasDuplicate(int[] nums)
        {
            List<int> listHolder = new List<int>();

            foreach (var num in nums)
            {
                if (listHolder.Contains(num))
                {
                    return true;
                }
                listHolder.Add(num);
            }
            return false;
        }
    }
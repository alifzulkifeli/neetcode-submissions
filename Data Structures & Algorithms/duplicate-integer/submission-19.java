class Solution {
    public boolean hasDuplicate(int[] nums) {
                HashSet<Integer> bag = new HashSet<>();
        for(int n: nums){
            if(bag.contains(n))return true;
            else bag.add(n);
        }
        return false;
    }
}
class Solution {
    public int maxArea(int[] heights) {
        int ans = 0;
        int left = 0; int right = heights.length -1;

        while(left < right){
            int size = (right - left) * Math.min(heights[left], heights[right]);
            System.out.println(left + " - " + right + " = " + size);
            ans = Math.max(size, ans);
            System.out.println( "-> "+ heights[left+1] + ", " + heights[right-1]);
            if ((heights[left]) <= (heights[right])  ){
                left++;
            } else {
                right--;
            }
        }
        return ans;
    }
}

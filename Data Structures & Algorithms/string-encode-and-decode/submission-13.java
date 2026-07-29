class Solution {
public static String encode(List<String> strs) {
			StringBuilder stbldr = new StringBuilder();

			for (String string : strs) {
				stbldr.append(string.length() + "#" + string);
			}
			System.out.println(stbldr);
      return stbldr.toString();
    }

    public static List<String> decode(String str) {

			ArrayList<String> ans = new ArrayList<>();
			int start = 0;
			while (start < str.length()-1) {
				int index = str.indexOf("#",start);
				int end = Integer.parseInt(str.substring(start, index)) + index;
				ans.add(str.substring(index+1, end+1));
				start = end +1;
			}
        return ans;
    }
}

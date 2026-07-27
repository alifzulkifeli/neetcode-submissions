class Solution {

    public String encode(List<String> strs) {
        StringBuffer buf = new StringBuffer();
        for (String s: strs){
            buf.append(s.length()).append("#al").append(s).append("#al");
        }
        return buf.toString();
    }

    public List<String> decode(String str) {
       ArrayList<String> res = new ArrayList<>();
        char[] charHolder = str.toCharArray();

        String[] ms = str.split("#al");


        for (int i = 0; i < ms.length; i++) {
            if (i % 2 == 1){
                res.add(ms[i]);
            }
        }

        if (str.length() > 0 && res.isEmpty()) {
            res.add("");
        };
        return res;
    }
}

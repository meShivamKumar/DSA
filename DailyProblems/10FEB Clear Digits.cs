public class Solution {
    public string ClearDigits(string s) {
        string ans = "";
        int totalChar = 0;

        for(int i =0; i<s.Length; i++) {
            if(!char.IsDigit(s[i])) {
                ans = ans.Replace(" ", String.Empty);
                ans = ans + s[i].ToString();
                totalChar++;
            }
            else {
                if(totalChar>0) {
                    StringBuilder sb = new StringBuilder(ans);
                    sb[totalChar -1] = ' ';
                    ans = sb.ToString();
                    totalChar = totalChar -1;
                }
            }
        }
        
        return ans.Replace(" ", String.Empty);
    }
}
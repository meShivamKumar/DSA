public class Solution {
    public bool IsPalindrome(int x) {
        if(x > 0){
            string val = x.ToString();
            string after = "";
            for(int i = val.Length; i > 0; i--){
                after = string.Concat(after , val[i-1]);
            }

            if(string.Equals(val, after)){

            return true;
            }
        }
        if(x>= 0 && x<=9){
            return true;
        }
        return false;
    }
}
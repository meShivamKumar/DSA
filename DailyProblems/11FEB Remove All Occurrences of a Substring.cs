public class Solution {
    public string RemoveOccurrences(string s, string part) {
        string result = "";
        for(int i = 0; i<s.Length; i++){
            result = result + s[i];

            if(result.Length >= part.Length){
                if(result.Substring(result.Length - part.Length) == part){
                    result = result.Remove(result.Length - part.Length);
                }
            }
        }

        return result;

    }
}
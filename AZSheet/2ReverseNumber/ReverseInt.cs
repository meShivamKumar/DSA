public class Solution {
    public int Reverse(int x) {
int ans = 0;
while(x!=0){
            if (ans < int.MinValue / 10 || ans > int.MaxValue / 10) {
                return 0;
            }
            ans = ans * 10 + x % 10;
            x = x/10;
}
        return ans;
}
}
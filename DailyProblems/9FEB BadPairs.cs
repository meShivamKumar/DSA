public class Solution {
    public long CountBadPairs(int[] nums) {
        Dictionary<long, long> pairs = new Dictionary<long, long>();
        long goodPairs = 0;
        long BPairs = 0;

        for(long i =0; i< nums.LongLength; i++){
            long x = nums[i] - i;
            if(pairs.ContainsKey(x)){
                goodPairs += pairs[x];
            pairs[x] = pairs[x] + 1;
            }
            else{
                pairs.Add(x,1);
            }
        }

        BPairs = ((nums.LongLength) * (nums.LongLength - 1) / 2) - goodPairs; 
        
        return BPairs;
    }
}
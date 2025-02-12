public class Solution {
    public int MaximumSum(int[] nums) {
        int[] maxSums = new int[82];
        int maxSum= -1;
        for(int i=0;i<nums.Length;i++){
            int digitSum = DigitSum(nums[i]);
            if(maxSums[digitSum]>0){
                maxSum = Math.Max(maxSums[digitSum] + nums[i],maxSum);
                maxSums[digitSum] = Math.Max(maxSums[digitSum], nums[i]);
            }
            else{
                maxSums[digitSum] = nums[i];
            }
        }
        return maxSum;
    }

    public int DigitSum(int num){
        int sum = 0;
        while(num>0){
            sum = sum + num%10;
            num = num/10;
        }
        return sum;
    }
}
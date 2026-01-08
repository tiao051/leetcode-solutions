public class Solution {
    public int MissingInteger(int[] nums) {
        int sum = nums[0];

        for (int i = 1; i < nums.Length; i++){
            if (nums[i] == nums[i-1] +1){
                sum += nums[i];
            }
            else {
                break;
            }
        }
        bool isExist = true;
        while (isExist) {
            isExist = false;
            for (int i = 0; i < nums.Length; i++){
                if (nums[i] == sum){
                    isExist = true;
                    break;
                }
            }
            
            if (isExist){
                sum++;
            }
        }
        return sum;
    }
}
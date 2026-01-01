/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// 
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// 
/// Example 1:
/// Input: nums = [2,7,11,15], target = 9
/// Output: [0,1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
/// 
/// Example 2:
/// Input: nums = [3,2,4], target = 6
/// Output: [1,2]
/// 
/// Example 3:
/// Input: nums = [3,3], target = 6
/// Output: [0,1]
/// 
/// Constraints:
/// 2 <= nums.length <= 10^4
/// -10^9 <= nums[i] <= 10^9
/// -10^9 <= target <= 10^9
/// Only one valid answer exists.
/// </summary>
/// <param name="nums">An array of integers</param>
/// <param name="target">The target sum</param>
/// <returns>Indices of the two numbers that add up to target</returns>
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            int missingNumber = target - nums[i];

            if (map.ContainsKey(missingNumber)){
                return new int[] { map[missingNumber], i };
            }

            if (!map.ContainsKey(nums[i])){
                map[nums[i]] = i;
            }
        }
        return new int[0];
    }
}

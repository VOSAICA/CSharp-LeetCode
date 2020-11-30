/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
using System.Collections;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(nums[0], 0);
        for (int i=1; i<nums.Length; i++)
        {
            if (hashtable.ContainsKey(target - nums[i]))  return new int[] {(int)hashtable[target - nums[i]], i};
            else  hashtable.Add(nums[i], i);
        }
        return new int[] {0, 0};
    }
}
// @lc code=end

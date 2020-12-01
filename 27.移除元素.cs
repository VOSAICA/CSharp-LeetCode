/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        #if false
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
        #else
        int i = 0;
        int n = nums.Length;
        while (i < n)   
        {
            if (nums[i] == val)
            {
                nums[i] = nums[n - 1];
                n--;
            }
            else i++;
        }
        return n;
        #endif
    }
}
// @lc code=end

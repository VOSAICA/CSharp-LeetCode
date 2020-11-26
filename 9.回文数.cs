/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;
        int Rev = 0;
        while (x > Rev)
        {
            Rev = Rev * 10 + x % 10;
            x /= 10;
        }
        return Rev == x || Rev / 10 == x;
    }
}
// @lc code=end

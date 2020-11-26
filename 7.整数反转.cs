/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        int Ans = 0;
        while (x != 0)
        {
            if (Ans > int.MaxValue / 10 || Ans < int.MinValue / 10) return 0;
            Ans = Ans * 10 + (x % 10);
            x = x / 10;
        }
        return Ans;
    }
}
// @lc code=end

/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start
using System;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length == 0) return "";

        int Len = strs[0].Length;
        int Num = strs.Length;

        for (int i = 0; i < Len; i++)
        {
            char Current = strs[0][i];
            for (int j = 1; j < Num; j++)
            {
                if (i == strs[j].Length || strs[j][i] != Current)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}
// @lc code=end

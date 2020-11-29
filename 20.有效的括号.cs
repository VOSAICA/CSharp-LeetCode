/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s)
    {
        if (s.Length % 2 == 1) return false;
        Dictionary<Char, Char> Map = new Dictionary<char, char>();
        Map.Add(')', '(');
        Map.Add(']', '[');
        Map.Add('}', '{');

        Stack<char> CharList = new Stack<char>();
        foreach (char sym in s)
        {
            if (Map.ContainsKey(sym))
            {
                if (CharList.Count == 0 || CharList.Peek() != Map[sym])  return false;
                CharList.Pop();
            }
            else CharList.Push(sym);
        }
        return CharList.Count == 0 ? true : false;
    }
}
// @lc code=end

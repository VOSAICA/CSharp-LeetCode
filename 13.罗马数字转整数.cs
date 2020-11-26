/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        Hashtable RomanChars = new Hashtable();
        RomanChars.Add('I', 1);
        RomanChars.Add('V', 5);
        RomanChars.Add('X', 10);
        RomanChars.Add('L', 50);
        RomanChars.Add('C', 100);
        RomanChars.Add('D', 500);
        RomanChars.Add('M', 1000);

        int Length = s.Length;
        int[] IntArray = new int[Length];
        int Result = 0;

        for (int i = 0; i < Length; i++) IntArray[i] = (int)RomanChars[s[i]];

        int j;
        for (j = 0; j < Length - 1; j++)
        {
            if (IntArray[j] < IntArray[j + 1])
            {
                Result += IntArray[j + 1] - IntArray[j];
                j++;
            }
            else Result += IntArray[j];
        }
        if (j != Length) Result += IntArray[Length - 1];
        return Result;
    }
}
// @lc code=end


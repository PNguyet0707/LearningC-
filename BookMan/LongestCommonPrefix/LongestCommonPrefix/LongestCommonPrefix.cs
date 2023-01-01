using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    public  string LongestCommonPrefix(string[] strs)
    {
        string LongestPrefix = strs[0];
        char FirstChar = strs[0][0];
        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i][0] != FirstChar)
                return "";
        }
        for (int i = 0; i < strs.Length; i++)
        {
            if (LongestPrefix.Length > CommonPrefix(strs[i], strs[i + 1]).Length)
            {
                LongestPrefix = CommonPrefix(strs[i], strs[i + 1]);
            }

        }
        return LongestPrefix;
    }
    public static string CommonPrefix(string a, string b)
    {
        string common = "";
        int len = (a.Length < b.Length) ? a.Length : b.Length;
        for (int i = 0; i < len; i++)
        {
            if (a[i] == b[i])
            {
                common += a[i];
            }
            else
            {
                return common;
            }
        }
        return common;
    }
}

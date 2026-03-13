using System;

public static class PalindromeUtil
{
    public static bool IsPalindrome(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        string whiteRemoved = text.Replace(" ", "").Replace(":", "").Replace(",", "").ToLower();
        char[] chars = whiteRemoved.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);

        return whiteRemoved.Equals(reversed);
    }
}
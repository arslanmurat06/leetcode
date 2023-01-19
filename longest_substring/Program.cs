

Console.WriteLine(LengthOfLongestSubstring("abcabasdasdas"));

int LengthOfLongestSubstring(string s)
{
    int start = 0;
    int end = 0;
    int max = 0;
    HashSet<char> set = new HashSet<char>();

    while (start < s.Length)
    {
        char c = s[start];

        while (set.Contains(c))
        {
            set.Remove(s[end]);
            ++end;
        }

        set.Add(c);
        max = Math.Max(max, start - end + 1);
        ++start;
    }

    return max;
}
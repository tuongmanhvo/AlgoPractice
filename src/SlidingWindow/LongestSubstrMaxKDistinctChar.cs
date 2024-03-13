/// <summary>
/// Given a string, find the length of the longest substring in it with no more than K distinct characters.
/// </summary>
public class LongestSubstrMaxKDistinctChar
{
    public static int Run(int k, string str)
    {
        var maxLength = 0;
        var windowStart = 0;
        var charFrequency = new Dictionary<char, int>();// window result
        for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            addChar(str[windowEnd], charFrequency);
            // shrink the window until we have k distinct characters
            while (charFrequency.Keys.Count > k)
            {
                removeChar(str[windowStart], charFrequency);
                windowStart += 1;
            }

            // remember the max length so far
            maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
        }
        return maxLength;
    }

    private static void addChar(char c, Dictionary<char, int> charFrenquency)
    {
        if (!charFrenquency.ContainsKey(c))
        {
            charFrenquency.Add(c, 0);
        }

        charFrenquency[c] += 1;
    }
    private static void removeChar(char c, Dictionary<char, int> charFrequency)
    {
        charFrequency[c] -= 1;
        if (charFrequency[c] == 0)
        {
            charFrequency.Remove(c);
        }
    }
}
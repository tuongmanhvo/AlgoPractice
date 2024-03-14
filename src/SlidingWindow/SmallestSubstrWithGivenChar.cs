/// <summary>
/// Given a string and a pattern,
/// find the smallest substring in the given string which has all the characters of the given pattern.
/// </summary>
public class SmallestSubstrWithGivenChar
{
    public static string Run(string pattern, string str)
    {
        var windowStart = 0;
        var matched = 0;
        var subStrStart = 0;
        var minLength = str.Length + 1;
        var charFrequency = Helper.BuildFrequencyFromPattern(pattern);

        for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            var rightChar = str[windowEnd];
            if (charFrequency.ContainsKey(rightChar))
            {
                charFrequency[rightChar] -= 1;// negative value when there are useful occurence of a char
                if (charFrequency[rightChar] >= 0)// Count every matching of a character
                {
                    matched += 1;
                }
            }

            // shrink the window
            while (matched == pattern.Length)
            {
                if (minLength > windowEnd - windowStart + 1)
                {
                    minLength = windowEnd - windowStart + 1;
                    subStrStart = windowStart;
                }

                var leftChar = str[windowStart];
                windowStart += 1;
                if (charFrequency.TryGetValue(leftChar, out var frequency))
                {
                    if (frequency == 0) { matched -= 1; }// when remove a useful occurence
                    charFrequency[leftChar] += 1;
                }
            }
        }

        return minLength > str.Length
        ? ""
        : str.Substring(subStrStart, minLength);
    }

}

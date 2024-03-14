/// <summary>
/// Given a string and a pattern, find all anagrams of the pattern in the given string.
/// Write a function to return a list of starting indices of the anagrams of the pattern in the given string.
/// </summary>
public class FindAllAnagrams
{
    public static int[] Run(string pattern, string str)
    {
        var windowStart = 0;
        var matched = 0;
        var charFrenquency = Helper.BuildFrequencyFromPattern(pattern);
        List<int> resultIndices = [];

        for (var windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            var rightChar = str[windowEnd];

            //Decrement the frequency of matched character
            if (charFrenquency.ContainsKey(rightChar))
            {
                charFrenquency[rightChar] -= 1;
                if (charFrenquency[rightChar] == 0)
                {
                    matched += 1;
                }
            }

            // found an anagram
            if (matched == charFrenquency.Count) { resultIndices.Add(windowStart); }

            if (windowEnd >= pattern.Length - 1)
            {
                var leftChar = str[windowStart];
                windowStart += 1;
                if (charFrenquency.TryGetValue(leftChar, out var frequency))
                {
                    if (frequency == 0) { matched -= 1; }

                    charFrenquency[leftChar] += 1;
                }
            }
        }
        return resultIndices.ToArray();
    }
}
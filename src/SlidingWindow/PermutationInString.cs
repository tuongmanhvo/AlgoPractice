/// <summary>
/// Given a string and a pattern, find out if the string contains any permutation of the pattern.
/// </summary>
public class PermutationInString
{
    public static bool Run(string pattern, string str)
    {
        var windowStart = 0;
        var matched = 0;
        var charFrenquency = Helper.BuildFrequencyFromPattern(pattern);

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

            if (matched == charFrenquency.Count) { return true; }

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

        return false;
    }

}
/// <summary>
/// Given a string with lowercase letters only, 
/// if you are allowed to replace no more than k letters with any letter, 
/// find the length of the longest substring having the same letters after replacement.
/// </summary>
public class LongestSubstrSameLetterReplacement
{
    public static int Run(int k, string str)
    {
        var windowStart = 0;
        int maxLength = 0;//result
        var maxRepeatLetterCount=0;//result -k
        var charFrequency = new Dictionary<char, int>();

        for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            var rightChar = str[windowEnd];
            addChar(rightChar,charFrequency);
            maxRepeatLetterCount=Math.Max(maxRepeatLetterCount,charFrequency[rightChar]);

            //shrink when number of other character > k
            if(windowEnd-windowStart+1-maxRepeatLetterCount>k)
            {
                var leftChar=str[windowStart];
                charFrequency[leftChar]-=1;
                windowStart++;
            }

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

}
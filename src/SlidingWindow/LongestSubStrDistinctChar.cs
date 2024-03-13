using System.Collections;


/// <summary>
/// Given a string, find the length of the longest substring, which has all distinct characters.
/// </summary>
public class LongestSubStrDistinctChar
{
    public static int Run(string str)
    {
        var maxLength = 0;
        var windowsStart = 0;
        var charIndexMap = new Dictionary<char, int>();// window result

        for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            var rightChar = str[windowEnd];
            // if the map already contain the char, shrink the window from the beginning
            // so that we have only one occurence of the char
            if (charIndexMap.ContainsKey(rightChar))
            {
                // this is tricky
                windowsStart = Math.Max(windowsStart, charIndexMap[rightChar] + 1);
            }
            // insert the char into the map
            charIndexMap[rightChar] = windowEnd;

            // remember the max length so far
            maxLength = Math.Max(maxLength, windowEnd - windowsStart + 1);
        }

        return maxLength;
    }
}
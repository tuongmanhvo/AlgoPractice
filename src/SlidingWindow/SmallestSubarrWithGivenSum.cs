/// <summary>
/// Given an array of positive numbers and a positive number ‘S,’ 
/// find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. 
/// Return 0 if no such subarray exists.
/// </summary>
public class SmallestSubarrWithGivenSum
{
    public static int Run(int s, int[] arr)
    {
        var minLength = int.MaxValue;
        var windowSum = 0;
        var windowStart = 0;

        for (var windowEnd = 0; windowEnd < arr.Length; windowEnd++)
        {
            windowSum += arr[windowEnd];// add the new element
            // shrink the windown until windowSum is smaller than s
            while (windowSum >= s)
            {
                minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                windowSum -= arr[windowStart];// remove the element going out
                windowStart++;// resize window
            }
        }

        return minLength == int.MaxValue
                ? 0
                : minLength;
    }
}
/// <summary>
/// Given an array of positive numbers and a positive number ‘k,’ find the maximum sum of any contiguous subarray of size ‘k’.
/// </summary>
public class MaxSumSubarrK
{
    public static int Run(int k, int[] arr)
    {
        var maxSum = 0;
        var windowSum = 0;
        var windowStart = 0;
        for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
        {
            windowSum += arr[windowEnd];// add the new element
            // slide the window until hit the size k
            if (windowEnd >= k - 1)
            {
                maxSum = Math.Max(maxSum, windowSum);
                windowSum -= arr[windowStart];// remove the element going out
                windowStart += 1;// slide the window ahead, resize the window
            }
        }


        return maxSum;
    }
}
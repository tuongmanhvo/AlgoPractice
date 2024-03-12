/// <summary>
/// Given an array, find the average of all contiguous subarrays of size 'K' in it.
/// </summary>
public class AvgContiguousSubarrK
{
    public static double[] Run(int k, int[] arr)
    {
        var result = new List<double>();
        var windowSum = 0.0;
        var windowStart = 0;

        for (var windowEnd = 0; windowEnd < arr.Length; windowEnd++)
        {
            windowSum += arr[windowEnd];//add the new element

            //slide the window until hit the size k
            if (windowEnd >= k - 1)
            {
                result.Add(windowSum / k);//calculate the avg
                windowSum -= arr[windowStart];//remove the element going out
                windowStart += 1;//slide the window ahead, resizing window
            }
        }

        return [.. result];
    }
}
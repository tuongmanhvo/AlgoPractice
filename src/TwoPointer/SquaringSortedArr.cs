/// <summary>
/// Given a sorted array, create a new array containing squares of all the numbers of the input array in the sorted order.
/// </summary>
public class SquaringSortedArr
{
    public static double[] Run(int[] arr)
    {
        if (arr.Length == 0) { return []; }

        var n = arr.Length;
        var squares = new double[n];
        var highestSquareIdx = n - 1;
        var left = 0;
        var right = n - 1;

        while (left <= right)
        {
            var leftSq = Math.Pow(arr[left], 2);
            var righttSq = Math.Pow(arr[right], 2);

            if (leftSq > righttSq)
            {
                squares[highestSquareIdx] = leftSq;
                left += 1;
            }
            else
            {
                squares[highestSquareIdx] = righttSq;
                right -= 1;
            }
            highestSquareIdx -= 1;
        }

        return squares;
    }
}
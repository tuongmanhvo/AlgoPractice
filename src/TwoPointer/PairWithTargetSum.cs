public class PairWithTargetSum
{
    public static int[] Run(int targetSum, int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left < right)
        {
            var currentSum = arr[left] + arr[right];
            if (currentSum == targetSum) { return [left, right]; }

            if (currentSum < targetSum) { left += 1; }
            else { right -= 1; }
        }

        return [];
    }
}
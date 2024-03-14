public class RemoveTarget
{
    public static int Run(int target, int[] arr)
    {
        var nextElement = 0;//element whish is not the target

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != target)
            {
                arr[nextElement] = arr[i];
                nextElement += 1;
            }
        }

        return nextElement;
    }
}
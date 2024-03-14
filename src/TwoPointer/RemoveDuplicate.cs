/// <summary>
/// Given an array of sorted numbers, remove all duplicates from it.
/// You should not use any extra space;
/// after removing the duplicates in-place return the length of the subarray that has no duplicate in it.
/// </summary>
public class RemoveDuplicate
{

    public static int Run(int[] arr)
    {
        if (arr.Length == 0) return 0;
        
        var nextNotDup = 1;
        var i = 1;

        while (i < arr.Length)
        {
            if (arr[nextNotDup - 1] != arr[i])
            {
                arr[nextNotDup] = arr[i];
                nextNotDup += 1;
            }
            i += 1;
        }

        return nextNotDup;
    }
}
public class SmallestSubarrWithGivenSumTest
{
    [Fact]
    public void Arr_Empty()
    {
        var s = 0;
        int[] arr = [];

        var result = SmallestSubarrWithGivenSum.Run(s, arr);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(2, 7, 2, 1, 5, 2, 3, 2)]
    [InlineData(1, 7, 2, 1, 5, 2, 8)]
    [InlineData(3, 8, 3, 4, 1, 1, 6)]
    public void Arr_NotEmpty(int expected, int s, params int[] arr)
    {
        var result = SmallestSubarrWithGivenSum.Run(s, arr);

        Assert.Equal(expected, result);
    }

}
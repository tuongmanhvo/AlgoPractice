public class MaxSumSubarrKTest
{
    [Fact]
    public void Arr_Empty()
    {
        var k = 5;
        var arr = Array.Empty<int>();

        var result = MaxSumSubarrK.Run(k, arr);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(9, 3, 2, 1, 5, 1, 3, 2)]
    [InlineData(7, 2, 2, 3, 4, 1, 5)]
    public void Arr_NotEmpty(int expected, int k, params int[] arr)
    {
        var result = MaxSumSubarrK.Run(k, arr);

        Assert.Equal(expected, result);
    }
}
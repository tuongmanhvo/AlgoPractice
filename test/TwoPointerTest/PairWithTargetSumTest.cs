public class PairWithTargetSumTest
{
    [Fact]
    public void Arr_Empty()
    {
        // Given
        var sum = 0;
        var arr = Array.Empty<int>();
        // When
        var actual = PairWithTargetSum.Run(sum, arr);
        // Then
        Assert.Empty(actual);
    }

    [Theory]
    [InlineData(1, 3, 6, new int[] { 1, 2, 3, 4, 6 })]
    [InlineData(0, 2, 11, new int[] { 2, 5, 9, 11 })]
    [InlineData(0,5,7,new int[]{1,2,3,4,5,6})]
    public void Arr_NotEmpty(int first, int second, int sum, int[] arr)
    {
        var actual = PairWithTargetSum.Run(sum, arr);

        Assert.Collection(actual,
                    e => Assert.Equal(first, e),
                    e => Assert.Equal(second, e));
    }
}
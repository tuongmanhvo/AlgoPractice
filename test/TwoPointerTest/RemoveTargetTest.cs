public class RemoveTargetTest
{
    [Fact]
    public void Arr_Empty()
    {
        // Given
        var target = 0;
        var arr = Array.Empty<int>();
        // When
        var actual = RemoveTarget.Run(target, arr);

        // Then
        Assert.Equal(0, actual);
    }

    [Theory]
    [InlineData(4, 3, new int[] { 3, 2, 3, 6, 3, 10, 9, 3 })]
    [InlineData(2, 2, new int[] { 2, 11, 2, 2, 1 })]
    public void Arr_NotEmpty(int expected, int target, int[] arr)
    {
        var actual = RemoveTarget.Run(target, arr);

        Assert.Equal(expected, actual);
    }
}
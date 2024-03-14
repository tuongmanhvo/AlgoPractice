public class RemoveDuplicateTest
{
    [Fact]
    public void Arr_Empty()
    {
        // Given
        var arr = Array.Empty<int>();
        // When
        var result = RemoveDuplicate.Run(arr);
        // Then
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(4, new int[] { 2, 3, 3, 3, 6, 9, 9 })]
    [InlineData(2, new int[] { 2, 2, 2, 11 })]
    public void Arr_NotEmpty(int expected, int[] arr)
    {
        var actual = RemoveDuplicate.Run(arr);

        Assert.Equal(expected, actual);
    }
}
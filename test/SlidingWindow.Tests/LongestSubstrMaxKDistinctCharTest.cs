public class LongestSubstrMaxKDistinctCharTest
{
    [Fact]
    public void Str_Empty()
    {
        // Given
        var str = "";
        var k = 2;
        // When
        var result = LongestSubstrMaxKDistinctChar.Run(k, str);
        // Then
        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData(4, 2, "araaci")]
    [InlineData(2, 1, "araaci")]
    [InlineData(5, 3, "cbbebi")]
    public void Str_NotEmpty(int expected, int k, string str)
    {
        // Given
        // When
        var result = LongestSubstrMaxKDistinctChar.Run(k, str);
        // Then
        Assert.Equal(expected, result);
    }

}
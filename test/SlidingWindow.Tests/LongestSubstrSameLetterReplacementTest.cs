public class LongestSubstrSameLetterReplacementTest
{
    [Fact]
    public void Str_Empty()
    {
        // Given
        var k = 1;
        var str = "";
        // When
        var result = LongestSubstrSameLetterReplacement.Run(k, str);
        // Then
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(5, 2, "aabccbb")]
    [InlineData(4, 1, "abbcb")]
    [InlineData(3, 1, "abccde")]
    public void Str_NotEmpty(int expected, int k, string str)
    {
        var result = LongestSubstrSameLetterReplacement.Run(k, str);

        Assert.Equal(expected, result);
    }
}
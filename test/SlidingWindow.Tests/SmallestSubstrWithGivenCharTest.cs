public class SmallestSubstrWithGivenCharTest
{
    [Fact]
    public void Str_Empty()
    {
        // Given
        var pattern = "";
        var str = "";
        // When
        var result = SmallestSubstrWithGivenChar.Run(pattern, str);
        // Then
        Assert.Equal("", result);
    }

    [Theory]
    [InlineData("abdec", "abc", "aabdec")]
    [InlineData("bca", "abc", "abdbca")]
    [InlineData("", "abc", "adcad")]
    public void Str_NotEmpty(string expected, string pattern, string str)
    {
        var result = SmallestSubstrWithGivenChar.Run(pattern, str);

        Assert.Equal(expected, result);
    }
}
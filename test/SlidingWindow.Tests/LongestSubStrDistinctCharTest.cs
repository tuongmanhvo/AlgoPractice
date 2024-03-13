public class LongestSubStrDistinctCharTest
{
    [Fact]
    public void Str_Empty()
    {
        var str = "";

        var result = LongestSubStrDistinctChar.Run(str);

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(3,"aabccbb")]
    [InlineData(3,"aabcabb")]
    [InlineData(2,"abbbb")]
    [InlineData(3,"abccde")]
    public void Str_NotEmpty(int expected, string str)
    {
        var result = LongestSubStrDistinctChar.Run(str);

        Assert.Equal(expected, result);
    }

}
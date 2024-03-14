public class PermutationInStringTest
{
    [Fact]
    public void Str_Empty()
    {
        // Given
        var pattern = "abc";
        var str = "";
        // When
        var result = PermutationInString.Run(pattern, str);
        // Then
        Assert.False(result);
    }

    [Theory]
    [InlineData(true, "abc", "oidbcaf")]
    [InlineData(false, "dc", "odicf")]
    [InlineData(true, "bcdyabcdx", "bcdxabcdy")]
    [InlineData(true, "abc", "aaacb")]
    public void Str_NotEmpty(bool expected, string pattern, string str)
    {
        var result = PermutationInString.Run(pattern, str);

        Assert.Equal(expected, result);
    }
}
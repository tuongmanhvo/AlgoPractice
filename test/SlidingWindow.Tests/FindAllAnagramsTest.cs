public class FindAllAnagramsTest
{
    [Fact]
    public void Str_Empty()
    {
        // Given
        var pattern = "";
        var str = "";
        // When
        var result = FindAllAnagrams.Run(pattern, str);
        // Then
        Assert.Empty(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2 }, "pq", "ppqp")]
    [InlineData(new int[] { 2, 3, 4 }, "abc", "abbcabc")]
    public void Str_NotEmpty(int[] expected, string pattern, string str)
    {

        var result = FindAllAnagrams.Run(pattern, str);

        Assert.Equivalent(expected, result, true);
    }

}
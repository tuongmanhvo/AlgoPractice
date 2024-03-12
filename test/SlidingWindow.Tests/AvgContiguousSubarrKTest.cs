
public class AvgContiguousSubarrKTest
{
    [Fact]
    public void Arr_Empty()
    {
        var arr = Array.Empty<int>();
        var k = 5;
        var result = AvgContiguousSubarrK.Run(k, arr);
        Assert.True(result.Length == 0);
    }

    [Fact]
    public void Arr_5_K5()
    {
        int[] arr = [1, 3, 2, 6, -1];
        var k = 5;
        var result = AvgContiguousSubarrK.Run(k, arr);
        Assert.Single(result);
        Assert.Equal(2.2, result.First());

    }

    [Fact]
    public void Arr_9_K5()
    {
        int[] arr = [1, 3, 2, 6, -1, 4, 1, 8, 2];
        var k = 5;
        var result = AvgContiguousSubarrK.Run(k, arr);
        Assert.Collection(result,
                        e => Assert.Equal(2.2, e, 1),
                        e => Assert.Equal(2.8, e, 1),
                        e => Assert.Equal(2.4, e, 1),
                        e => Assert.Equal(3.6, e, 1),
                        e => Assert.Equal(2.8, e, 1));

    }
}
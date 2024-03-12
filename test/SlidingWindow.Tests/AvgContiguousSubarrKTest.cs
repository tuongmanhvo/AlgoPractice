
public class AvgContiguousSubarrKTest
{
    [Fact]
    public void Arr_Empty()
    {
        var arr = Array.Empty<int>();
        var result = AvgContiguousSubarrK.Run(arr);
        Assert.True(result.Length==0);
    }
}
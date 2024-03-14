public class SquaringSortedArrTest
{
    [Fact]
    public void Arr_Empty()
    {
        // Given
        int[] arr = [];
        // When
        var actual = SquaringSortedArr.Run(arr);
        // Then
        Assert.Empty(actual);
    }
    [Theory]
    [InlineData(new double[]{0,1,4,4,9},new int[]{-2,-1,0,2,3})]
    [InlineData(new double[]{0,1,1,4,9},new int[]{-3,-1,0,1,2})]
    public void Arr_NotEmpty(double[]expected,int[]arr)
    {
        var actual=SquaringSortedArr.Run(arr);

        Assert.Equivalent(expected,actual,true);
    }
}
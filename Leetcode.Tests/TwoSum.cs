using LeetCode;

namespace Leetcode.Tests;

public class TwoSum
{
    
    //Runtime: 176 ms, faster than 87.19% of C# online submissions for Two Sum.
    //Memory Usage: 43.8 MB, less than 22.48% of C# online submissions for Two Sum.
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0,1 })]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        var ts = new TwoSumClass();
        var result = ts.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}
namespace LeetCode;

/// <summary>
///  https://leetcode.com/problems/two-sum/
/// </summary>
public class TwoSumClass
{
    private class Data
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
    }
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, Data>(nums.Length);
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                var data = dict[nums[i]];
                data.SecondValue = i;
            }
            else
            {
                dict.Add(nums[i], new Data { FirstValue = i, SecondValue = -1 });
            }
        }

        var first = 0;
        var second = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var tmp = target - nums[i];
            if (!dict.ContainsKey(tmp)) continue;
            first = i;
            var data = dict[tmp];
            second = data.FirstValue;
            if (first == second)
            {
                if (data.SecondValue == -1)
                {
                    continue;
                }

                second = data.SecondValue;
            }

            break;
        }

        return new int[] { first, second };
    }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。

你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。

你可以按任意顺序返回答案。

示例 1：

输入：nums = [2,7,11,15], target = 9
输出：[0,1]
解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
示例 2：

输入：nums = [3,2,4], target = 6
输出：[1,2]
示例 3：

输入：nums = [3,3], target = 6
输出：[0,1]
 
提示：

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
只会存在一个有效答案
 * 
 */

var numsList = new List<int> { 2, 17, 11, 15, 7 };
var target = 9;
var nums = numsList.ToArray();
var re1 = TwoSum(nums, target);
Console.WriteLine(re1[0] + "---" + re1[1]);

int[] TwoSum(int[] nums, int target)
{
    var reArr = new int[2];
    for (var i = 0; i < nums.Length; i++)
    {
        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                reArr[0] = i;
                reArr[1] = j;
            }
        }

    }
    return reArr;
}


re1 = TwoSum2(nums, target);
Console.WriteLine(re1[0] + "---" + re1[1]);
int[] TwoSum2(int[] nums, int target)
{
    Dictionary<int, int> kvs = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (kvs.ContainsKey(complement) && kvs[complement] != i)
        {
            return new int[] { i, kvs[complement] };
        }
        //需要对重复值进行判断,若结果包含了重复值，则已经被上面给return了；所以此处对于重复值直接忽略
        if (!kvs.ContainsKey(nums[i]))
        {
            kvs.Add(nums[i], i);
        }
    }
    return new int[] { 0, 0 };
}

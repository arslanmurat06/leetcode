//[1,3,5,4,7] => [1,3,5] = 3

// longest continuous increasing subsequence

// implemented by using Dynamic window algorithm

Console.WriteLine(findLenghtOfLCSI(new int[] { 1, 2, 3, 2, 3, 4, 5 }));
int findLenghtOfLCSI(int[] nums)
{

    int start = 0;
    int end = 0;
    int max = 0;
    int latestOne = 0;

    while (start < nums.Length)
    {
        var num = nums[start];
        if (num > latestOne)
        {
            max = Math.Max(max, start - end + 1);
        }
        else
        {
            end = start;
        }
        latestOne = num;
        ++start;
    }
    return max;
}

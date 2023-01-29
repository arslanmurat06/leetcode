//[4,5,0,-2,-3,1]

//4, 5, 0, -2, -3, 1], [5], [5, 0], [5, 0, -2, -3], [0], [0, -2, -3], [-2, -3]


Console.WriteLine(SubarraysDivByK(new int[] { 4, 5, 0, -2, -3, 1 }, 5));


// // time limit exceeded
// int SubarraysDivByK(int[] nums, int k)
// {
//     int sum = 0;
//     int numArray = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         sum = 0;
//         sum += nums[i];
//         if (sum % k == 0) numArray++;
//         for (int j = i + 1; j < nums.Length; j++)
//         {
//             sum += nums[j];
//             if (sum % k == 0)
//             {
//                 numArray++;
//             }
//         }
//     }
//     return numArray;
// }

int SubarraysDivByK(int[] nums, int k)
{

    int subCount = 0;

    int start = 0;
    int end = 0;

    int sum = 0;

    while (start < nums.Length)
    {
        var num = nums[start];
        if (num % 5 == 0) subCount++;

        if (num < 0)
        {
            num = (num % 5) + 5;

        }

        sum += num;

        if (sum % 5 == 0)
        {
            subCount++;
        }

        while()



    }




    return default;
}
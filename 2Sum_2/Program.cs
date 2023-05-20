using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _2Sum_2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new ();

            var result = solution.TwoSum(new int[] { 3, 3 }, 6);

            Console.WriteLine(JsonSerializer.Serialize(result));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new();
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[j] + nums[i] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
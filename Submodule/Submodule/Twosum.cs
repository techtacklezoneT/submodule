namespace Submodule
{
    public class Twosum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.TryGetValue(complement, out int value))
                {
                    return [value, i];
                }
                map[nums[i]] = i;
            }
            throw new Exception("No two sum solution");
        }

        public static int AddTwoNumber(int a, int b) => a + b;
    }

}

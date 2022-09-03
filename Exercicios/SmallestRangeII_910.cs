using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class SmallestRangeII_910
    {
        public static int Solucao(int[] nums, int k)
        {
            Array.Sort(nums);
            //Diferença entre maior item e menor
            int ans = nums[nums.Length - 1] - nums[0];

            for (int i = 0; i < nums.Length - 1; ++i)
            {
                int a = nums[i], b = nums[i + 1];
                int high = Math.Max(nums[nums.Length - 1] - k, a + k);
                int low = Math.Min(nums[0] + k, b - k);
                ans = Math.Min(ans, high - low);
            }
            return ans;
        }
    }
}

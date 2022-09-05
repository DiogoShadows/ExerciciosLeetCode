using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class TwoSum_1
    {
        public static int[] Solucao(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int a = i + 1; a < nums.Length; a++)
                {
                    if (nums[a] + nums[i] == target)
                        return new int[] { i, a };
                }
            }

            return new int[] { };
        }
    }
}

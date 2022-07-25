using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RotateArray_189
    {
        public static void Solucao(int[] nums, int k)
        {
            while (k > nums.Length)
            {
                k -= nums.Length;
            }

            var resposta = nums.TakeLast(k).Concat(nums.SkipLast(k)).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = resposta[i];
            }

        }
    }
}

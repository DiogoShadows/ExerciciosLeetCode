using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class SquaresOfASortedArray_977
    {
        public static int[] Solucao(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            return nums.OrderBy(x => x).ToArray();
        }
    }
}

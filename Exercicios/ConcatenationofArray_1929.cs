using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class ConcatenationofArray_1929
    {
        public static int[] Solucao(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }
    }
}

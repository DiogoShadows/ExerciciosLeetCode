using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MoveZeroes_283
    {
        public static void Solucao(int[] nums)
        {
            int snowBallSize = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    snowBallSize++;
                }
                else if (snowBallSize > 0)
                {
                    int t = nums[i];
                    nums[i] = 0;
                    nums[i - snowBallSize] = t;
                }
            }
        }
    }
}

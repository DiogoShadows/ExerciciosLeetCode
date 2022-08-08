using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class LongestIncreasingSubsequence_300
    {
        public static int Solucao(int[] nums)
        {
            int[] somas = new int[nums.Length];

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                int index = i + 1;
                int maior = 1;

                while(index < nums.Length)
                {
                    if(nums[i] < nums[index])
                    {
                        if(maior < somas[index] + 1)
                            maior = somas[index] + 1;
                    }

                    index++;
                }

                somas[i] = maior;
            }

            return somas.Max();
        }
    }
}

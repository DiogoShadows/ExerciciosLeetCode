using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaxConsecutiveOnes_485
    {
        public static int Solucao(int[] nums)
        {
            int maior = 0, atual = 0, ultimo = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != ultimo)
                    atual = 0;

                if(nums[i] != 0)
                    atual++;

                ultimo = nums[i];

                if (atual > maior)
                    maior = atual;
            }

            return maior;
        }
    }
}

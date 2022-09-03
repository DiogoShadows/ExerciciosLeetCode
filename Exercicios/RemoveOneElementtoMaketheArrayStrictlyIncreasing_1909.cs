using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RemoveOneElementtoMaketheArrayStrictlyIncreasing_1909
    {
        public static bool Solucao(int[] nums)
        {
            bool numeroForaDeOrdem = false, numeroDuplicado = false;
            int maior = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] <= maior)
                {
                    if (numeroForaDeOrdem || numeroDuplicado)
                        return false;

                    if (maior == nums[i])
                        numeroDuplicado = true;

                    else
                        numeroForaDeOrdem = true;

                    if (i == 1 || i - 2 >= 0 && nums[i] > nums[i - 2])
                        maior = nums[i];
                }

                else
                    maior = nums[i];
            }

            return true;
        }
    }
}

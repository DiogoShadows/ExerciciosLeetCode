using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class CombinationSumIV_377
    {
        public static int Solucao(int[] nums, int target)
        {
            int[] combinacoes = new int[target + 1];
            combinacoes[0] = 1;

            for (int i = 1; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    var iMenosNumero = i - nums[j];
                    if (iMenosNumero >= 0)
                        combinacoes[i] += combinacoes[iMenosNumero];

                }
            }

            return combinacoes[target];
        }
    }
}

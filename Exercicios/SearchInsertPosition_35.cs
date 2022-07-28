using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class SearchInsertPosition_35
    {
        public static int Solucao(int[] nums, int target)
        {
            var resposta = Array.BinarySearch(nums, target);

            if (resposta < 0)
            {
                nums = nums.Append(target).ToArray();
                nums = nums.OrderBy(x => x).ToArray();
                return Array.BinarySearch(nums, target);
            }

            return resposta;
        }
    }
}

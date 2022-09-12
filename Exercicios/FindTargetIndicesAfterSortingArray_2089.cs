using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FindTargetIndicesAfterSortingArray_2089
    {
        public static IList<int> Solucao(int[] nums, int target)
        {
            nums = nums.OrderBy(x => x).ToArray();
            List<int> resposta = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    resposta.Add(i);
            }

            return resposta;
        }
    }
}

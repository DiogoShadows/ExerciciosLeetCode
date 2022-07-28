using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class BinarySearch_704
    {
        public static int Solucao(int[] nums, int target)
        {
            var resposta = Array.BinarySearch(nums, target);
            return resposta <= -1 ? -1 : resposta;
        }
    }
}

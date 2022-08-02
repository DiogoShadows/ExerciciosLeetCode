using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MinimumOperationsToHalveArraySum_2208
    {
        public static int Solucao(int[] nums)
        {
            var queue = new PriorityQueue<int, int>();
            var somaInicial = nums.Sum(x => x);
            var somaComparacao = somaInicial;
            var totalOperacoes = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i], nums[i]);
            }

            while(somaComparacao > somaInicial / 2)
            {
                totalOperacoes++;
                queue.Dequeue();
                queue.Peek();
                var a = queue.Comparer;
            }

            return 1;
        }
    }
}

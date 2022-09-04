using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaximumElementAfterDecreasingandRearranging_1846
    {
        public static int Solucao(int[] arr)
        {
            arr = arr.OrderBy(x => x).ToArray();
            arr[0] = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                if (!(arr[i] - arr[i - 1] <= 1))
                    arr[i] = arr[i - 1] + 1;
            }

            return arr.Max();
        }
    }
}

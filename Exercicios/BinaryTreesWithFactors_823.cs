using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class BinaryTreesWithFactors_823
    {
        public static int Solucao(int[] arr)
        {
            Array.Sort(arr);
            Dictionary<int, long> dict = new();
            long count = 1;
            int mod = (int)Math.Pow(10, 9) + 7;
            dict.Add(arr[0], count);

            for (int numeroArray = 1; numeroArray < arr.Length; numeroArray++)
            {
                count = 1;

                foreach (var valorDicionario in dict.Keys)
                {
                    if (arr[numeroArray] % valorDicionario == 0 && dict.ContainsKey(arr[numeroArray] / valorDicionario))
                        count += dict[valorDicionario] * dict[arr[numeroArray] / valorDicionario];
                }
                dict.Add(arr[numeroArray], count);
            }

            long sum = 0;
            foreach (var v in dict.Values)
                sum = (sum + v) % mod;

            return (int)sum;
        }
    }
}

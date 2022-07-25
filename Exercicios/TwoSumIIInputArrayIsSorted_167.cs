using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class TwoSumIIInputArrayIsSorted_167
    {
        public static int[] Solucao(int[] numbers, int target)
        {
            if (numbers.Length == 2)
                return new int[] { 1, 2 };

            for (int i = 0; i < numbers.Length;)
            {
                for (int a = numbers.Length - 1; a > i;)
                {
                    if (numbers[i] + numbers[a] == target)
                        return new int[] { i + 1, a + 1 };

                    else if (numbers[i] + numbers[a] > target)
                        a--;

                    else
                        i++;
                }
            }

            return numbers;
        }
    }
}

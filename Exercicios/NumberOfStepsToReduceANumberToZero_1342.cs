using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class NumberOfStepsToReduceANumberToZero_1342
    {
        public static int Solucao(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;

                else
                    num -= 1;

                steps++;
            }

            return steps;
        }
    }
}

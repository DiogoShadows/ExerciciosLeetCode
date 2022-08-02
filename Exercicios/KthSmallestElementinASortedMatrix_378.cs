using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class KthSmallestElementinASortedMatrix_378
    {
        public static int Solucao(int[][] matrix, int k)
        {
            int[] numeros = new int[0];

            for(int i = 0; i < matrix.Length; i++)
            {
               numeros = numeros.Concat(matrix[i]).ToArray();
            }

            numeros = numeros.OrderBy(x => x).ToArray();
            return numeros[k - 1];
        }
    }
}

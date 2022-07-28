using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class TheKWeakestRowsInAMatrix_1337
    {
        public static int[] Solucao(int[][] mat, int k)
        {
            List<string> rows = new List<string>();
            for (int i = 0; i < mat.Length; i++)
            {
                int contagem = 0;
                for (int a = 0; a < mat[i].Length; a++)
                {
                    contagem += mat[i][a];
                }

                rows.Add($"{i}|{contagem}");
            }

            var rowsArray = rows.OrderBy(x => Int32.Parse(x.Split("|")[1])).Select(x => Int32.Parse(x.Split("|")[0])).ToArray();
            int[] resultado = new int[k];
            Array.Copy(rowsArray, resultado, k);

            return resultado;
        }
    }
}

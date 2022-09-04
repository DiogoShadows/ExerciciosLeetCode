using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class NumberofIslands_200
    {
        public static char[][] matrix { get; set; }

        public static int Solucao(char[][] grid)
        {
            int total = 0;
            matrix = grid;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int a = 0; a < grid[i].Length; a++)
                {
                    if (matrix[i][a] == '1')
                    {
                        total++;
                        Recursao(a, i);
                    }    
                }
            }

            return total;
        }

        public static void Recursao(int coluna, int fileira)
        {
            if (coluna == -1 || fileira == -1 || fileira >= matrix.Length || coluna >= matrix[0].Length || matrix[fileira][coluna] == '0')
                return;

            matrix[fileira][coluna] = '0';
            Recursao(coluna + 1, fileira);
            Recursao(coluna - 1, fileira);
            Recursao(coluna, fileira + 1);
            Recursao(coluna, fileira - 1);
        }
    }
}

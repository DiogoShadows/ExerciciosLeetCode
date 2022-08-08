using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class UniquePaths_62
    {
        public static int Solucao(int m, int n)
        {
            int[,] grid = new int[m, n];
            for(int fileira = m - 1; fileira >= 0; fileira--)
            {
                for(int coluna = n - 1; coluna >= 0; coluna--)
                {
                    if (coluna + 1 == n || fileira + 1 == m)
                        grid[fileira, coluna] = 1;

                    else
                        grid[fileira, coluna] = grid[fileira + 1, coluna] + grid[fileira, coluna + 1];
                }
            }

            return grid[0, 0];
        }
    }
}

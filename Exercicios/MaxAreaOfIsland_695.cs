using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaxAreaOfIsland_695
    {
        public static int[][] gridStatic { get; set; }
        public static int Solucao(int[][] grid)
        {
            gridStatic = grid;
            int total = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int a = 0; a < grid[i].Length; a++)
                {
                    total = Math.Max(total, Contagem(i, a));
                }
            }

            return total;
        }

        public static int Contagem(int eixoX, int eixoY)
        {
            if (eixoX >= gridStatic.Length || eixoY >= gridStatic[0].Length || eixoX < 0 || eixoY < 0 || gridStatic[eixoX][eixoY] == 0)
                return 0;

            gridStatic[eixoX][eixoY] = 0;
            return (1 + Contagem(eixoX + 1, eixoY) + Contagem(eixoX - 1, eixoY) + Contagem(eixoX, eixoY - 1) + Contagem(eixoX, eixoY + 1));
        }
    }
}

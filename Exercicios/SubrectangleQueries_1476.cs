using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class SubrectangleQueries_1476
    {
        public int[][] matrix { get; set; }

        public SubrectangleQueries_1476(int[][] rectangle)
        {
            matrix = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for(int i = row1; i <= row2; i++)
            {
                for(int a = col1; a <= col2; a++)
                {
                    matrix[i][a] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return matrix[row][col];
        }
    }
}

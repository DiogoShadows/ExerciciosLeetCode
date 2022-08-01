using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FloodFill_733
    {
        public static int[][] Solucao(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color) return image;
            Preencher(image, sr, sc, image[sr][sc], color);
            return image;
        }

        private static void Preencher(int[][] image, int sr, int sc, int color, int newColor)
        {
            if (sr < 0 || sr >= image.Count() || sc < 0 || sc >= image[0].Count() || image[sr][sc] != color) return;

            image[sr][sc] = newColor;
            Preencher(image, sr + 1, sc, color, newColor);
            Preencher(image, sr - 1, sc, color, newColor);
            Preencher(image, sr, sc + 1, color, newColor);
            Preencher(image, sr, sc - 1, color, newColor);
        }
    }
}

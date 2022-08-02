using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] entrada = new int[][] { new int[] { 1, 5, 9 }, new int[] { 10, 11, 13 }, new int[] { 12, 13, 15 }, };
            int[][] entrada2 = new int[][] { new int[] { -5 } };
            Console.WriteLine(KthSmallestElementinASortedMatrix_378.Solucao(entrada, 8));
        }
    }
}
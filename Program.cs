using ExerciciosLeetCode.Exercicios;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] teste = new int[][] 
            { new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, 
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 0,1,1,0,1,0,0,0,0,0,0,0,0 },
            new int[] { 0,1,0,0,1,1,0,0,1,0,1,0,0},
            new int[] { 0,1,0,0,1,1,0,0,1,1,1,0,0 },
            new int[] { 0,0,0,0,0,0,0,0,0,0,1,0,0 },
            new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
            new int[] { 0,0,0,0,0,0,0,1,1,0,0,0,0 },};

            Console.WriteLine(MaxAreaOfIsland_695.Solucao(teste));
        }
    }
}
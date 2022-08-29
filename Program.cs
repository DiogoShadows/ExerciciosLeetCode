using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] c = new char[][] { new char[] { '1', '0', '1', '1', '0', '1', '1' } };
            char[][] b = new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' } };
            char[][] a = new char[][] { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' } };
            Console.WriteLine(NumberofIslands_200.Solucao(c));
        }
    }
}
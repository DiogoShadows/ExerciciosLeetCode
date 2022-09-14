using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            Console.WriteLine(CheckiftheSentenceIsPangram_1832.Solucao(""));
        }
    }
}
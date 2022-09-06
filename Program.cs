using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(1);
            root.left = new TreeNode(0);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(0);
            root.right.right = new TreeNode(1);
            root.right.left = new TreeNode(0);

            Console.WriteLine(BinaryTreePruning_814.Solucao(root));
        }
    }
}
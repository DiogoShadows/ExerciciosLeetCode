using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);

            Console.WriteLine(MaximumNumberofWordsFoundinSentences_2114.Solucao(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much"}));
        }
    }
}
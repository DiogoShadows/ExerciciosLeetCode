using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class BinaryTreePreorderTraversal_144
    {
        public static List<int> listNodes = new List<int>();
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            listNodes = new List<int>();
            Recursion(root);
            return listNodes;
        }

        public static void Recursion(TreeNode node)
        {
            if (node == null)
                return;

            listNodes.Add(node.val);

            Recursion(node.left);
            Recursion(node.right);
        }
    }
}

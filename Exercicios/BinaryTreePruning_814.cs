using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class BinaryTreePruning_814
    {
        public static TreeNode Solucao(TreeNode root)
        {
            Recursao(root);

            if (root.val == 0 && root.left == null && root.right == null)
                return null;

            return root;
        }

        public static bool Recursao(TreeNode atual)
        {
            if (atual == null)
                return true;

            bool esquerdaZero = Recursao(atual.left);

            if (esquerdaZero)
                atual.left = null;

            bool direitaZero = Recursao(atual.right);

            if (direitaZero)
                atual.right = null;

            return atual.val == 0 && esquerdaZero && direitaZero;
        }
    }
}

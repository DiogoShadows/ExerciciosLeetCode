using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class LowestCommonAncestorofaBinarySearchTree_235
    {
        public static TreeNode Solucao(TreeNode root, TreeNode p, TreeNode q)
        {
            return Recursao(root, p, q);
        }

        public static TreeNode? Recursao(TreeNode atual, TreeNode p, TreeNode q)
        {
            if (atual == p || atual == q || atual == null)
                return atual;

            var direita = Recursao(atual.right, p, q);
            var esquerda = Recursao(atual.left, p, q);

            if (direita != null && esquerda != null)
                return atual;

            else if (esquerda != null)
                return esquerda;

            else if (direita != null)
                return direita;

            return null;
        }
    }
}

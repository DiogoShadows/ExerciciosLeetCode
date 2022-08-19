using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaximumBinaryTree_654
    {
        public static TreeNode Solucao(int[] nums)
        {
            int nodeMaximo = nums.Max();
            TreeNode primeiroNode = new TreeNode(nodeMaximo);

            _ = NodesRecursivos(primeiroNode, nums);

            return primeiroNode;
        }

        public static TreeNode NodesRecursivos(TreeNode nodeAtual, int[] nums)
        {
            if (nodeAtual.val == -99)
                return null;

            var direita = nums.Skip(Array.IndexOf(nums, nodeAtual.val) + 1).ToArray();
            var esquerda = nums.Take(Array.IndexOf(nums, nodeAtual.val)).ToArray();
            var nodeDireita = direita.Count() == 0? new TreeNode(-99) : new TreeNode(direita.Max());
            var nodeEsquerda = esquerda.Count() == 0 ? new TreeNode(-99) : new TreeNode(esquerda.Max());

            nodeAtual.right = NodesRecursivos(nodeDireita, direita);
            nodeAtual.left = NodesRecursivos(nodeEsquerda, esquerda);

            return nodeAtual;
        }
    }
}

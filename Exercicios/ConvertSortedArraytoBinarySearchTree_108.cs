using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class ConvertSortedArraytoBinarySearchTree_108
    {
        public static TreeNode Solucao(int[] nums)
        {
            var atual = new TreeNode();
            Recursividade(nums, atual);

            return atual;
        }

        public static void Recursividade(int[] nums, TreeNode atual)
        {
            int meio = nums.Length / 2;
            atual.val = nums[meio];
            var esquerda = nums.Take(meio).ToArray();
            var direita = nums.Skip(meio + 1).ToArray();

            if(esquerda.Length > 0)
                Recursividade(esquerda, atual.left = new TreeNode());

            if(direita.Length > 0)
                Recursividade(direita, atual.right = new TreeNode());

            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class BinaryTreeInorderTraversal_94
    {
        public static List<int> lista { get; set; }

        public static IList<int> Solucao(TreeNode root)
        {
            lista = new List<int>();
            Recursao(root);
            return lista;
        }

        public static void Recursao(TreeNode atual)
        {
            if (atual == null)
                return;

            Recursao(atual.left);
            lista.Add(atual.val);
            Recursao(atual.right);
        }
    }
}

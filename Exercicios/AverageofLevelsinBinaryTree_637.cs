using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode.Exercicios
{
    public class AverageofLevelsinBinaryTree_637
    {
        public static List<List<double>> niveis = new List<List<double>>();

        public static IList<double> Solucao(TreeNode root)
        {
            Recursao(0, root);

            var resposta = new List<double>();

            foreach (var nivel in niveis)
                resposta.Add(nivel[1] / nivel[0]);

            return resposta;
        }

        public static void Recursao(int nivel, TreeNode atual)
        {
            if (atual == null)
                return;

            if (niveis.Count() < nivel + 1)
            {
                List<double> list = new List<double>();
                list.Add(1);
                list.Add(atual.val);

                niveis.Add(list);
            }

            else
            {
                niveis[nivel][0]++;
                niveis[nivel][1] += atual.val;
            }

            Recursao(nivel + 1, atual.right);
            Recursao(nivel + 1, atual.left);
        }
    }
}

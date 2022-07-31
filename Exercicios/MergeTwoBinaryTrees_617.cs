using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MergeTwoBinaryTrees_617
    {
        public static TreeNode Solucao(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;

            if (root2 == null)
                return root1;

            root1.val += root2.val;
            root1.left = Solucao(root1.left, root2.left);
            root1.right = Solucao(root1.right, root2.right);

            return root1;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}

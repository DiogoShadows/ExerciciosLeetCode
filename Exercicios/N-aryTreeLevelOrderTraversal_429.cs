using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciciosLeetCode.Exercicios
{
    public class N_aryTreeLevelOrderTraversal_429
    {
        public static IList<IList<int>> listaFinal = new List<IList<int>>();

        public static IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null)
                return listaFinal;

            listaFinal.Add(new List<int> { root.val });
            Recursao(root.children, 1);

            return listaFinal;
        }

        public static void Recursao(IList<Node> nodes, int nivel)
        {
            if (nodes == null)
                return;
            
            foreach(var node in nodes)
            {
                if (listaFinal.Count > nivel)
                    listaFinal[nivel].Add(node.val);

                else
                    listaFinal.Add(new List<int> { node.val });

                Recursao(node.children, nivel + 1);
            }
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}

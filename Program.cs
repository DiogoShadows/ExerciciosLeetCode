using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            Node um = new Node(3);
            Node dois = new Node(2);
            Node tres = new Node(4);
            Node quatro = new Node(5);
            Node cinco = new Node(6);
            List<Node> lista = new List<Node> { um, dois, tres };
            root.children = lista;
            lista = new List<Node> { quatro, cinco };
            um.children = lista;

            Console.WriteLine(N_aryTreeLevelOrderTraversal_429.LevelOrder(root));
        }
    }
}
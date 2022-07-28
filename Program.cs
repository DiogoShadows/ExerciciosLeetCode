using ExerciciosLeetCode.Exercicios;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] teste = { 1};
            ListNode lista = PalindromeLinkedList_234.MontarListNode(teste);

            Console.WriteLine(RemoveNthNodeFromEndOfList_19.Solucao(lista, 1));
        }
    }
}
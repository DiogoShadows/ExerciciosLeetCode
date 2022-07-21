using ExerciciosLeetCode.Exercicios;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] teste = { 1,2,3,4,5 };
            ListNode lista = PalindromeLinkedList_234.MontarListNode(teste);

            Console.WriteLine(MiddleOfTheLinkedList_876.Solucao(lista));
        }
    }
}
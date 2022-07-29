using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class PalindromeLinkedList_234
    {
        public static ListNode MontarListNode(int[] lista)
        {
            var head = new ListNode(lista[0]);
            var atual = head;

            for (int i = 1; i < lista.Length; i++)
            {
                var proximo = new ListNode(lista[i]);
                atual.next = proximo;
                atual = proximo;
            }

            return head;
        }

        public static bool Solucao(ListNode head)
        {
            List<int> numeros = new List<int>();

            var atual = head;
            int quantidade = 0;

            while(atual != null)
            {
                numeros.Add(atual.val);
                atual = atual.next;
                quantidade++;
            }

            if (numeros.Count == 1)
                return true;

            int metade = quantidade / 2;
            var primeiraMetade = numeros.Skip(0).Take(metade);
            var segundaMetade = quantidade % 2 != 0 ? numeros.Skip(metade + 1).Take(quantidade).Reverse() : numeros.Skip(metade).Take(quantidade).Reverse();

            return primeiraMetade.SequenceEqual(segundaMetade);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

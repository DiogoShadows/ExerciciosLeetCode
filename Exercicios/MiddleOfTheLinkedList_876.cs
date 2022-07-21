using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MiddleOfTheLinkedList_876
    {
        public static ListNode Solucao(ListNode head)
        {
            int quantidade = 0;
            var atual = head;

            while (atual != null)
            {
                atual = atual.next;
                quantidade++;
            }

            int metade = quantidade / 2 + 1;
            atual = head;
            quantidade = 1;

            while (atual != null)
            {
                if (quantidade == metade)
                    return atual;

                quantidade++;
                atual = atual.next;
            }

            return head;
        }
    }
}

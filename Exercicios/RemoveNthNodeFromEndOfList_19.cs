using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RemoveNthNodeFromEndOfList_19
    {
        public static ListNode Solucao(ListNode head, int n)
        {
            var atual = head;
            int contador = n;
            var delay = head;

            while(atual != null)
            {
                if (contador < 0)
                    delay = delay?.next;

                atual = atual.next;
                contador--;
            }

            if (contador == 0)
                head = head.next;

            else
                delay.next = delay?.next?.next;

            return head;
        }
    }
}

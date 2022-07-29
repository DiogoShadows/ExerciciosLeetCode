using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RichestCustomerWealth_1672
    {
        public static int Solucao(int[][] accounts)
        {
            var maior = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var atual = accounts[i].Sum(x => x);

                if (atual >= maior)
                    maior = atual;
            }

            return maior;
        }
    }
}

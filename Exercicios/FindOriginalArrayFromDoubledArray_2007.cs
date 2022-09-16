using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FindOriginalArrayFromDoubledArray_2007
    {
        public static int[] Solucao(int[] changed)
        {
            List<int> lista = changed.OrderBy(x => x).ToList();
            List<int> resposta = new List<int>();

            while (lista.Count > 0)
            {
                var valor = lista.First();
                lista.Remove(valor);
                var dobro = lista.Cast<int?>().FirstOrDefault(x => x == valor * 2);

                if (dobro == null)
                    return new int[] { };

                resposta.Add(valor);
                lista.Remove(dobro ?? 0);
            }

            return resposta.ToArray();
        }
    }
}

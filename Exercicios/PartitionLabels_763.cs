using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class PartitionLabels_763
    {
        public static IList<int> Solucao(string s)
        {
            var letras = s.ToArray();
            List<int[] > stringsAdicionadas = new List<int[]>();
            int[] ocorrenciaItem = new int[2];

            for(int i = 0; i < letras.Length; i++)
            {
                var last = s.LastIndexOf(letras[i]) + 1;

                if (i == 0)
                {
                    ocorrenciaItem[0] = i;
                    ocorrenciaItem[1] = last;
                    stringsAdicionadas.Add(ocorrenciaItem);

                    ocorrenciaItem = new int[2];
                }

                else if ( stringsAdicionadas.Last()[1] <= i)
                {
                    ocorrenciaItem[0] = i;
                    ocorrenciaItem[1] = last;
                    stringsAdicionadas.Add(ocorrenciaItem);

                    ocorrenciaItem = new int[2];
                }

                else if(last > stringsAdicionadas.Last()[1])
                {
                    stringsAdicionadas.Last()[1] = last;
                }

                if (last >= letras.Length)
                    break;
            }

            List<int> final = new List<int>();

            foreach(var item in stringsAdicionadas)
            {
                final.Add(item[1] - item[0]);
            }

            return final;
        }
    }
}

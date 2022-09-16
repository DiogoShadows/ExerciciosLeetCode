using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class LongerContiguousSegmentsofOnesthanZeros_1869
    {
        public static bool Solucao(string s)
        {
            int sequenciaZero = 0, sequenciaUm = 0, maiorSequenciaUm = 0, maiorSequenciaZero = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    sequenciaUm++;
                    maiorSequenciaUm = Math.Max(sequenciaUm, maiorSequenciaUm);
                    sequenciaZero = 0;
                }

                else
                {
                    sequenciaZero++;
                    maiorSequenciaZero = Math.Max(sequenciaZero, maiorSequenciaZero);
                    sequenciaUm = 0;
                }
            }

            return maiorSequenciaUm > maiorSequenciaZero;
        }
    }
}

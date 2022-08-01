using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class LongestSubstringWithoutRepeatingCharacters_3
    {
        public static int Solucao(string s)
        {
            string maior = "";
            string comparacao = "";

            for(int i = 0; i < s.Length; i++)
            {
                for(int a = i; a < s.Length; a++)
                {
                    if (!comparacao.Contains(s[a]))
                        comparacao += s[a];

                    else
                        break;
                }

                if (comparacao.Length > maior.Length)
                    maior = comparacao;

                comparacao = "";
            };

            return maior.Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FindFirstPalindromicStringIntheArray_2108
    {
        public static string Solucao(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                string palavra = words[i];

                if (palavra == String.Concat(palavra.Reverse()))
                    return palavra;
            }

            return "";
        }
    }
}

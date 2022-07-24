using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class ReverseWordsInAStringIII_557
    {
        public static string Solucao(string s)
        {
            string resposta = "";
            var words = s.Split(" ");

            for(int i = 0; i < words.Length; i++)
            {
                resposta += new string(words[i].Reverse().ToArray()) + " ";
            }

            return resposta.Trim();
        }
    }
}

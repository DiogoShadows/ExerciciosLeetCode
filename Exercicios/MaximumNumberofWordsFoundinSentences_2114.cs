using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaximumNumberofWordsFoundinSentences_2114
    {
        public static int Solucao(string[] sentences)
        {
            int maior = 0;
            for(int i = 0; i < sentences.Length; i++)
            {
                maior = Math.Max(maior, sentences[i].Split(" ").Count());
            }

            return maior;
        }
    }
}

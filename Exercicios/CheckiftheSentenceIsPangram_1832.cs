using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class CheckiftheSentenceIsPangram_1832
    {
        public static bool Solucao(string sentence)
        {
            List<char> alfabeto = new List<char>{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach(char c in alfabeto)
            {
                if(!sentence.Contains(c))
                    return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RemoveAllAdjacentDuplicatesInString_1047
    {
        public static string Solucao(string s)
        {
            for(int i = 0; i < s.Length;)
            {
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);

                    if(i - 1 >= 0)
                        i--;
                }

                else
                    i++;
            }

            return s;
        }
    }
}

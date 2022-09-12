using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class TheNumberofWeakCharactersintheGame_1996
    {
        public static int Solucao(int[][] properties)
        {
            int resposta = 0;
            properties = properties.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

            for(int i = 0; i < properties.Length; i++)
            {
                for(int a = i; a < properties.Length; a++)
                {
                    if (properties[i][0] != properties[a][0] && properties[i][1] < properties[a][1])
                    {
                        resposta++;
                        break;
                    }
                }
            }

            return resposta;
        }
    }
}

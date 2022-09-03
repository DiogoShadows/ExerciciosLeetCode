using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FindtheHighestAltitude_1732
    {
        public static int Solucao(int[] gain)
        {
            int altitude = 0, max = 0;

            for(int i = 0; i < gain.Length; i++)
            {
                altitude += gain[i];
                max = Math.Max(altitude, max);
            }

            return max;
        }
    }
}

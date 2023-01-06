using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MaximumIceCreamBars_1833
    {
        public static int Solution(int[] costs, int coins)
        {
            var index = 0;
            var dictItens = costs.OrderBy(x => x).ToDictionary(x => index++, x => x);
            int total = 0;

            for(int i = 0; i < dictItens.Count(); i++)
            {
                coins -= dictItens[i];

                if (coins < 0)
                    return total;

                total++;
            }

            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class PerfectSquares_279
    {
        public static int Solucao(int n)
        {
            int i = 1;
            int quadrado = 1;

            Dictionary<int, int> quadrados = new Dictionary<int, int>();

            while(quadrado <= n)
            {
                quadrados.Add(quadrado, quadrado);
                i++;
                quadrado = i * i;
            }

            if (quadrados.ContainsKey(n))
                return 1;

            foreach(var item in quadrados)
            {
                if (quadrados.ContainsKey(n - item.Key))
                    return 2;
            }

            foreach(var item in quadrados)
            {
                foreach(var item2 in quadrados)
                {
                    if (quadrados.ContainsKey(n - item.Key - item2.Key))
                        return 3;
                }
            }

            return 4;
        }
    }
}

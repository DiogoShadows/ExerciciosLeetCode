using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class Thek_thLexicographicalStringofAllHappyStringsofLengthn_1415
    {
        public static List<string> listando = new List<string>();

        public static string Solucao(int n, int k)
        {
            Recursivo("", n);

            if (k <= listando.Count())
                return listando[k - 1];

            return "";
        }

        public static void Recursivo(string atual, int total)
        {
            if (atual.Count() == total)
            {
                listando.Add(atual);
                return;
            }

            if (atual.Count() == 0 || atual[atual.Count() - 1] != 'a')
                Recursivo(atual + 'a', total);

            if (atual.Count() == 0 || atual[atual.Count() - 1] != 'b')
                    Recursivo(atual + 'b', total);

            if (atual.Count() == 0 || atual[atual.Count() - 1] != 'c')
                    Recursivo(atual + 'c', total);
        }
    }
}

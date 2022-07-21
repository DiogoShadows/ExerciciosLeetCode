using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class FizzBuzz_412
    {
        public static IList<string> Solucao(int n)
        {
            IList<string> lista = new List<string>();

            const string FIZZ = "Fizz";
            const string BUZZ = "Buzz";

            for(int i = 1; i <= n; i++)
            {
                bool divisivelPorTres = i % 3 == 0;
                bool divisivelPorCinco = i % 5 == 0;
                string adicionar = "";

                if (divisivelPorTres)
                    adicionar = FIZZ;

                if (divisivelPorCinco)
                    adicionar += BUZZ;

                lista.Add(string.IsNullOrEmpty(adicionar) ? i.ToString() : adicionar);
            }

            return lista;
        }
    }
}

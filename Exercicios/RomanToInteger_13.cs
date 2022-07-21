using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RomanToInteger_13
    {
        public static int Solucao(string s)
        {
            Dictionary<string, int> numerosRomanos = new Dictionary<string, int>()
            {
                { "M", 1000 },
                { "D", 500 },
                { "C", 100 },
                { "L", 50 },
                { "X", 10 },
                { "V", 5 },
                { "I", 1 },
            };

            int valorFinal = 0;

            for(int iterador = 0; iterador < s.Length; iterador++)
            {
                string digitoRomano = s[iterador].ToString();
                int numero = numerosRomanos[digitoRomano];
                int numeroAnterior = iterador > 0 ? numerosRomanos[s[iterador - 1].ToString()] : 0;

                //Se o digito for maior que o digito anterior
                if (numeroAnterior > 0 && numero > numeroAnterior)
                    valorFinal += numero - (numeroAnterior * 2);

                else
                    valorFinal += numero;
            }

            return valorFinal;
        }
    }
}

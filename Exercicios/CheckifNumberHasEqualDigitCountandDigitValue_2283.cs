using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class CheckifNumberHasEqualDigitCountandDigitValue_2283
    {
        public static bool Solucao(string num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                var a = i.ToString();
                var total = num.Count(x => x.ToString().Equals(a));

                if (!(total == Int32.Parse(num[i].ToString())))
                    return false;
            }

            return true;
        }
    }
}

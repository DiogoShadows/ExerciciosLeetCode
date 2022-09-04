using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class PowerofThree_326
    {
        public static bool Solucao(int n)
        {
            if (n == 0)
                return false;

            decimal a = n;

            while(a % 1 == 0)
            {
                if (a == 1)
                    return true;

                a /= 3;
            }

            return false;
        }
    }
}

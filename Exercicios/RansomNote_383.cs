using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class RansomNote_383
    {
        public static bool Solucao(string ransomNote, string magazine)
        {
            foreach(var letter in ransomNote)
            {
                if (magazine.Contains(letter))
                    magazine = magazine.Remove(magazine.IndexOf(letter), 1);

                else
                    return false;
            }

            return true;
        }
    }
}

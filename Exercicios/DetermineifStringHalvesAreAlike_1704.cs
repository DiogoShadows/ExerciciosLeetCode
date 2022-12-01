using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class DetermineifStringHalvesAreAlike_1704
    {
        public static bool Solution(string s)
        {
            char[] vows = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Dictionary<char, char> dicVows = new Dictionary<char, char>
            {
                {'a','a'  },
                {'e', 'e' },
                {'i', 'i' },
                {'o','o'  },
                {'u', 'u' },
            };

            int mid = s.Count() / 2;
            int countVows = 0;
            s = s.ToLower();

            for (int i = 0; i < s.Count(); i++)
            {
                if (dicVows.ContainsKey(s[i]))
                {
                    if (i >= mid)
                        countVows--;

                    else
                        countVows++;
                }
            }

            return countVows == 0;
        }
    }
}

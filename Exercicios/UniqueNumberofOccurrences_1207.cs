using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class UniqueNumberofOccurrences_1207
    {
        public static bool Solucao(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(!dic.TryAdd(arr[i], 1))
                    dic[arr[i]]++;
            }

            if (dic.GroupBy(x => x.Value).Count() != dic.Count())
                return false;

            return true;
        }
    }
}

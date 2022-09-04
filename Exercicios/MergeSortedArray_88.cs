using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MergeSortedArray_88
    {
        public static void Solucao(int[] nums1, int m, int[] nums2, int n)
        {
            var aux = nums1.Concat(nums2).OrderBy(x => x).ToList();

            for(int i = 1; i <= nums1.Length - m; i++)
            {
                aux.Remove(aux.FirstOrDefault(x => x == 0));
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = aux[i];
            }
        }
    }
}

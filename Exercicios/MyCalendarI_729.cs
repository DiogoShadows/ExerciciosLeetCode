using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MyCalendarI_729
    {
        public MyCalendarI_729()
        {
            Calendario = new List<int[]>();
        }

        private List<int[]> Calendario { get; set; }

        public bool Book(int start, int end)
        {
            foreach(var item in Calendario)
            {
                if (item[0] < end && start < item[1])
                    return false;
            }

            Calendario.Add(new int[] {start, end});
            return true;
        }
    }
}

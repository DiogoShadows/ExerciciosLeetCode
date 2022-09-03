using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class DesignBrowserHistory_1472
    {
        private string Homepage { get; set; }
        private List<string> Historico = new List<string>();
        private int PaginaAtual { get; set; }

        public DesignBrowserHistory_1472(string homepage)
        {
            Homepage = homepage;
            Historico.Add(homepage);
        }

        public void Visit(string url)
        {
            if(PaginaAtual < Historico.Count() -1)
                Historico.RemoveRange(PaginaAtual + 1, Historico.Count() - 1 - PaginaAtual);

            Historico.Add(url);
            PaginaAtual++;
        }

        public string Back(int steps)
        {
            if(PaginaAtual - steps <= 0)
            {
                PaginaAtual = 0;
                return Historico[0];
            }

            PaginaAtual -= steps;
            return Historico[PaginaAtual];
        }

        public string Forward(int steps)
        {
            if(steps + PaginaAtual > Historico.Count() - 1)
            {
                PaginaAtual = Historico.Count() - 1;
                return Historico[PaginaAtual];
            }

            PaginaAtual += steps;
            return Historico[PaginaAtual];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class MirrorReflection_858
    {
        public static int Solucao(int p, int q)
        {
            int altura = 0;
            bool subindo = true, ladoDireito = true;

            while (true)
            {
                if (subindo)
                {
                    altura += q;

                    if(altura > p)
                    {
                        altura = p - (altura - p);
                        subindo = false;
                    }    
                }

                else
                {
                    altura -= q;

                    if(altura < 0)
                    {
                        altura = altura * -1;
                        subindo = true;
                    }
                }

                if (altura == 0)
                    return 0;

                else if (altura == p)
                {
                    if (ladoDireito)
                        return 1;

                    else
                        return 2;
                }

                ladoDireito = !ladoDireito;
            }
        }
    }
}

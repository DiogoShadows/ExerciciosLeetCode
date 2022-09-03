using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeetCode.Exercicios
{
    public class WalkingRobotSimulation_874
    {
        public static int Solucao(int[] commands, int[][] obstacles)
        {
            int fileira = 0, coluna = 0, direcaoAtual = 0, maximum = 0;
            string[] direcao = new string[] { "norte", "leste", "sul", "oeste"};
            var hashSet = new HashSet<string>(obstacles.Select(o => o[0] + ":" + o[1]));

            for(int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == -2)
                {
                    direcaoAtual--;

                    if (direcaoAtual < 0)
                        direcaoAtual = 3;
                }

                else if (commands[i] == -1)
                {
                    direcaoAtual++;

                    if (direcaoAtual > 3)
                        direcaoAtual = 0;
                }

                else
                {
                    for(int a = 1; a <= commands[i]; a++)
                    {
                        var colunaAux = coluna;
                        var fileiraAux = fileira;

                        if (direcaoAtual == 0)
                            colunaAux++;

                        else if (direcaoAtual == 1)
                            fileiraAux++;

                        else if (direcaoAtual == 2)
                            colunaAux--;

                        else
                            fileiraAux--;

                        if (hashSet.Contains(fileiraAux + ":" + colunaAux))
                            break;

                        fileira = fileiraAux;
                        coluna = colunaAux;
                    }

                    maximum = Math.Max(maximum, coluna * coluna + fileira * fileira);
                }
            }

            return maximum;
        }
    }
}

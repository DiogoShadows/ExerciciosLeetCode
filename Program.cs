using ExerciciosLeetCode.Exercicios;
using static ExerciciosLeetCode.Exercicios.MergeTwoBinaryTrees_617;

namespace ExerciciosLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new DesignBrowserHistory_1472("1");
            a.Visit("2");
            a.Visit("3");
            Console.WriteLine(a.Back(9));
            a.Visit("4");
            Console.WriteLine(a.Forward(7));
            a.Visit("5");
            a.Visit("6");
            Console.WriteLine(a.Forward(5));
            a.Visit("7");
            Console.WriteLine(a.Back(10));
            a.Visit("8");
            a.Visit("9");
            Console.WriteLine(a.Forward(10));
        }
    }
}
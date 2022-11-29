
namespace ExerciciosLeetCode.Exercicios
{
    public class InsertDeleteGetRandomO_1__380
    {
        private static Dictionary<int, int> DicionaryNumbers;
        private static Random RandomGenerator; 

        public InsertDeleteGetRandomO_1__380()
        {
            DicionaryNumbers = new Dictionary<int, int>();
            RandomGenerator = new Random();
        }

        public bool Insert(int val)
        {
            if (DicionaryNumbers.ContainsKey(val))
                return false;

            DicionaryNumbers.Add(val, val);
            return true;
        }

        public bool Remove(int val) => DicionaryNumbers.Remove(val);

        public int GetRandom() => DicionaryNumbers.ElementAt(RandomGenerator.Next(DicionaryNumbers.Count())).Key;
    }
}

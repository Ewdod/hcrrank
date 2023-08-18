namespace hcrrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int> { 6,1,3,2,3,4,1 };

            //List<string> results = Result.bitPattern(numbers);

            //foreach (var result in Result.bitPattern(numbers))
            //{
            //    Console.Write(result);
            //}

            List<int> prices = new List<int> { 2, 3, 5, 8, 10 };
            List<int> pos = new List<int> { 2, 3 };
            List<long> amount = new List<long> { 10, 7 };

            List<int> results = Topla.findMaximumValue(prices, pos, amount);

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}
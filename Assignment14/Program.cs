namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNum = list.Where(n => n % 2 == 0);
            foreach (var n in oddNum)
            {
                Console.WriteLine(n);
            }
            list.AddRange([11, 12, 13, 14, 15]);
            Console.WriteLine("========");
            foreach (var n in oddNum)
            {
                Console.WriteLine(n);
            }
        }
    }
}

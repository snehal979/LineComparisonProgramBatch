namespace LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Program");
            CalculateLeght calculateLeght = new CalculateLeght(1, 4, 2, 8);
            calculateLeght.LenghtOfLine();
            Console.ReadLine();
        }
    }
}
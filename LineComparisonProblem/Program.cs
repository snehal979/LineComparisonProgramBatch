namespace LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Program");
            //For Line 1 Object
            CalculateLeght calculateLeght_1 = new CalculateLeght(1, 4, 2, 8);
            double Line_1 = calculateLeght_1.LenghtOfLine();
            Console.WriteLine("Lenght of First line = "+Line_1);
            //For Line 2 Object
            CalculateLeght calculateLeght_2 = new CalculateLeght(5, 4, 2, 8);
            double Line_2 = calculateLeght_2.LenghtOfLine();
            Console.WriteLine("Lenght of Second line = "+Line_2);

            //Uc 2  Equal method(given boolen condition)
            if(Line_1.Equals(Line_2))
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else
            {
                Console.WriteLine("Not Both Line Are Equal");
            }

        }
    }
}
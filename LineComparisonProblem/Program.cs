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
            CalculateLeght calculateLeght_2 = new CalculateLeght(5, 9, 9, 8);
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
                // To check which Line is greater By CompareTo Method
                if (Line_1.CompareTo(Line_2) > 0)
                {
                    Console.WriteLine("Line 1 is Greater to Line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is Less than Line 2");
                }
            }

            Console.ReadLine();
        }
    }  
}
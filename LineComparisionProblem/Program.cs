namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison");

            int x1, y1, x2, y2;

            Console.WriteLine("\nEnter x1 co-oridinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 co-oridinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter x2 co-oridinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 co-oridinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\n length of the line is {lengthOfLine}");

        }
    }
}
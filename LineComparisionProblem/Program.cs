namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison Problem");
            Console.WriteLine("\n===========Line1=======\n");

            int x1, y1, x2, y2;

            Console.WriteLine("\nEnter x1 co-ordinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1 co-ordinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter x2 co-ordinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2 co-ordinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\n length of the line is {lengthOfLine1}");


            Console.WriteLine("\n===========Line 2======\n");
            int a1, b1, a2, b2;
            Console.WriteLine("Enter a1 co-ordinate: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b1 co-ordinate: "  );
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a2 co-ordinate: ");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b2 co-ordinate: " );
            b2 = Convert.ToInt32(Console.ReadLine());

            double lengthofLine2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine($"\nLength of the Line is {lengthofLine2}");
            if (lengthOfLine1 > lengthofLine2)
            {
                Console.WriteLine("\nThe Line 1 is greater");
            }
            else if (lengthOfLine1 < lengthofLine2)
            {
                Console.WriteLine("\nThe Line 2 is greater");
            }
            else
            {
                Console.WriteLine("\nBoth are Equal");
            }


        }
    }
}
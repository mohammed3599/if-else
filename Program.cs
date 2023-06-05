using System.Transactions;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1; int b = 2; int c = 3;

            //if (a == b || b > a)
            //{
            //    Console.WriteLine("Condition is met");
            //}
            //else if (a == c) 
            //{
            //    Console.WriteLine("Condition is not met");
            //}
            //else
            //{
            //    Console.WriteLine("Condition is not met");
            //}


            Console.Write("Enter a Number to check if it is Positive/Negative or Even/Odd: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0 && num1 % 2 == 0 ) 
            {
                Console.WriteLine("The Number is Positive and Even.");
            }

            else if (num1 > 0 && num1 % 2 != 0)
            {
                Console.WriteLine("The Number is Positive and Odd.");
            }

            else if (num1 < 0 && num1 % 2 == 0)
            {
                Console.WriteLine("The Number is Negative and Even.");
            }

            else
            {
                Console.WriteLine("The Number is Negative and Odd.");
            }


        }
    }
}
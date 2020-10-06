using System;


/* 
 Name: Jamil Matheny
 Date: 10/05/2020
 Class: CIS214
 
 */
namespace Comparison
{
    public class Comparison
    {
        public static void Main(string[] args) //
        {
            int number1; // declare the first number to compare
            int number2; // declare the second number to compare

            // Prompts the user and read the first number
            Console.Write("Enter the first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            // Prompts the user and read the second number
            Console.Write("Enter the second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            // If statements with relational and equality operators.
            if (number1 == number2)
                Console.WriteLine("{0} == {1}", number1, number2);

            if (number1 != number2)
                Console.WriteLine("{0} != {1}", number1, number2);

            if (number1 < number2)
                Console.WriteLine("{0} < {1}", number1, number2);

            if (number1 > number2)
                Console.WriteLine("{0} > {1}", number1, number2);

            if (number1 <= number2)
                Console.WriteLine("{0} <= {1}", number1, number2);

            if (number1 >= number2)
                Console.WriteLine("{0} >= {1}", number1, number2);
        }   //end Main
    } //end class Comparison
}

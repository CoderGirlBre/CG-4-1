using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tells and allows the user to enter a number.
            Console.Write("Enter a number: ");

            //Sets the number the user entered to a variable called value.
          int value = int.Parse(Console.ReadLine());

            //Declaring a new variable and assigning it to an empty bucket for later use.
            int sum = 0;

            //Loop created from 2 to 20 in increments of 1.
            for (int x = 2; x <= 20; x++)
            {
                //Moved into another code block so that this executes after everything else above.

                //Declaring a new variable called output which is the result of mutiplying the number 
                //the user entered by each number in the loop.
                int output = value * x;

                //adds all of the output results and assigns it to the variable sum.
                sum = sum + output;

                //Tells console to print and multiply the number the user entered (int value or {0}) * the number in the loop (int x or {1})
                //and assign it to the output ({2}).
                Console.WriteLine(" {0} * {1} = {2}", value, x, output);
            }
            //Moved into another code block so that this executes after everything else above.

            //Tells the console to print the exact word "Total:" and insert the sum.
            Console.WriteLine("Total: " + sum);
            Console.ReadLine();
        }
    }
}
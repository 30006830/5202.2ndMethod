using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52022ndMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Question 2 of the Exercise*/

            //program explains to the user what the programs purpose is
            //program also asks the user to input a number
            Console.WriteLine("This program converts Miles to Kilometers.");
            Console.WriteLine("Please enter a number regarding Miles: ");

            //takes the input from the user and converts the string to an integer
            //the double total variable is obviously the total
            int miles1 = int.Parse(Console.ReadLine());
            double total = Conversion(miles1);

            //shows the final results of the code being executed (Original Value, Conversion Result, etc.)
            Console.WriteLine("Original Value (In Miles): " + miles1);
            Console.WriteLine("Result (In Kilometers): " + total);
            Console.ReadLine();
        }

        //method used to convert a mile to kilometres
        static double Conversion(int kilometres1)
        {
            return kilometres1 * 1.609;
        }
    }
}

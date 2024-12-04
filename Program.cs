using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Asignment5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "121";
            if (CheckPalindrome.checkPalindrome(s) == true)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }


            //
            //            Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //
            //Test Data:
            //
            //            Enter a number: 1234
            //
            //Expected Output :
            //
            //The sum of the digits of the number 1234 is : 10
           // Console.WriteLine("Give me your number");
           // string numberGiven= Console.ReadLine();
           // Console.WriteLine($"The sum of the digits of the number {numberGiven} is {SumOfArray.sumOfArray( numberGiven)}");
            Console.WriteLine(AppearTwice.FindDouble());
        }
    }
}
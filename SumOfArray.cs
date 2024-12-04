using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Asignment5_1
{
    public class SumOfArray
    {

        public static int sumOfArray( string numberGiven)
        {
            int boxOfNumbers = 0;
            string stringNumbers=numberGiven.ToString();
            for (int i = 0; i < numberGiven.Length; i++)
            {

                boxOfNumbers += Convert.ToInt32(stringNumbers[i].ToString());
                    
                }
                return boxOfNumbers++;
            }
           
    }
}
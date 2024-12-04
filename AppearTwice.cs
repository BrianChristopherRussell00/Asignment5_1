using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asignment5_1
{
    public class AppearTwice
    {
        //        Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        //
        //Example 1:
        //
        //Input: nums = [1, 2, 3, 1]
        //
        //Output: true
        //
        //Example 2:
        //
        //Input: nums = [1, 2, 3, 4]
        //
        //Output: false
        //
        //Example 3:
        //
        //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
        //
        //Output: true
        public static bool FindDouble()
        {
            int count = 0;
            int[] arr = { 1, 1,1,3,3,4,3,2,4,2 };
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "One");
            keyValuePairs.Add(1, "One");
            keyValuePairs.Add(1, "One");
            keyValuePairs.Add(3, "Three");
            keyValuePairs.Add(3, "Three");
            keyValuePairs.Add(4, "Four");
            keyValuePairs.Add(3, "Three");
            keyValuePairs.Add(2, "Two");
            keyValuePairs.Add(4, "Four");
            keyValuePairs.Add(2, "Two");

            foreach (var i in keyValuePairs)
            {
                if (keyValuePairs.ContainsKey(1))
                {
                    count++;
                }
                else if (keyValuePairs.ContainsKey(2))
                {
                    count++;

                }
                else if (keyValuePairs.ContainsKey(3))
                {
                    count++;

                }
                return true;
            }
            return false;
        }
    }
}
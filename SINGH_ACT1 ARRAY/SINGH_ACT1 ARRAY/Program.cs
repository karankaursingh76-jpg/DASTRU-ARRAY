using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGH_ACT1_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singh, Karandeep Kaur D. 
            //Problem: Build a procedural program that will allow the user to store elements into an array and display the elements either 
            //in descending or ascending order. Choose a theme for the elements that you would like your user to input into your array.
            //Consider a minimum of 5 or a maximum of 10 as the size or length of your array. 

            //Declare an array 
            string[] Countries = new string[7];
            {
                //data that will stored by user
                Console.WriteLine("ENTER YOUR 7  FAVORITE COUNTRIES: \n");
                for (int idx = 0; idx < Countries.Length; idx++)
                {
                    Countries[idx] = Console.ReadLine();
                }
                //Arranging the elements
                Array.Reverse(Countries);
                Array.Sort(Countries);

                // showing the array of elements
                Console.WriteLine("\nThe Following List of Countries arranged are in alphabetical order: \n");
                foreach (string c in Countries)
                {
                    Console.WriteLine(c);
                }
                Console.ReadKey();
            }
        }
    }
}
        


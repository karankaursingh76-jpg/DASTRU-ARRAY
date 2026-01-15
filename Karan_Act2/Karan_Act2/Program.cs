using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karan_Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karandeep Kaur D. Singh
            //IT401P
            //Single Dimensional Array of Objcets in OOP

            //making an array of Countries objects
            Country[,] countries = new Country[2,3];

            //Assign value to the array
            //Asia Countries
            countries[0,0] = new Asia("Philippines", "Manila", 117724471, "Rainy Season");
            countries[0,1] = new Asia("China", "Beijing", 1481622748, "Autumn");
            countries[0,2] = new Asia("Singapore", "Singapore", 122223, "Tropical");
            
            //Europe Countries
            countries[1,0] = new Europe("Belgium", "Brussels", 12033776, "Euro");
            countries[1,1] = new Europe("Italy", "Rome", 58538738, "Euro");
            countries[1,2] = new Europe("IceLand", "Reykjavik", 400703, "Icelandic Krona");

            //here it will display the information of the different countries 
           
            for (int row= 0; row < countries.GetLength(0); row++)
            {
                for (int col = 0; col < countries.GetLength(1); col++)
                {
                    countries[row, col].DisplayInfo();
                }
            }
            //stay put the console window open
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGH_Control_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Singh, Karndeep Kaur D.
        //IT401P
        //Review 1: Using Control Structures
        Main:
            Console.Clear();
            int num = 0;
            char n = 'Y';

            Console.WriteLine("This program will determine what type of number and display its range");
            Console.Write("\nEnter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\nThe number is EVEN");
                for (int i = 1; i <= num; num -= 2)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("\nThe number is ODD");
            }

            Console.WriteLine("\nDo you want to Try Again (Y/N)");
            n = Convert.ToChar(Console.ReadLine());

            if (n == 'Y')
            {
                goto Main;
            }

            else if (n == 'N')
            {
                return;
            }

        }
    }
    }


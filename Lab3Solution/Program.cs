using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__HW
{
    class Program
    {
        static void Main(string[] args)
        {
            uint answInt;
            string personName;

            Console.Write("Hi what is your name?");
            personName = Console.ReadLine();
            Console.WriteLine(personName + " " + "Please enter number between 1 and 100");
            var answStr = Console.ReadLine();

            if (uint.TryParse(answStr, out answInt) && answInt <= 100)
            {
                if (answInt % 2 != 0)
                {
                    Console.WriteLine(answInt + " " + "is an odd number");
                }

                if ((answInt % 2 == 0) && answInt <= 25) ;
                {
                    Console.WriteLine(answInt + " " + "Even and less than or equal to 25");
                }

                if ((answInt % 2 == 0) && answInt >= 25 && answInt <= 60) ;
                {
                    Console.WriteLine(answInt + " " + "Even and less than or equal to 60");
                }

                if ((answInt % 2 != 0) && answInt >= 60) ;
                {
                    Console.WriteLine(answInt + " " + "Odd and greater but not equal to 60");
                }

            }
            else
            {
                Console.WriteLine(" Please enter a numberic value between 1 and 100");
            }

            Console.WriteLine(answInt);
            Console.ReadLine();




        }
    }
}
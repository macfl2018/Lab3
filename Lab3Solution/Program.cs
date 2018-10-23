using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__HW
{
    class Program
    {
        // James - so the biggest problem with your code is you are getting multiple outputs, should just be one ouput 
        // per user choice.  look into use else/if instead of just single if statements, this is what is screwing you up.
        static void Main(string[] args)
        {
            // James - I would declare this variable closer to where this is being used.  in this case, you could use 
            // this variable right before your TryParse.  it's always better to declare variables closest to where you
            // are using them.  
            uint answInt;

            // James - same as the last suggestion, so where you are using this string, you can declare and initialize 
            // it on the same line.
            string personName;

            Console.Write("Hi what is your name?");

            // James - so as mentioned above, on this line of code, you can do something like s
            //
            // string personName = Console.ReadLine();
            //
            // that way you do not need the line of code above. 
            personName = Console.ReadLine();

            // James - Okay so here you are concatenating an empty string with a string with content, 
            // an alternative would be do do this...
            //
            // Console.WriteLine(personName + " Please enter number between 1 and 100");
            //
            // and better yet, you could do this...
            //
            // Console.WriteLine($"{personName} Please enter number between 1 and 100");
            Console.WriteLine(personName + " " + "Please enter number between 1 and 100");
            var answStr = Console.ReadLine();

            if (uint.TryParse(answStr, out answInt) && answInt <= 100)
            {
                if (answInt % 2 != 0)
                {
                    Console.WriteLine(answInt + " " + "is an odd number");
                }
                // James - I like that you are seperating each if statement with a line
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


            // James - lots of whitespace here, I would remove most of it to be honest

        }
    }
}
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaring a variable
            int x;
            int y;

            //assigning a value to variables
            x = 5;
            y = 1;

            //printing sum of x and y 
            Console.WriteLine(x + y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name : ");

            String myFirstname;
            myFirstname = Console.ReadLine();

            Console.WriteLine("Type your last name :");
            String myLastname;
            myLastname = Console.ReadLine();

            Console.WriteLine("Hello! " + myFirstname + " " + myLastname);
            Console.ReadLine();
        }
    }
}

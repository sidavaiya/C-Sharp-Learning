﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Declaring a variable
            int x;
            int y;

            //assigning a value to variables
            x = 5;
            y = 1;

            //printing sum of x and y 
            Console.WriteLine(x + y);
            Console.ReadLine();
            

            Console.WriteLine("What is your name?");

            //Using ReadLine(), storing user input into variable myFirstname
            Console.Write("Type your first name : ");
            String myFirstname;
            myFirstname = Console.ReadLine();

            //Using ReadLine(), storing user input into variable mylastname    
            Console.Write("Type your last name :");
            String myLastname;
            myLastname = Console.ReadLine();

            //printing data stored in variables
            Console.WriteLine("Hello! " + myFirstname + " " + myLastname);
            Console.ReadLine();
        }
    }
}

/*
 OUTPUT

6

What is your name?
Type your first name : Siddharth
Type your last name :Avaiya
Hello! Siddharth Avaiya

*/

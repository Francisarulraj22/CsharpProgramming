﻿using System;
namespace Question7;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the integer:");
        int number=int.Parse(Console.ReadLine());
        if(number<100)
        {
            System.Console.WriteLine("Less than 100");

        }
        else if(number>=100&&number<=200)
        {
            System.Console.WriteLine("Between 100 and 200");
        }
        else
        {
            System.Console.WriteLine("Greater then 200");
        }
    }
}
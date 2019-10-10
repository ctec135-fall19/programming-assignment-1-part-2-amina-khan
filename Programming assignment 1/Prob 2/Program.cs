/*
Author: Amina Khan
Date: 10/9/2019
CTEC 135: Microsoft Software Development with C#
Module 2/3, Programming Assignment 1, Prob 2
  Itteration constructs
Using loops to itterate through integers.
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print 1-5 using for loop
            Console.WriteLine("Printing 1-5 using the for loop\n");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0} ", i);
            }

            //print 1-5 using while loop
            Console.WriteLine("\n\nPrinting 1-5 using the while loop\n");
            
            int j = 1;
            while (j <= 5)
            {
                Console.Write("{0} ", j);
                j++;
            }

            //print 1-5 using do/while loop
            Console.WriteLine("\n\nPrinting 1-5 using the do/while loop\n");

            int k = 1;
            do
            {
                Console.Write("{0} ", k);
                k++;
            } while (k <= 5);

            Console.WriteLine();

        }
    }
}

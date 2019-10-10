/*
Author: Amina Khan
Date: 10/9/2019
CTEC 135: Microsoft Software Development with C#
Module 2/3, Programming Assignment 1, Prob 3
  Decision Constructs
1. Region 1: using nested for loops for printing the troubleshooting
problems and steps of actions
2. Region 2: using switch statement for printing actions
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 
            bool prints;
            bool redLight;
            bool compRecognize;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            
            Console.WriteLine("\n--- Printer Troubleshooter ---\n");
            Console.ResetColor();
            
            // using nested loops, finding every possible error and actions
            prints = true;
            // when printer prints
            for (int i = 0; i < 2; i++)
            {
                redLight = true;
                // when a red light is flashing
                for (int j = 0; j < 2; j++)
                {
                    compRecognize = true;
                    // when printer is recognized by computer
                    for (int k = 0; k < 2; k++)
                    {
                        // printing the conditions
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n\nConditions: Prints: {0}\t " +
                            "Red Light: {1}\t Printer Recognized: {2}", 
                            prints, redLight, compRecognize);
                        Console.ResetColor();

                        // printing necessary actions using if statements
                        Console.WriteLine("Actions:");
                        if (!prints & !redLight & !compRecognize)
                        {
                            checkPower();
                            checkConnection();
                            checkSoftware();
                        }
                        if (prints & !redLight & !compRecognize)
                        {
                            checkSoftware();
                        }
                        if (!prints & redLight & !compRecognize)
                        {
                            checkConnection();
                            checkSoftware();
                            checkInk();
                        }
                        if (prints & redLight & !compRecognize)
                        {
                            checkSoftware();
                        }
                        if (!prints & !redLight & compRecognize)
                        {
                            checkPaperJam();
                        }
                        if (prints & !redLight & compRecognize)
                        {
                            Console.WriteLine("Do Nothing, All looks good.");
                        }
                        if (!prints & redLight & compRecognize)
                        {
                            checkInk();
                            checkPaperJam();
                        }
                        if (prints & redLight & compRecognize)
                        {
                            checkInk();
                        }
                        compRecognize = false;
                    }
                    redLight = false;
                }
                prints = false;
            }

            #endregion
            
            
            #region 2
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n Second Region / method \n\n");
            Console.ResetColor();

            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkPower();
                        checkConnection();
                        checkSoftware();
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkSoftware();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkConnection();
                        checkSoftware();
                        checkInk();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkSoftware();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkPaperJam();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        Console.WriteLine("All looks good");
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkInk();
                        checkPaperJam();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCase {0}  \nActions:\n", i);
                        Console.ResetColor();
                        checkInk();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();

            #endregion
        }
        // methods for each action
        static void checkPower()
        {
            Console.WriteLine("Check the power cable");
        }

        static void checkConnection()
        {
            Console.WriteLine("Check the printer-computer cable");
        }

        static void checkSoftware()
        {
            Console.WriteLine("Ensure printer software is installed");
        }

        static void checkInk()
        {
            Console.WriteLine("Check/replace ink");
        }

        static void checkPaperJam()
        {
            Console.WriteLine("Check for paper jam");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            //introduction
            Console.WriteLine("Hello there!!! Thank you for using Mister Cleatus, the most inaccurate fortune\nteller the world has ever seen.\n\nTo quit at any time, type \"Quit\"\n\n");
            Console.WriteLine("\nTo begin, please enter your first name. Nicknames are okay.\n");  //asking for first name

            string firstName = Console.ReadLine();
            string firstNameCaps = firstName.ToUpper();

            if (firstNameCaps == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nThank you, " + firstName + ". Now please enter your last name.\n"); //asking for last name

                string lastName = Console.ReadLine();
                string lastNameCaps = lastName.ToUpper();

                if (lastNameCaps == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nWhat an incredible name! I have never met anyone named " + firstName + " " + lastName + " before.");
                    Console.WriteLine("\nPlease enter your age. If you're insecure about your age, I suppose lying\nis okay.\n"); //asking for age

                    string ageQuit = Console.ReadLine();
                    string ageQuitCaps = ageQuit.ToUpper();

                    if (ageQuitCaps == "QUIT")
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        Console.ReadKey();
                    }
                    else
                    {
                        int age = int.Parse(ageQuit);

                        Console.WriteLine("\nWell, if you're lying, I am sure " + age + " is close enough.");
                        Console.WriteLine("\nPlease enter the month you were born as a two digit number. \ne.g. 10 for October.\n"); //asking for birth month

                        string birthMonthQuit = Console.ReadLine();
                        string birthMonthQuitCaps = birthMonthQuit.ToUpper();

                        if (birthMonthQuitCaps == "QUIT")
                        {
                            Console.WriteLine("Nobody likes a quitter...");
                            Console.ReadKey();
                        }
                        else
                        {
                            int birthMonth = int.Parse(birthMonthQuit);

                            Console.WriteLine("\nWhat is your favorite color from the choices that are in ROYGBIV.\nIf you don't know the colors included in ROYGBIV, please type \"Help\"\n"); //asking for favorite color
                            string favoriteColor = Console.ReadLine();

                            string favoriteColorCaps = favoriteColor.ToUpper();

                            if (favoriteColorCaps == "QUIT")
                            {
                                Console.WriteLine("Nobody likes a quitter...");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (favoriteColorCaps == "HELP") //In case help is required
                                {
                                    Console.WriteLine("\a\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\nOut of those choices, which is your favorite?\n");
                                    favoriteColor = Console.ReadLine();
                                }

                                favoriteColorCaps = favoriteColor.ToUpper();

                                if (favoriteColorCaps == "QUIT")
                                {
                                    Console.WriteLine("Nobody likes a quitter...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("\nI guess " + favoriteColor + " is an decent choice.\n\nLastly, how many siblings do you have?\n"); //asking for number of siblings

                                    string numberOfSiblingsQuit = Console.ReadLine();
                                    string numberOfSiblingsQuitCaps = numberOfSiblingsQuit.ToUpper();

                                    if (numberOfSiblingsQuitCaps == "QUIT")
                                    {
                                        Console.WriteLine("Nobody likes a quitter...");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        int numberOfSiblings = int.Parse(numberOfSiblingsQuit);

                                        Console.WriteLine("\n\nAll right. All right. Settle down. That is all I need to make my prediction.\nPlease press any key to find out your future.");
                                        Console.ReadKey();
                                        Console.WriteLine("\nI don't think you're ready. When you're SURE you want to see the prediction,\npress any key.");
                                        Console.ReadKey();
                                        Console.WriteLine("\nYou could at least get a drum roll going... *sigh* Just press any key again.\n");
                                        Console.ReadKey();

                                        //All user input is complete. Now the juicy stuff


                                        //Part 2
                                        //Setting all the variables


                                        //defining the retirement years

                                        string retireYears;
                                        if ((age % 2) == 1)
                                        {
                                            retireYears = "13 years";
                                        }
                                        else
                                        {
                                            retireYears = "52 years";
                                        }


                                        //defining the vacation Homes
                                        string vacationHome;
                                        if (numberOfSiblings >= 4)
                                        {
                                            vacationHome = "your backyard";
                                        }
                                        else
                                        {
                                            switch (numberOfSiblings)
                                            {
                                                case 0:
                                                    vacationHome = "Monte Carlo";
                                                    break;

                                                case 1:
                                                    vacationHome = "Naples, Italy";
                                                    break;

                                                case 2:
                                                    vacationHome = "Honolulu, Hawaii";
                                                    break;

                                                case 3:
                                                    vacationHome = "the upper peninsula of Michigan";
                                                    break;

                                                default:
                                                    vacationHome = "a dumpster in Siberia (you filthy liar)";
                                                    break;
                                            }
                                        }


                                        //defining the transportation
                                        string transport;
                                        switch (favoriteColorCaps)
                                        {
                                            case "RED":
                                                transport = "\na crimson Maserati";
                                                break;

                                            case "BLUE":
                                                transport = "\na yacht on the cerulean sea";
                                                break;

                                            case "GREEN":
                                                transport = "\nan emerald colored private jet";
                                                break;

                                            case "ORANGE":
                                                transport = "\nyou will venture the world on the back of an orangutan";
                                                break;

                                            case "YELLOW":
                                                transport = "\na magical canary on which you will ride";
                                                break;

                                            case "VIOLET":
                                                transport = "\nyou will be rolled around like Violet from Willy Wonka";
                                                break;

                                            case "INDIGO":
                                                transport = "\na model train (who picks indigo anyway?)";
                                                break;

                                            case "INIGO":
                                                transport = "\nmy name is Inigo Montoya.\n\nYou killed my father, prepare to die (nice typo)\a\a\a";
                                                break;

                                            default:
                                                transport = "\nyou will spend the rest of your days assisting a dung beetle with his/her\nday to day DUTIES (pun intended for your malfeasance)";
                                                break;
                                        }


                                        //defining the money in the bank

                                        double moneyInBank;

                                        if (birthMonth >= 1 && birthMonth <= 4)
                                        {
                                            moneyInBank = 3200000.98;
                                        }
                                        else if (birthMonth >= 5 && birthMonth <= 8)
                                        {
                                            moneyInBank = 7777777.78;
                                        }
                                        else if (birthMonth >= 9 && birthMonth <= 12)
                                        {
                                            moneyInBank = 5318008.01;
                                        }
                                        else
                                        {
                                            moneyInBank = 0.00;
                                        }


                                        //Part 3: The output--->Finally the prediction

                                        Console.WriteLine("\n\n" + firstName + " " + lastName + " will retire in " + retireYears + " with $" + moneyInBank + " in the bank,\na vacation home in " + vacationHome + ", and " + transport + ".");
                                        Console.WriteLine("\n\nWell, I certainly hope you have a pleasant day.");

                                        Console.ReadKey();

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
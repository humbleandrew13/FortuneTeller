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
            //introduction
            Console.WriteLine("Hello there!!! Thank you for using Mister Cleatus, the most inaccurate fortune\nteller the world has ever seen.");
            Console.WriteLine("\nTo begin, please enter your first name. Nicknames are okay.\n");  //asking for first name
            string firstName = Console.ReadLine();

            Console.WriteLine("\nThank you, " + firstName + ". Now please enter your last name.\n"); //asking for last name
            string lastName = Console.ReadLine();

            Console.WriteLine("\nWhat an incredible name! I have never met anyone named " + firstName + " " + lastName + " before.");
            Console.WriteLine("\nPlease enter your age. If you're insecure about your age, I suppose lying\nis okay.\n"); //asking for age
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWell, if you're lying, I am sure " + age + " is close enough.");
            Console.WriteLine("\nPlease enter the month you were born as a two digit number. \ne.g. 10 for October.\n"); //asking for birth month
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is your favorite color from the choices that are in ROYGBIV.\nIf you don't know the colors included in ROYGBIV, please type \"Help\"\n"); //asking for favorite color
            string favoriteColor = Console.ReadLine();

            string favoriteColorCaps = favoriteColor.ToUpper();

            if (favoriteColorCaps == "HELP") //In case help is required
            {
                Console.WriteLine("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\nOut of those choices, which is your favorite?\n");
                favoriteColor = Console.ReadLine();
            }

            favoriteColorCaps = favoriteColor.ToUpper();

            Console.WriteLine("\n" + favoriteColor + " is an excellent choice.\n\nLastly, how many siblings do you have?\n"); //asking for number of siblings
            int numberOfSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nAll right. All right. Settle down. That is all I need to make my prediction.\nPlease press any key to find out your future.");
            Console.ReadKey();
            Console.WriteLine("\nI don't think you're ready. When you're SURE you want to see the prediction,\npress any key.");
            Console.ReadKey();
            Console.WriteLine("\nYou could at least get a drum roll going... Press any key again.\n");
            Console.ReadKey();
            
            //All user input is complete. Now the juicy stuff


            
        }
    }
}

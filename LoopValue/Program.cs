using System;

namespace LoopValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //This takes in the user input of what number to multiply by
            Console.Write("Please enter a number for the loop assignment: ");
            var loopValue = Console.ReadLine();
            //This changes the user input to an integer
            int numValue = int.Parse(loopValue);
            //This variable will allow us to keep track of the sums as the program iterates through the loop
            int keepTrack = 0;
            Console.WriteLine("Now I will multiply this number by 2-20 and print out the results");
            //This creates the loop which will multiply by 2-20
            for (int i = 2;  i < 21; i++)
            {
                //Each time we iterate through the loop, keepTrack will add to the previous sum
                keepTrack = (numValue * i) + keepTrack;
                //This prints to screen the number entered b 2-20 depending on which iteration
                Console.WriteLine(numValue * i);
            }
            Console.WriteLine("The sum of all these numbers is: " + keepTrack);
            //exits program with enter
            Console.ReadLine();
        }
    }
}

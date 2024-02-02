using System.Runtime.CompilerServices;
using System;

namespace ChooseYourOwnAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add your code here

            // Greet player with title of the game


            // Display description of first room and ask for the user to enter choice

            //Display description of Room 1 if user enters upstairs

            //Display description of Room 2 if user enters kitchen
            /*
                        WELCOME TO MITCHELL'S TINY ADVENTURE!

            You are in a creepy house! Would you like to go 'upstairs' or into the 'kitchen' ? upstairs

            Upstairs you see a hallway.  At the end of the hallway is the
            master 'bedroom'.There is also a 'bathroom' off the hallway.
            Where would you like to go? bedroom

            You are in a plush bedroom, with expensive-looking hardwood
            furniture.The bed is unmade.In the back of the room,
            the closet door is ajar.
            Would you like to open the door ? ('yes' or 'no') yes
                        You open the closet and find a chest.Inside the chest
            you find a bunch of coins(Bitcoins)! Enjoy your treasure!
            */

            string userResponse = Console.ReadLine().ToUpper();
        }
    }
}
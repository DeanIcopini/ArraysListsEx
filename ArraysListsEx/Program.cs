using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsEx
{
    class Program
    {
        static void Main()
        {
            // This line iterates through the array until it gets to the point of userInput
            //for (var i = 0; i == userInput; i++)

            // Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            
            string[] containersLiquid = new[] { "Cup", "Mug", "Glass", "Bowl", "Sippy Cup" };


            Console.WriteLine("Please enter a number between 0 and 4");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 4)
            {
                Console.WriteLine("The number you selected is not within the scope of this array.");
            }
            else
            {
                Console.WriteLine("\n" + containersLiquid[userInput]);
            }

            // Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] numbersThroughTen = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            Console.WriteLine("\nPlease enter a number between 0 and 9");
            int userInputInt = Convert.ToInt32(Console.ReadLine());

            if (userInputInt > 9)
            {
                Console.WriteLine("The number you selected is not within the scope of this array.");
            }
            else
            {
                Console.WriteLine("\n" + numbersThroughTen[userInputInt]);
            }
            

            // Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            //string petsList = "Dogs", "Cats", "Turtles", "Snakes", "Pot-Bellied Pigs";
            List<String> pets = new List<String>();
            pets.Add("Dogs");
            pets.Add("Cats");
            pets.Add("Turtles");
            pets.Add("Snakes");
            pets.Add("Pot-Bellied Pigs");

            Console.WriteLine("Please enter a number between 0 and 4");
            int userInputPets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pets.ElementAt(userInputPets));
            
            Console.Read();
        }
    }
}

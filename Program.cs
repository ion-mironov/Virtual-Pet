using System.Reflection.Metadata;

namespace template_csharp_virtual_pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool running = true;
            while (running)
            {
                // Your Program Code Here
                Console.Clear();
                Console.WriteLine("Welcome to Virtual Pet!\n");

                // Main menu will consist of options to add a pet to the shelter and see what pets are currently in the shelter.

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a new Pet.");
                Console.WriteLine("2. Go to Shelter.");    // This will produce a new submenu where the user can play, feed, take to doctor, etc.
                //                                              // If there are no Pets, have a fail-safe to state that there are none and ask if the user
                //                                              // wants to create a new Pet.
                Console.WriteLine("Press 'Q' to quit.");
                Console.Write("Enter your selection here: ");
                string mainMenuSelection = Console.ReadLine().ToLower();
                Pet userPet = new Pet(petName, petSpecies, 60, 60, 60);

                if (mainMenuSelection == "1")
                {
                    string petName = Pet.SpeciesMenu();
                    // next method
                    Console.WriteLine("What is the name of your pet?");
                    string petName = Console.ReadLine();
                    
                }

                /*
                switch (mainMenuSelection)            ///Removed for testing purposes
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "q":
                        running = false;
                        Console.WriteLine("Good-bye! Come back anytime!");
                        break;

                    default:
                        break;
                */

                // ---------------------------------- NEW PET CREATION ---------------------------------- //

                // Have user select what species their new pet is.
                

                
                
               

                // Ask user if the pet is organic or robotic.
                Console.WriteLine("What variation of species is your pet?");
                Console.WriteLine("1. Organic");
                Console.WriteLine("2. Robotic\n");
                Console.Write("Enter a line number: ");
                int variationSelection = Convert.ToInt32(Console.ReadLine());

                // ---------------------------------- NEW PET CREATION ---------------------------------- //



                // ---------------------------------- SHELTER ---------------------------------- //

                // Shelter will allow user to see what Pets are currently housed and able to be interacted with and even adopt.
                // If there are no Pets, tell user that there are none and provide them option to create one.


                // 


                // ---------------------------------- SHELTER ---------------------------------- //

            }
        }
        
        }
    }
}
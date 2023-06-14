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
                Console.WriteLine("2. Go to Shelter.\n");    // This will produce a new submenu where the user can play, feed, take to doctor, etc.

                Console.WriteLine("Press 'Q' to quit.");
                Console.Write("Enter your selection here: ");
                string mainMenuSelection = Console.ReadLine().ToLower();

                Pet userPet = new Pet(string.Empty, string.Empty, 60, 60, 60);
                Shelter myShelter = new Shelter();
                switch (mainMenuSelection)
                {
                    case "1":
                        userPet.CreateNewPet();
                        myShelter.Admit(userPet);
                        userPet.DisplayPet();
                        userPet.InteractMenu();
                        break;

                    case "2":
                        myShelter.DisplayAllPets();
                        Console.ReadLine(); // <--- the "C" was lowercase, preventing the application from running.
                        break;

                    case "q":
                        running = false;
                        Console.WriteLine("Good-bye! Come back anytime!");
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
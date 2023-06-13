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

                // Main menu will consist of options to add a pet to the shelter, adopt a pet, and see what pets are currently in the shelter.

                // Would possibly make more sense to have Add a Pet within the submenu of Create-A-Pet. Otherwise, how can you add a pet that doesn't exist?

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a new Pet.");
                Console.WriteLine("2. Select a Pet to interact with.");     // This will produce a new submenu where the user can play, feed, take to doctor, etc.
                Console.WriteLine("3. Add a Pet to the shelter.");
                Console.WriteLine("4. Adopt a Pet from the shelter.");
                Console.WriteLine("5. See what Pets are in the shelter\n"); // Display a list of all Pets currently in the shelter.
                Console.WriteLine("Press 'Q' to quit.");
                Console.Write("Enter your selection here: ");
                string mainMenuSelection = Console.ReadLine().ToLower();

                switch (mainMenuSelection)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "q":
                        running = false;
                        Console.WriteLine("Good-bye! Come back anytime!");
                        break;

                    default:
                        break;
                }

                // ---------------------------------- NEW PET CREATION ---------------------------------- //

                // Have user select what species their new pet is.
                Console.WriteLine("What is the species of your new pet?");
                Console.WriteLine("1. Wolf");
                Console.WriteLine("2. Fox");
                Console.WriteLine("3. Red Panda");
                Console.WriteLine("4. Dragon");
                Console.WriteLine("5. Rabbit\n");
                Console.Write("Enter a line number: ");
                int speciesSelection = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the name of your pet?");
                string petNameInput = Console.ReadLine();

                // Ask user if the pet is organic or robotic.
                Console.WriteLine("What variation of species is your pet?");
                Console.WriteLine("1. Organic");
                Console.WriteLine("2. Robotic\n");
                Console.Write("Enter a line number: ");
                int variationSelection = Convert.ToInt32(Console.ReadLine());

                // ---------------------------------- NEW PET CREATION ---------------------------------- //



            }
        }
    }
}
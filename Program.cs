namespace template_csharp_virtual_pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Shelter shelter = new Shelter();  // Create an instance of the Shelter class where newly created Pets will be stored in a List.

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Virtual Pet!\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a new Pet.");
                Console.WriteLine("2. Go to Shelter.\n");
                Console.WriteLine("Press 'Q' to quit.");
                Console.Write("Enter your selection here: ");
                string mainMenuSelection = Console.ReadLine().ToLower();

                switch (mainMenuSelection)
                {
                    case "1":
                        Pet newPet = CreateNewPet();    // Call the CreateNewPet method to create a new pet
                        shelter.Admit(newPet);          // Add the new pet to the shelter's Pets list
                        newPet.DisplayPet();            // Display the new pet's details
                        newPet.InteractMenu();          // Allow interactions with the new pet
                        break;

                    case "2":
                        shelter.DisplayAllPets();       // Display all pets in the shelter
                        Console.ReadLine();
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

        // Method to create a new pet
        static Pet CreateNewPet()       // Used to create an instance of the Pet class.
        {
            string petName = NameMenu();
            string petSpecies = SpeciesMenu();
            Pet newPet = new Pet(petName, petSpecies, 60, 60, 60);
            return newPet;
        }

        // Method to get the name of the pet from the user
        static string NameMenu()
        {
            Console.WriteLine("\nWhat is the name of your pet?");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        // Method to get the species of the pet from the user
        static string SpeciesMenu()
        {
            int speciesSelection;
            string animal;
            do
            {
                Console.Clear();
                Console.WriteLine("What is the species of your new pet?");
                Console.WriteLine("1. Wolf");
                Console.WriteLine("2. Fox");
                Console.WriteLine("3. Red Panda");
                Console.WriteLine("4. Dragon");
                Console.WriteLine("5. Rabbit\n");
                Console.Write("Enter a line number: ");
                speciesSelection = Convert.ToInt32(Console.ReadLine());
            }
            while (speciesSelection < 1 || speciesSelection > 5);

            switch (speciesSelection)
            {
                case 1:
                    animal = "Wolf";
                    break;
                case 2:
                    animal = "Fox";
                    break;
                case 3:
                    animal = "Red Panda";
                    break;
                case 4:
                    animal = "Dragon";
                    break;
                case 5:
                    animal = "Rabbit";
                    break;
                default:
                    animal = string.Empty;
                    break;
            }
            return animal;
        }
    }
}

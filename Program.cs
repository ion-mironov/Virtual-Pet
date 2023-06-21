namespace template_csharp_virtual_pet
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Shelter shelter = new Shelter();

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Virtual Pet Shelter!\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Admit a new Organic Pet");
                Console.WriteLine("2. Admit a new Robotic Pet");
                Console.WriteLine("3. See all the Pets that are currently here");
                Console.WriteLine("4. Interact with a single Pet");
                Console.WriteLine("5. Interact with all Pets");
                Console.WriteLine("6. Adopt a Pet\n");
                Console.WriteLine("Press 'Q' to quit.");
                Console.Write("Enter your selection here: ");
                string mainMenuSelection = Console.ReadLine().ToLower();

                switch (mainMenuSelection)
                {
                    case "1":
                        Pet newOrganicPet = CreateNewPet(true);
                        shelter.Admit(newOrganicPet);
                        newOrganicPet.DisplayPet();
                        break;

                    case "2":
                        Pet newRoboticPet = CreateNewPet(false);
                        shelter.Admit(newRoboticPet);
                        newRoboticPet.DisplayPet();
                        break;

                    case "3":
                        shelter.DisplayAllPets();
                        Console.ReadLine();
                        break;

                    case "4":
                        Pet selectedPet = shelter.GetPet();
                        selectedPet.InteractMenu();
                        break;

                    case "5":
                        shelter.InteractAllMenu();
                        break;

                    case "6":
                        Pet adoptedPet = shelter.GetPet();
                        shelter.Adopt(adoptedPet);
                        Console.ReadLine();
                        break;

                    case "q":
                        running = false;
                        Console.WriteLine("Good-bye! Come back anytime!");
                        break;

                    default:
                        break;
                }
                shelter.TickAll();
            }
        }

        static Pet CreateNewPet(bool isOrganic)
        {
            string petName = NameMenu();
            string petSpecies = SpeciesMenu();
            if (isOrganic)
            {
                Organic newPet = new Organic(petName, petSpecies, "Organic", 60, 60, 60);
                return newPet;
            }
            else
            {
                Robotic newPet = new Robotic(petName, petSpecies, "Robotic", 60, 60, 60);
                return newPet;
            }
        }

        // Method to get the name of the Pet from the user
        static string NameMenu()
        {
            Console.WriteLine("\nWhat is the name of your Pet?");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        // Method to get the species of the Pet from the user
        static string SpeciesMenu()
        {
            int speciesSelection;
            string animal;
            do
            {
                Console.Clear();
                Console.WriteLine("What is the species of your new Pet?");
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
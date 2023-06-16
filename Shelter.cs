namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        // Field
        private List<Pet> pets;

        // Property
        public List<Pet> Pets { get; set; }

        // Constructor
        public Shelter()
        {
            Pets = new List<Pet>();
        }

        // Method to display all pets in the shelter
        // ----------- DISPLAY ALL PETS ----------- //
        public void DisplayAllPets()
        {
            int counter = 1;
            Console.WriteLine("Currently in your Shelter we have the following Pets:\n");
            foreach (Pet pet in Pets)
            {
                Console.WriteLine($"PET #{counter}:\t\t Name: {pet.PetName}\t Species: {pet.PetSpecies}\t Health: {pet.PetHealth}\t" +
                    $"Hunger: {pet.PetHunger}\tBoredom: {pet.PetBoredom}\n");
                counter++;
            }
        }

        // Method to add a pet to the shelter
        public void Admit(Pet pet)
        {
            Pets.Add(pet);
            Console.WriteLine($"You successfully added your pet to the shelter.");
        }

        // Method to remove a pet from the shelter
        public void Adopt(Pet pet)
        {
            Pets.Remove(pet);
        }
        // -------------- INTERACTION MENU (ALL)-------------- //
        public void InteractAllMenu()
        {
            string userChoice;
            do
            {
                Console.WriteLine("What would you like to do with your Pets?");
                Console.WriteLine("1. Play with all of them!");
                Console.WriteLine("2. Feed all of them");
                Console.WriteLine("3. Full shelter vet visit\n");
                Console.WriteLine("0. Go back to Main Menu\n");
                Console.Write("Enter a selection number: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        PlayAll();
                        break;
                    case "2":
                        FeedAll();
                        break;
                    case "3":
                        SeeDoctorAll();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Your selection is invalid");
                        break;
                }
                // call user Pet.Tick
                // Put in a fail-safe to prevent incorrect menu selection from utilizing the Tick function.
            }
            while (userChoice != "0");
        }

        // ----------- INTERACTIONS (ALL) ----------- //
        public void FeedAll()
        {
            foreach (Pet pet in Pets)
            {
                pet.PetHunger -= 10;
            }
            DisplayAllPets();
            Console.WriteLine("\nYou fed all the pets their favorite food! NOM NOM NOM!");
        }
        public void SeeDoctorAll()
        {
            foreach (Pet pet in Pets)
            {
                pet.PetHealth += 10;
            }
            DisplayAllPets();
            Console.WriteLine("\nYou make a check-up appointment for all the pets; they are being well taken care of!");
        }
        public void PlayAll()
        {
            foreach (Pet pet in Pets)
            {
                pet.PetHealth += 10;
                pet.PetHunger += 10;
                pet.PetBoredom -= 20;
            }
            DisplayAllPets();
            Console.WriteLine("\nYou play with all your pets; they love the attention!");
        }
    }
}

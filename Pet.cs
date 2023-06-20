namespace template_csharp_virtual_pet
{
    public class Pet
    {
        // FIELDS //
        private string petName;
        private string petSpecies;
        private int petHealth;
        private int petHunger;
        private int petBoredom;

        // PROPERTIES //
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public int PetHealth { get { return petHealth; } set { petHealth = Math.Max(0, Math.Min(value, 150)); } }
        public int PetHunger { get { return petHunger; } set { petHunger = Math.Max(0, Math.Min(value, 150)); } }
        public int PetBoredom { get { return petBoredom; } set { petBoredom = Math.Max(0, Math.Min(value, 150)); } }
        // CONSTRUCTOR //
        public Pet(string petName, string petSpecies, int petHealth, int petBoredom, int petHunger)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            PetHunger = petHealth;
            PetBoredom = petBoredom;
            PetHealth = petHunger;
        }


        // ------------------------------------------ METHODS ------------------------------------- //

        // -------------- INTERACTION MENU (INDIVIDUAL)-------------- //
        public void InteractMenu()
        {
            string userChoice;
            do
            {
                Console.WriteLine("What would you like to do with your Pet?");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Feed");
                Console.WriteLine("3. Go to vet\n");
                Console.WriteLine("0. Go back to Main Menu\n");
                Console.Write("Enter a selection number: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Play();
                        break;
                    case "2":
                        Feed();
                        break;
                    case "3":
                        SeeDoctor();
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


        // ----------- INTERACTIONS (INDIVIDUAL) ----------- //
        public void Feed()
        {
            PetHunger -= 10;
            DisplayPet();
            Console.WriteLine("\nYou give your pet their favorite food! NOM NOM NOM!");
        }
        public void SeeDoctor()
        {
            PetHealth += 30;
            DisplayPet();
            Console.WriteLine("\nYou make a check-up appointment for your pet; they are being well taken care of!");
        }
        public void Play()
        {
            PetHealth += 10;
            PetHunger += 10;
            PetBoredom -= 20;
            DisplayPet();
            Console.WriteLine("\nYou play with your pet; they love the attention!");
        }


        


       


        // ----------- TICK FUNCTION FOR ALL PETS ----------- //
        public void TickAll()
        {
            PetHealth -= 5;
            PetHunger += 5;
            PetBoredom += 5;
        }


        // ----------- DISPLAY PET (INDIVIDUAL) ----------- //
        public void DisplayPet()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine($"{PetName}                                                                         ");
            Console.WriteLine($"{PetSpecies}                                                                      ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\tHealth: {PetHealth}\t\t Hunger: {PetHunger} \t\t Boredom: {PetBoredom}          ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("===================================================================================\n");
        }

        public int GetPetHealth()
        {
            return PetHealth;
        }

        public int GetPetHunger()
        {
            return PetHunger;
        }

        public int GetPetBoredom()
        {
            return PetBoredom;
        }
    }
}
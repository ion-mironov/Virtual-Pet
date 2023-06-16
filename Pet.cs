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
        public int PetHealth { get; private set; }
        public int PetHunger { get; private set; }
        public int PetBoredom { get; private set; }

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

        public Pet CreateNewPet()
        {
            PetName = NameMenu();
            PetSpecies = SpeciesMenu();
            Pet pet = new Pet(PetName, PetSpecies, 60, 60, 60);
            return pet;
        }
        public string NameMenu()
        {
            Console.WriteLine("\nWhat is the name of your pet?");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

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
                // If user makes invalid selection, do not run Tick command.
            }
            while (userChoice != "0");
        }

        public string SpeciesMenu()
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
            Console.WriteLine("\nYou make a check-up appointment for your pet! They are being well taken care of!");
        }
        public void Play()
        {
            PetHealth += 10;
            PetHunger += 10;
            PetBoredom -= 20;
            DisplayPet();
            Console.WriteLine("\nYou play with your pet; they love the attention!");
        }
        public void Tick()
        {
            PetHealth -= 5;
            PetHunger += 5;
            PetBoredom += 5;
        }
        public void DisplayPet()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine($"{PetName}                                                                         ");
            Console.WriteLine($"{PetSpecies}                                                                      ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\tHealth: {PetHealth}\t\t Boredom: {PetBoredom} \t\t Hunger: {PetHunger}          ");
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


        // Possible solution to the tick timer within the program

        //aTimer = new System.Timers.Timer(1000); //One second, (use less to add precision, use more to consume less processor time
        //int lastHour = DateTime.Now.Hour;
        //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        //aTimer.Start();
        //private static void OnTimedEvent(object source, ElapsedEventArgs e)
        //{
        //    if (lastHour < DateTime.Now.Hour || (lastHour == 23 && DateTime.Now.Hour == 0))
        //    {
        //        lastHour = DateTime.Now.Hour;
        //        YourImportantMethod(); // Call The method with your important staff..
        //    }

        //}

    }
}
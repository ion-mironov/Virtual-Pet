namespace template_csharp_virtual_pet
{
    public class Pet
    {
        // FIELDS //
        private string petName = string.Empty;
        private string petSpecies = string.Empty;
        private int petHealth = 60;
        private int petHunger = 60;
        private int petBoredom = 60;

        // PROPERTIES //
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public int PetHealth { get; set; }
        public int PetHunger { get; set; }
        public int PetBoredom { get; set; }

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

        }
        public string NameMenu()
        {
            Console.WriteLine("What is the name of your pet?");
            string nameInput = Console.ReadLine();
            return 

        }
        
        public string SpeciesMenu()
        {
            int speciesSelection;
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
                    return "Wolf";
                case 2:
                    return "Fox";
                case 3:
                    return "Red Panda";
                case 4:
                    return "Dragon";
                case 5:
                    return "Rabbit";
                default:
                    return string.Empty;
            }
        }
        public void Feed()
        {

            PetHunger -= 10;
            DisplayPet();
            Console.WriteLine("You give your pet their favorite food!  NOM NOM NOM!");
        }
        public void SeeDoctor()
        {

            PetHealth += 30;
            DisplayPet();
            Console.WriteLine("\nYou make a check-up appointment for your pet!  They are being well taken care of!");
        }
        public void Play()
        {
            PetHealth += 10;
            PetHunger += 10;
            PetBoredom -= 20;
            DisplayPet();
            Console.WriteLine("\nYou play with your pet!  They love the attention!");
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===================================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\t{PetName}");
            Console.Write("                                                                 ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n\t{PetSpecies}                                                       ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\t\t\t Health: {PetHealth}\t\t Boredom: {PetBoredom} \t\t Hunger: {PetHunger} ");
            Console.WriteLine("                                                                                    ");
            Console.WriteLine("====================================================================================");
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
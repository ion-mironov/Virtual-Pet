using System.Timers;

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

        public void Feed()
        {
            PetHunger -= 10;
        }
        public void SeeDoctor()
        {
            PetHealth += 30;
        }
        public void Play()
        {
            PetHealth += 10;
            PetHunger += 10;
            PetBoredom -= 20;
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
﻿namespace template_csharp_virtual_pet
{
    public class Robotic : Pet
    {
        // CONSTRUCTOR
        public Robotic(string petName, string petSpecies, string petType, int petHealth, int petBoredom, int petHunger) : base(petName, petSpecies, "Robotic", petHealth, petBoredom, petHunger)
        {

        }


        // ------------------------------------------ METHODS ------------------------------------- //

        // -------------- INTERACTION MENU (INDIVIDUAL)-------------- //
        public override void InteractMenu()
        {
            string userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine($"\nWhat would you like to do with {PetName}?");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Recharge");
                Console.WriteLine("3. Go to mechanic\n");
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
            }
            while (userChoice != "0");
        }

        public override void Feed()
        {
            PetHunger += 10;
            DisplayPet();
            Console.WriteLine($"\nYou recharge {PetName}'s batteries. BZZZZT!");
        }
        public override void SeeDoctor()
        {
            PetHealth += 30;
            DisplayPet();
            Console.WriteLine($"\nYou take {PetName} to the shop for a tune-up; they are being well taken care of!");
        }
        public override void Play()
        {
            PetHealth += 10;
            PetHunger -= 10;
            PetBoredom -= 20;
            DisplayPet();
            Console.WriteLine($"\nYou play with {PetName}; their gyros are spinning excitedly!");
        }

        public override void DisplayPet()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine($"{PetName}                                                                         ");
            Console.WriteLine($"{PetType} {PetSpecies}                                                            ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\tRust Level: {PetHealth}\t\t Battery: {PetHunger} \t\t Idleness: {PetBoredom}    ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("===================================================================================\n");
        }
    }
}

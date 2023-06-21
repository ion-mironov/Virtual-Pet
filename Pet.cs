﻿namespace template_csharp_virtual_pet
{
    public abstract class Pet
    {
        // FIELDS //
        private string petName;
        private string petSpecies;
        private string petType;
        private int petHealth;
        private int petHunger;
        private int petBoredom;

        // PROPERTIES //
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public string PetType { get; set; }
        public int PetHealth
        {
            get { return petHealth; }
            set
            {
                petHealth = Math.Max(0, Math.Min(value, 150));
                // `Math.Min(value, 150)` calculates the minimum value between `value` and `150`.
                // `value` refers to the current number (stat) of the Pet's Health.

                // The result of `Math.Min(value, 150)` is passed as the second argument to Math.Max.
                // `Math.Max` compares the second argument with `0` and returns the larger value.
                // The resulting value is assigned to the relevant property, ensuring it stays within range.
            }
        }
        public int PetHunger
        {
            get { return petHunger; }
            set
            {
                petHunger = Math.Max(0, Math.Min(value, 150));
            }
        }
        public int PetBoredom
        {
            get { return petBoredom; }
            set
            {
                petBoredom = Math.Max(0, Math.Min(value, 150));
            }
        }

        // CONSTRUCTOR //
        public Pet(string petName, string petSpecies, string petType, int petHealth, int petBoredom, int petHunger)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            PetType = petType;
            PetHunger = petHealth;
            PetBoredom = petBoredom;
            PetHealth = petHunger;
        }


        // ------------------------------------------ METHODS ------------------------------------- //

        public abstract void InteractMenu();
        public abstract void Feed();
        public abstract void SeeDoctor();
        public abstract void Play();
        public abstract void DisplayPet();

    }
}

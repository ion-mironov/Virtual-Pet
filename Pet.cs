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
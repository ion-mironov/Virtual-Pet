namespace template_csharp_virtual_pet
{
    public class Pet
    {
        // FIELDS //
        private string petName = string.Empty;
        private string petSpecies = string.Empty;
        private int petHunger = 60;
        private int petBoredom = 60;
        private int petHealth = 60;

        // PROPERTIES //
        public string PetName { get; set; }
        public string PetSpecies { get; set; }
        public int PetHunger { get; set; }
        public int PetBoredom { get; set; }
        public int PetHealth { get; set; }

        // CONSTRUCTOR //
        public Pet(string petName, string petSpecies, int petHunger, int petBoredom, int petHealth)
        {
            PetName = petName;
            PetSpecies = petSpecies;
            PetHunger = petHunger;
            PetBoredom = petBoredom;
            PetHealth = petHealth;
        }

        // ------------------------------------------ METHODS -------------------------------------

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
            PetHunger += 10;
            PetBoredom -= 20;
            PetHealth += 10;
        }
        public void Tick()
        {
            PetHunger += 5;
            PetBoredom += 5;
            PetHealth -= 5;
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
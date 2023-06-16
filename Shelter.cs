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
    }
}

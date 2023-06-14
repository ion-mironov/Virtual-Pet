namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        // Field
        private List<Pet> pets;

        // Properties
        public List<Pet> Pets { get; set; }

        // Constructor
        public Shelter()
        {
            Pets = new List<Pet>();
        }

        // ----------------------------- METHODS ------------------------------
        public void DisplayAllPets()
        {
            Console.WriteLine("Currently in your Shelter we have the following Pets:\n");
            foreach (Pet pet in Pets)
            {
                Console.WriteLine($"Name: {pet.PetName}\t Species: {pet.PetSpecies}\t Health: {pet.PetHealth}\t" +
                    $"Boredom: {pet.PetBoredom}\tHunger: {pet.PetHunger}\n");
            }

        }

        // Method to Add a pet to the List - Admit()
        public void Admit(Pet pet)
        {
            Pets.Add(pet);
        }

        // Method to Remove a pet from the List - Adopt()
        public void Adopt(Pet pet)
        {
            Pets.Remove(pet);
        }

        // TODO Create multiple Method to interact with multiple pets or one pet - FeedAll(), PlayAll(), TakeAllToDoctor()
    }
}

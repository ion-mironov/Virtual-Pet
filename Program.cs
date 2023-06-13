// Your Program Code Here
Console.WriteLine("Welcome to Virtual Pet!\n");

// Main menu will consist of options to add a pet to the shelter, adopt a pet, and see what pets are currently in the shelter.
Console.WriteLine("What would you like to do?");
Console.WriteLine("1. Add a pet");
Console.WriteLine("2. Adopt a pet");
Console.WriteLine("3. See what pets are in the shelter\n");
Console.Write("Enter a line number: ");
int mainMenuSelection = Convert.ToInt32(Console.ReadLine());

// Have user select what species their new pet is.
Console.WriteLine("What is the species of your new pet?");
Console.WriteLine("1. Wolf");
Console.WriteLine("2. Fox");
Console.WriteLine("3. Red Panda");
Console.WriteLine("4. Dragon");
Console.WriteLine("5. Rabbit\n");
Console.Write("Enter a line number: ");
int speciesSelection = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the name of your pet?");
string petNameInput  = Console.ReadLine();

// Ask user if the pet is organic or robotic.
Console.WriteLine("What variation of species is your pet?");
Console.WriteLine("1. Organic");
Console.WriteLine("2. Robotic\n");
Console.Write("Enter a line number: ");
int variationSelection = Convert.ToInt32(Console.ReadLine());
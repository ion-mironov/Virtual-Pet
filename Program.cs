// Your Program Code Here
Console.WriteLine("Welcome to Virtual Pet!\n");

// Main menu will consist of options 

// Have user select what species their new pet is.
Console.WriteLine("What is the species of your new pet?");
Console.WriteLine("1. Wolf");
Console.WriteLine("2. Fox");
Console.WriteLine("3. Red Panda");
Console.WriteLine("4. Raccoon");
Console.WriteLine("5. Dragon");
Console.WriteLine("6. Fish");
Console.WriteLine("7. Rabbit\n");
Console.Write("Enter a line number: ");
int speciesSelection = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the name of your pet?");
string petNameInput  = Console.ReadLine();
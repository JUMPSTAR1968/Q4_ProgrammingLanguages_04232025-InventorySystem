using System;
using System.Collections.Generic;

namespace InventorySystem 
{ 
    class Program 
    { 
        static List<string> inventory = new List<string>();
        static void Main(string[] args) 
        {
            bool running = true;

            //Run the menu loop until the user exits
            while (running == true) 
            {
                //Press 1 View Inventory
                //Press 2 Add Item in Inventory
                //Press 3 Remove Item
                //Press 4 Exit
                Console.Clear();
                Console.WriteLine("===SIMPLE INVENTORY SYSTEM===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item in Inventory");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select an Option: "); //Prompts the user for input
                string input = Console.ReadLine(); //Read users menu selection

                switch (input) //Handles different menu options
                {
                    case "1":
                        ViewInventory();
                        break;

                    case "2":
                        AddItem();
                        break;
                    
                    case "3":
                        RemoveItem();
                        break; 
                    
                    case "4":
                        running = false;
                        break;

                    default:
                        break;
                }
            }
            static void ViewInventory() 
            { 
                Console.Clear ();
                for (int i = 0; i < inventory.Count; i++) //Loop through inventory items
                { 
                    Console.WriteLine($"{i+1}.{inventory[i]}");//Display each item with numbers
                }
                Console.WriteLine("Press Enter to continue...."); //Prompt to continue
                Console.ReadLine(); //Wait for user input
            }

            static void AddItem()
            {
                Console.Clear();
                Console.WriteLine("Enter item name to add: "); //Prompt for item name
                string item = Console.ReadLine(); //Read item name from user
                inventory.Add(item); //Add item to inventory
                Console.WriteLine($"'{item}' added to the inventory"); //confirm addition
                Console.WriteLine("Press Enter to continue..."); //Prompt to continue
                Console.ReadLine(); //Wait for user input
            }

            static void RemoveItem() 
            {
                Console.Clear();

                // Check if inventory is empty
                if (inventory.Count == 0)
                {
                    Console.WriteLine("Your inventory is empty. Nothing to remove.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    return;
                }

                // Display the inventory with indices
                Console.WriteLine("Select an item to remove:");
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i]}");
                }

                // Prompt the user for the index of the item to remove
                Console.WriteLine("Enter the number of the item to remove: ");
                string input = Console.ReadLine();

                // Validate the input and remove the item if valid
                if (int.TryParse(input, out int itemNumber) && itemNumber >= 1 && itemNumber <= inventory.Count)
                {
                    // Remove the item by its index (itemNumber - 1 since list is 0-indexed)
                    string removedItem = inventory[itemNumber - 1];
                    inventory.RemoveAt(itemNumber - 1);
                    Console.WriteLine($"'{removedItem}' has been removed from the inventory.");
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a valid number.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}


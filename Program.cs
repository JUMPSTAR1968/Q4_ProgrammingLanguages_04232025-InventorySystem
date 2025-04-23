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
                        break;

                    case "2":
                        AddItem();
                        break;
                    
                    case "3":
                        break; 
                    
                    case "4":
                        running = false;
                        break;

                    default:
                        break;
                }
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
        }
    }
}


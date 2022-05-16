using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{

    public class inventoryManager
    {
        // array of inventory items
        private inventoryItem[] inventoryItems;

        // constructor
        public inventoryManager(int size)
        {
            inventoryItems = new inventoryItem[size];
        }

        // method that adds new inventoryItem to the array
        public void add(inventoryItem item)
        {
            // create a for loop that will loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // add the new inventoryItem to the array to first empty index
                if (inventoryItems[i] == null)
                {
                    inventoryItems[i] = item;
                    break;
                }

            }
        }

        // create a method that will remove an inventoryItem from the inventoryItems array
        public void remove(inventoryItem item)
        {
            // create a for loop that will loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // if the inventoryItems array is not empty, check to see if the inventoryItem exists in the array
                if (inventoryItems[i] != null)
                {
                    // if the inventoryItem exists in the array, remove the quantity of the inventoryItem from the array
                    if (inventoryItems[i].getName() == item.getName())
                    {
                        inventoryItems[i].setQuantity(inventoryItems[i].getQuantity() - item.getQuantity());

                        break;
                    }

                }
                else
                {
                    // if the inventoryItem does not exist in the array, print an error message
                    Console.WriteLine("Item does not exist in inventory");
                }

            }

        }

        // method that will re-stock an inventoryItem in the array
        public void reStock(inventoryItem item, int quantity)
        {
            // loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // check to see if the inventoryItem exists in the array
                if (inventoryItems[i] != null)
                {
                    // if it exists. add to the quantity
                    if (inventoryItems[i].getName() == item.getName())
                    {
                        inventoryItems[i].setQuantity(inventoryItems[i].getQuantity() + quantity);
                        break;
                    }

                }
                else
                {
                    // if the inventoryItem does not exist in the array, print an error message
                    Console.WriteLine("Item does not exist in inventory");
                }

            }

        }


        // method that will display the inventoryItems within the inventoryItems array
        public void display()
        {
            // loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // print out details of non empty slots
                if (inventoryItems[i] != null)
                {
                    Console.WriteLine(inventoryItems[i].getName() + " " + inventoryItems[i].getId() + " " + inventoryItems[i].getQuantity() + " " + inventoryItems[i].getPrice());
                }

            }

        }

        // method that will search for an inventoryItem by name and return index
        public int Search(string search)
        {
            // loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // non empty slots
                if (inventoryItems[i] != null)
                {
                    // if it exists return the index
                    if (inventoryItems[i].getName() == search)
                    {
                        Console.WriteLine("Found " + search + " at index: " + i);
                        return i;
                    }

                }

            }

            // if it doesn't exist return -1 and print an error message
            Console.WriteLine("Not found.");
            return -1;
        }

        // method that will search for an inventoryItem by id and return index
        public int Search(int search)
        {
            // loop through the inventoryItems array
            for (int i = 0; i < inventoryItems.Length; i++)
            {
                // non empty slots
                if (inventoryItems[i] != null)
                {
                    // return index if it exists
                    if (inventoryItems[i].getId() == search)
                    {
                        Console.WriteLine("Found ID: " + search + " at index: " + i);
                        return i;
                    }

                }

            }

            // if it doesn't exist return -1 and print an error message
            Console.WriteLine("Not found.");
            return -1;
        }

    }
}


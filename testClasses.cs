using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class TestClasses
    {
        static void Main(string[] args)
        {
            // test inventoryItem class
            inventoryItem item1 = new inventoryItem("apple", 12, 0.89, 123);

            Console.WriteLine(item1.ToString() + "\n");

            // test inventoryItem class
            inventoryItem item2 = new inventoryItem("banana", 24, 1.29, 456);

            Console.WriteLine(item2.ToString() + "\n");

            // test inventoryItem class
            inventoryItem item3 = new inventoryItem("orange", 18, 0.99, 789);

            Console.WriteLine(item3.ToString() + "\n");

            // test inventoryManager class
            inventoryManager manager = new inventoryManager(5);

            manager.add(item1);
            manager.add(item2);
            manager.add(item3);

            Console.WriteLine("Added 3 items to inventory");
            // print out all items in inventory
            manager.display();

            // remove item from inventory
            manager.remove(item2);

            Console.WriteLine("\nAfter removing item2");
            manager.display();

            // restock item
            manager.reStock(item2, 10);

            Console.WriteLine("\nRestocked item2 by 10");
            manager.display();

            Console.WriteLine("\nSearching for orange: ");
            manager.Search("orange");

            Console.WriteLine("\nSearching for dragonfruit: ");
            manager.Search("dragonfruit");

            Console.WriteLine("\nSearching for ID 123: ");
            manager.Search(123);

            Console.WriteLine("\nSearching for ID 321: ");
            manager.Search(321);

        }
    }
}

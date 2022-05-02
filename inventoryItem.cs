using System;

public class Class1
{
    class inventoryItem
    {
        // VARIABLES
        private string name;
        private int quantity;
        private double price;
        private int id;


        // CONSTRUCTOR
        public inventoryItem(string name, int quantity, int id, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.id = id;
            this.price = price;

        }

        // INITIALIZER
        public inventoryItem()
        {
        }


        // NAME GETTER AND SETTER
        public void setName(string name)
        {
            this.name = name;
        }
        public void getName()
        {
            Console.WriteLine("Item: " + name);
        }


        // QTY GETTER AND SETTER
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void getQuantity()
        {
            Console.WriteLine("Quantity: " + quantity);
        }

        // PRICE GETTER AND SETTER
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void getPrice()
        {
            Console.WriteLine("Price: " + price);
        }

        // ID GETTER + SETTER
        public void setId(int id)
        {
            this.id = id;
        }
        public void getId()
        {
            Console.WriteLine("ID: " + id);
        }

        // PRINT ITEM METHOD FOR TESTS
        public void printItem()
        {
            Console.WriteLine("Item: " + name + " | Quantity: " + quantity + " | ID: " + id + " | Price: " + price);
        }


        static void Main()
        {
            inventoryItem testItem = new inventoryItem();

            testItem.name = "apple";
            testItem.quantity = 12;
            testItem.price = 0.99;
            testItem.id = 123456;


            testItem.printItem();

            inventoryItem textItem2 = new inventoryItem();
            textItem2.name = "bananas";
            textItem2.quantity = 8;
            textItem2.price = 1.29;
            textItem2.id = 654321;

            textItem2.printItem();


        }

    }

}

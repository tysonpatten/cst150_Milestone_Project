using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class inventoryItem
    {
        // variables
        private string name;
        private int quantity;
        private double price;
        private int id;

        // constructor
        public inventoryItem(string name, int quantity, double price, int id)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.id = id;
        }

        // getters and setters
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        // toString
        public override string ToString()
        {
            return "Name: " + name + "\nQuantity: " + quantity + "\nPrice: " + price + "\nID: " + id;
        }

        // equals
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            inventoryItem item = obj as inventoryItem;
            if ((object)item == null)
            {
                return false;
            }

            return (this.id == item.id);
        }



    }
}

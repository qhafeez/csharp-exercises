using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu newMenu = new Menu();

            MenuItem pizza = new MenuItem(1.00, "cheese pizza", "Main Course" );
            MenuItem cheeseSticks = new MenuItem(3.00, "cheese sticks", "Appetizer");
            MenuItem iceCream = new MenuItem(10.00, "ice cream", "dessert");

            newMenu.AddItem(pizza);
            newMenu.AddItem(cheeseSticks);
            newMenu.AddItem(iceCream);

            newMenu.items.ForEach((item) =>
            {
                string food = "Item: " + item.Description + "\n";
                food += "Category: " + item.Category + "\n";
                food += "Price: " + item.Price;
                Console.WriteLine(food);
            });
            Console.ReadLine();
        }
    }

    class Menu
    {
        public DateTime lastUpdated;
        public List<MenuItem> items = new List<MenuItem>();

        public void AddItem(MenuItem item)
        {
            items.Add(item);
            lastUpdated = DateTime.Now;
            Console.WriteLine(lastUpdated);
        }

        public Menu()
        {
            lastUpdated = DateTime.Now;
        }


    }

    class MenuItem
    {
       public double Price {get; set;}
       public string Description { get; set; }
       public string Category { get; set; }

        public MenuItem(double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример использования
        Order order = new Order();

        order.AddDish(new Appetizer("Оливье", 2.50m));
        order.AddDish(new MainCourse("Пюре с отбивной", 8.95m));
        order.AddDish(new Drink("Чай зеленый", 0.99m));
        order.AddDish(new Dessert("Десерт картошка", 1.45m));

        order.PrintReceipt();
    }
}



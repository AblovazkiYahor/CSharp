//Класс заказа
class Order
{
    private List<Dish> items = new List<Dish>();

    //Метод добавления блюда в заказ
    public void AddDish(Dish dish)
    {
        items.Add(dish);
    }

    //Метод расчета итоговой стоимости заказа с учетом скидки
    public decimal CalculateTotal()
    {
        decimal total = items.Sum(item => item.Price);

        //Применение скидки в 10%, если в заказе есть десерт
        if (items.Any(item => item is Dessert))
        {
            total *= 0.9m;
        }

        return total;
    }

    //Метод вывода информации о заказе
    public void PrintReceipt()
    {
        Console.WriteLine("Заказ:");

        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} - {item.Price:C}");
        }

        Console.WriteLine($"Общая стоимость: {CalculateTotal():C}");
    }
}


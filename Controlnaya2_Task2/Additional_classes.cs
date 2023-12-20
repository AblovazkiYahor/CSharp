// Дополнительные классы блюд которые наследуются от Dish

//Апперетив
class Appetizer : Dish
{
    public Appetizer(string name, decimal price) : base(name, price)
    {
    }
}

//Основное блюдо
class MainCourse : Dish
{
    public MainCourse(string name, decimal price) : base(name, price)
    {
    }
}

//Напиток
class Drink : Dish
{
    public Drink(string name, decimal price) : base(name, price)
    {
    }
}

//Десерт
class Dessert : Dish
{
    public Dessert(string name, decimal price) : base(name, price)
    {
    }
}


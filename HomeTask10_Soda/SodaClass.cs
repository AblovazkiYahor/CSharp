public class Soda
{
    private string flavor;

    //Конструктор класса Soda, принимающий параметр "вкус"
    public Soda(string flavor = null)
    {
        this.flavor = flavor;
    }

    //Метод для получения строковой репрезентации
    public string GetDescription()
    {
        if (!string.IsNullOrEmpty(flavor))
        {
            return $"У вас газировка с {flavor} вкусом";
        }
        else
        {
            return "У вас обычная газировка";
        }
    }
}

